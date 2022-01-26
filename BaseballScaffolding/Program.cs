//This project is purely for building database scaffolding into other projects using EFCore.Tools
//It's just here so I don't have to include EFCore.Tools in other projects for design-time work or remove it before publishing
//Don't publish this project, and don't have other projects reference it

//Use the Solution root folder as the working directory when running the scaffolding command.

//PMC command to scaffold baseball.db (Sean Lahman's baseball stats database):
//Scaffold-DbContext -Connection 'Data Source=..\BaseballModel\Data\baseball.db' -Provider Microsoft.EntityFrameworkCore.Sqlite -Project BaseballModel -StartupProject BaseballScaffolding -Context BaseballContext -ContextDir Context -OutputDir Entities -DataAnnotations -Verbose

//PMC command to scaffold transacations.db (my supplementary db for entering extra info about player trades):
//Scaffold-DbContext -Connection 'Data Source=..\BaseballModel\Data\transactions.db' -Provider Microsoft.EntityFrameworkCore.Sqlite -Project BaseballModel -StartupProject BaseballScaffolding -Context TransContext -ContextDir Context -OutputDir Entities -DataAnnotations -Verbose


//after using either command, change the path in the context file's OnConfiguring method to only use
//"Data Source=Data\\<database here>" instead of the longer path.
//      optionsBuilder.UseSqlite("Data Source=Data\\baseball.db");
//      optionsBuilder.UseSqlite("Data Source=Data\\transactions.db");


Console.WriteLine("Hello, World!");