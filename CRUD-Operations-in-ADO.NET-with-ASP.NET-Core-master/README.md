# CRUD Operations in ADO.NET with ASP.NET Core
In this repository I have perfomred CRUD Operations (CREATE, READ, UPDATE & DELETE) on a Teachers table in the Database.

![CRUD Operations]
## Compatible with ASP.NET Core MVC 5.0

This repository is made for beginners who want to learn 3 things:

1. [ASP.NET Core]
2. ADO.NET
3. CRUD Operations

Download this repository and open it in Visual Studio. Then create the database and teachers table in it. Finally change the connection string given inside the appsetting.json file and you are set to go:

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=School;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
```


# How to create Teacher table

Run the following script to create the Teacher table in your database.

```
CREATE TABLE [dbo].[Teacher]
(
    [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [Name] VARCHAR(50) NOT NULL,
    [Skills] VARCHAR(250) NOT NULL,
    [TotalStudents] INT NOT NULL,
    [Salary] MONEY NOT NULL,
    [AddedOn] DATE NOT NULL DEFAULT GETDATE()
)
```

# Wait, There is more for you

I have explained each and every area of the code in my HACKERNOON article - [ASP.NET CORE — Learn CRUD Operations in ADO.NET from Zero to Hero]

## Support

If you find it useful then support this Project. Thank you.


## Dont forget to Star this repository. Thank You !
