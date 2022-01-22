//This project is purely for building database scaffolding into other projects
//It's just here so I don't have to include design-time packages in other projects or remove them before publishing
//Don't publish this project, and don't have other projects reference it

//Use the Solution root folder as the working directory when running the scaffolding command.
//PMC command to scaffold (using EFCore.Tools):
//Scaffold-DbContext -Connection 'Data Source=..\BaseballModel\Data\baseball.db' -Provider Microsoft.EntityFrameworkCore.Sqlite -Project BaseballModel -StartupProject BaseballScaffolding -Context BaseballContext -ContextDir Context -OutputDir Entities -DataAnnotations -Verbose

Console.WriteLine("Hello, World!");
