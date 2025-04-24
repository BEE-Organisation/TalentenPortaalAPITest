using CrossCuttingConcerns;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TalentLogic.Logic;
using TalentLogic.Logic.BusinessObjects;

namespace TalentBackend.Controllers
{
    //[Authorize(Roles = "ADMIN")]
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        //private readonly IUserService _userService;
        private readonly IEmailService _emailService;
        private readonly AppSettings _appSettings;

        public UsersController(
            //IUserService userService,
            IOptions<AppSettings> appSettings,
            IEmailService emailService)
        {
            //_userService = userService;
            _emailService = emailService;
            _appSettings = appSettings.Value;
        }

        //[AllowAnonymous]
        //[HttpPost("authenticate")]
        //public async Task<IActionResult> Authenticate([FromBody]UserDto userDto)
        //{
        //    var user = await _userService.Authenticate(userDto.Username, userDto.Password).ConfigureAwait(false);

        //    if (user == null)
        //        return BadRequest(new { message = "Username or password is incorrect" });

        //    var tokenHandler = new JwtSecurityTokenHandler();
        //    var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
        //    var tokenDescriptor = new SecurityTokenDescriptor
        //    {
        //        Subject = new ClaimsIdentity(new[]
        //        {
        //            new Claim(ClaimTypes.Name, user.Id.ToString()),
        //            new Claim(ClaimTypes.Role, user.Role)
        //        }),
        //        Expires = DateTime.UtcNow.AddDays(7),
        //        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        //    };
        //    var token = tokenHandler.CreateToken(tokenDescriptor);
        //    var tokenString = tokenHandler.WriteToken(token);

        //    // return basic user info (without password) and token to store client side
        //    return Ok(new
        //    {
        //        user.Id,
        //        user.Username,
        //        user.FirstName,
        //        user.LastName,
        //        user.Role,
        //        Token = tokenString
        //    });
        //}

        ////[Authorize(Roles = "Admin")]
        //[AllowAnonymous]
        //[HttpPost("register")]
        //public async Task<IActionResult> Register([FromBody]UserDto userDto)
        //{
        //    try
        //    {
        //        if (!EmailValidation.IsValidEmail(userDto.Username))
        //        {
        //            return BadRequest("Incorrect Email address used for username");
        //        }

        //        // save 
        //        await _userService.Create(userDto, userDto.Password).ConfigureAwait(false);
        //        return Ok();
        //    }
        //    catch (AppException ex)
        //    {
        //        // return error message if there was an exception
        //        return BadRequest(new { message = ex.Message });
        //    }
        //}

        //[HttpGet("GetAll")]
        //public async Task<IActionResult> GetAll()
        //{
        //    var userDtos = await _userService.GetAll().ConfigureAwait(false);
        //    return Ok(userDtos);
        //}

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetById(int id)
        //{
        //    var userDto = await _userService.GetById(id).ConfigureAwait(false);
        //    return Ok(userDto);
        //}

        //[HttpPut("{id}")]
        //public async Task<IActionResult> Update(int id, [FromBody]UserDto userDto)
        //{
        //    // map dto to entity and set id
        //    userDto.Id = id;

        //    try
        //    {
        //        // save 
        //        await _userService.Update(userDto, userDto.Password).ConfigureAwait(false);
        //        return Ok();
        //    }
        //    catch (AppException ex)
        //    {
        //        // return error message if there was an exception
        //        return BadRequest(new { message = ex.Message });
        //    }
        //}

        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    _userService.Delete(id);
        //    return Ok();
        //}

        [AllowAnonymous]
        [HttpPost("contactemail")]
        public async Task<IActionResult> ContactEmail(BOContactEmail contactEmail)
        {
            await _emailService.SendEmailMessage(contactEmail).ConfigureAwait(false);
            return Ok();
        }
    }
}