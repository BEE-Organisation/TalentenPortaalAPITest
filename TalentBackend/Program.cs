using BlobStorage;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using TalentDataAccess.DataAccess;
using TalentDataAccess.DataAccess.Repositories;
using TalentLogic.Logic;
using TalentLogic.Logic.Crud;
using TalentLogic.Logic.Crud.ReadOnly;
using HotChocolate.Types.Pagination;
using TalentBackend.Extensions;
using TalentLogic.GraphQL;
using TalentLogic.Logic.Email;
using MailKit.Security;

var builder = WebApplication.CreateBuilder(args);

//For PostgreSQL Databases and DateTime.
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

builder.Services
    .AddCors(options =>
    {
        options.AddPolicy("AllowOrigin",
#if DEBUG
            builder => builder.WithOrigins("https://localhost:4200")
#else
            builder => builder.WithOrigins("https://it-talenten-portaal-test-it-talenten-portaal-webapp-test.aamxwc.easypanel.host", "https://localhost:4200")
#endif
                              .AllowAnyHeader()
                              .AllowAnyMethod());
    });

builder.Services.AddScoped<IAzureBlobStorage>(factory => new AzureBlobStorage(new AzureBlobSettings(
    storageAccount: builder.Configuration["Blob_StorageAccount"],
    storageKey: builder.Configuration["Blob_StorageKey"],
    containerName: builder.Configuration["Blob_ContainerName"])));

#if DEBUG
var connection = builder.Configuration.GetConnectionString("TalentPortal-Localdb");
#else
var connection = builder.Configuration.GetConnectionString("TalentPortal");
#endif

builder.Services.AddDbContext<TalentDbContext>(options => options.UseNpgsql(connection));

builder.Services
    .AddGraphQLServer()
    .UseDefaultPipeline()
    .AddErrorFilter<GraphQLErrorFilter>()
    .AddProjections()
    .AddFiltering()
    .AddSorting()
    .RegisterDbContext<TalentDbContext>(DbContextKind.Pooled)
    .AddQueryType(d => d.Name("Query"))
    .AddResolvers()
    .AddMutationType(d => d.Name("Mutation"))
    .AddMutations()
    .SetPagingOptions(new PagingOptions { DefaultPageSize = 500, MaxPageSize = 500 });

builder.Services.AddRepositories();

builder.Services.AddScoped<ICVService, CVServiceImplementation>();
builder.Services.AddScoped<IDashboardRead, DashBoardInfoRead>();

builder.Services.AddScoped<ITalentPropertyCrud, TalentPropertyCrud>();
builder.Services.AddScoped<ITalentRefactoredCrud, TalentRefactoredCrud>();
builder.Services.AddScoped<ITalentPropertyLabelCrud, TalentPropertyLabelCrud>();
builder.Services.AddScoped<IOrganizationCrud, OrganizationCrud>();
builder.Services.AddScoped<ISearchFilterCrud, SearchFilterCrud>();
builder.Services.AddScoped<ICompanyCrud, CompanyCrud>();
builder.Services.AddScoped<IVacancyCompleteCrud, VacancyCompleteCrud>();
builder.Services.AddScoped<IEmailCrud, EmailCrud>();

builder.Services.AddScoped<IEducationDetailRepository, EducationDetailRepository>();
builder.Services.AddScoped<ITalentPropertyRepository, TalentPropertyRepository>();
builder.Services.AddScoped<ITalentRefactoredRepository, TalentRefactoredRepository>();
builder.Services.AddScoped<IPastExperienceRepository, PastExperienceRepository>();
builder.Services.AddScoped<IHobbyRepository, HobbyRepository>();
builder.Services.AddScoped<ITalentPropertyLabelRepository, TalentPropertyLabelRepository>();
builder.Services.AddScoped<IOrganizationRepository, OrganizationRepository>();
builder.Services.AddScoped<ISearchFilterRepository, SearchFilterRepository>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<IVacancyCompleteRepository, VacancyCompleteRepository>();
builder.Services.AddScoped<IVacancyOfferRepository, VacancyOfferRepository>();
builder.Services.AddScoped<IVacancyDemandRepository, VacancyDemandRepository>();
builder.Services.AddScoped<IVacancyDemandDetailRepository, VacancyDemandDetailRepository>();
builder.Services.AddScoped<IVacancyTextRepository, VacancyTextRepository>();

//Other, Email, etc.
//builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddTransient<IMailKitService, MailKitService>();
builder.Services.Configure<MailKitEmailSenderOptions>(options =>
{
    options.HostSecureSocketOptions = SecureSocketOptions.StartTls;
    options.HostAddress = builder.Configuration["ExternalProviders:MailKit:SMTP:Address"];
    options.HostPort = Convert.ToInt32(builder.Configuration["ExternalProviders:MailKit:SMTP:Port"]);
    options.HostUsername = builder.Configuration["ExternalProviders:MailKit:SMTP:Account"];
    options.HostPassword = builder.Configuration["ExternalProviders:MailKit:SMTP:Password"];
    options.SenderEMail = builder.Configuration["ExternalProviders:MailKit:SMTP:SenderEmail"];
    options.SenderName = builder.Configuration["ExternalProviders:MailKit:SMTP:SenderName"];
});


builder.Services.AddControllers(); 

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    // KeyCloak
    c.CustomSchemaIds(type => type.ToString());
    var securityScheme = new OpenApiSecurityScheme
    {
        Name = "KEYCLOAK",
        Type = SecuritySchemeType.OAuth2,
        In = ParameterLocation.Header,
        BearerFormat = "JWT",
        Scheme = "bearer",
        Flows = new OpenApiOAuthFlows
        {
            AuthorizationCode = new OpenApiOAuthFlow
            {
                AuthorizationUrl = new Uri(builder.Configuration["Jwt:AuthorizationUrl"]),
                TokenUrl = new Uri(builder.Configuration["Jwt:TokenUrl"]),
                Scopes = new Dictionary<string, string> { }
            }
        },
        Reference = new OpenApiReference
        {
            Id = JwtBearerDefaults.AuthenticationScheme,
            Type = ReferenceType.SecurityScheme
        }
    };
    c.AddSecurityDefinition(securityScheme.Reference.Id, securityScheme);
    c.AddSecurityRequirement(new OpenApiSecurityRequirement{
        {securityScheme, new string[] { }}
    });
});

// KeyCloak
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

}).AddJwtBearer(o =>
{
    o.Authority = builder.Configuration["Jwt:Authority"];
    o.Audience = builder.Configuration["Jwt:Audience"];
    o.RequireHttpsMetadata = false;
    o.Events = new JwtBearerEvents
    {
        OnAuthenticationFailed = c =>
        {
            c.NoResult();
            c.Response.StatusCode = 500;
            c.Response.ContentType = "text/plain";
            // Debug only for security reasons
            // return c.Response.WriteAsync(c.Exception.ToString());
            return c.Response.WriteAsync("An error occured processing your authentication.");
        }
    };
});

builder.Services.AddElmahIo(o =>
{
    o.ApiKey = "daf4a2960824433d8b556edba7b6dd3d";
    o.LogId = new Guid("e2dd7ca4-f110-4352-b940-ab5c54a49d6c");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyAppAPI");
        c.OAuthClientId(builder.Configuration["Jwt:ClientId"]);
        c.OAuthClientSecret(builder.Configuration["Jwt:ClientSecret"]);
        c.OAuthRealm(builder.Configuration["Jwt:Realm"]);
        c.OAuthAppName("KEYCLOAK");
    });
//}

app.UseElmahIo();

#if DEBUG
app.UseHttpsRedirection();
#endif
app.UseCors("AllowAll");

//#if DEBUG
app.UseCors("AllowOrigin");
//#endif

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.MapGraphQL();
app.Run();
