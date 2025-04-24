ALTER TABLE [CV].[CVItem]
        ADD ShowItem Bit NOT NULL
    DEFAULT (1)--Optional Default-Constraint.
WITH VALUES 