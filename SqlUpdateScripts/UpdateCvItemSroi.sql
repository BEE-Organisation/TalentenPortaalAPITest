ALTER TABLE [CV].[CVItem]
        ADD Sroi Bit NOT NULL
    DEFAULT (0)--Optional Default-Constraint.
WITH VALUES 

ALTER TABLE [CV].[CVItem] 
ADD PitchUrl nvarchar(max) NULL