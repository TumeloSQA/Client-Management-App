# Client-Management-App
Developer Test. C#, WCF, ASP.NET MVC

Set up Guideline:
- Install Visual Studio 2015/2017
- Clone this repo to your Visual Studio
- Install SQL Server 2014 Management Studio
- Create a Database (i.e ClientManagerDB)
- Run the following scripts to create DB Tables

CREATE TABLE [dbo].[ClientDetails] (
    [clientId]   INT          IDENTITY (1, 1) NOT NULL,
    [name]       VARCHAR (50) NOT NULL,
    [gender]     VARCHAR (50) NOT NULL,
    [cellNumber] VARCHAR (50) NOT NULL,
    [workTel]    VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_ClientDetails] PRIMARY KEY CLUSTERED ([clientId] ASC)
);

CREATE TABLE [dbo].[ClientAddress] (
    [addressId]   INT          IDENTITY (1, 1) NOT NULL,
    [resAddress]  VARCHAR (50) NOT NULL,
    [workAddress] VARCHAR (50) NULL,
    [posAddress]  VARCHAR (50) NULL,
    [clientId]    INT          NULL,
    CONSTRAINT [PK_ClientAddress] PRIMARY KEY CLUSTERED ([addressId] ASC),
    CONSTRAINT [fk_category] FOREIGN KEY ([clientId]) REFERENCES [dbo].[ClientDetails] ([clientId]) ON DELETE CASCADE
);

- From Visual Studio project, connect to the above SQL Server database
- Copy its Connection Strings to WCF connection string's
- Set MVC project as StartUp project
