CREATE TABLE [COMMENT] (
  [Id] int NOT NULL IDENTITY(1,1),
  [Text] varchar(100),
  [Date] datetime,
  [ProblemId] int,
  [SenderId] int,
  PRIMARY KEY ([Id]),
  FOREIGN KEY(ProblemId) REFERENCES PROBLEM(Id),
  FOREIGN KEY(SenderId) REFERENCES SENDER(Id)
);

CREATE TABLE [PROBLEM] (
  [Id] int NOT NULL IDENTITY(1,1),
  [Title] varchar(50),
  [CreationDate] datetime,
  [Status] varchar(50),
  [TypeId] int,
  PRIMARY KEY ([Id]),
  FOREIGN KEY(TypeId) REFERENCES PROBLEM_TYPE(Id)
);

CREATE TABLE [SENDER] (
  [Id] int NOT NULL IDENTITY(1,1),
  [FirstName] varchar(50),
  [LastName] varchar(50),
  [Email] varchar(50),
  PRIMARY KEY ([Id])
);

CREATE TABLE [PROBLEM_TYPE] (
  [Id] int NOT NULL IDENTITY(1,1),
  [Name] varchar(50),
  PRIMARY KEY ([Id])
);

