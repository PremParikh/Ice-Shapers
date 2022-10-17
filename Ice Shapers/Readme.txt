Hello, 
It's 9:45PM 13/10/2022 Let's get started 
// Starting with Creating a web page for Asp.net Core Web Application 
// My application name is Ice Shapers for ice cube trays 
//Configure New project with name : Ice Shapers, Location : C:\Users\Prem Parikh\source\repos\Ice Shapers\Ice Shapers\Ice Shapers.csproj
// Creating MVC for core web application

// creating first program "Welcome to the ICE_Shapers" in Index.cshtml
// just run it butttttt it's not run we have to comment sslPort from launchSetting.json

//Now it's Workssss. http://localhost:28620/ just check it.

//Add a controller : it's around 10:15PM 13/10/2022 
// Add New Item - enter HelloWorldController.cs and just Add it.

// Add a code from part#2, don't copy paste, written by yourself.
// and run it. it's works.
// http://localhost:28620/helloWorld

//Now using Welcome function which used in HelloWorldController.cs
// run the second method 
//http://localhost:28620/helloWorld/Welcome

//Add a code for another welcome method which used to show name and numtimes
//Using a upcoming code for this method
//Comment the previous one...
//http://localhost:28620/HelloWorld/Welcome/3?name=Rick&numtimes=4 
//it's time for eat something

////////////////////////Add a View
// Add a HelloWorld folder in VIEWS 
//Add > New Item IN helloworld folder
//File name is Index.cshtml.
//Replace the Content 
//Now you can see a magic at 11:05PM http://localhost:28620/HelloWorld

//time to change the title, footer and menu link in the layout file.
//<title>@ViewData["Title"] - Movie App</title> //<a class="navbar-brand" asp-controller="Movies" asp-action="Index">Movie App</a>
//&copy; 2020 - Movie App - <a asp-area="" asp-controller="Home" asp-action="Privacy">Privacy</a>
//This code accordingly my project ICE_CUBE TRAYS.

//Now you can see the privacy page also. http://localhost:28620/Home/Privacy

//Now open Views/HelloWorld/Index.cshtml and change Title and H2 TAG.
//http://localhost:28620/helloWorld

//Now Passing Data from the Controller to the View

//open HelloWorldController 
//comment almost all the part and add a IActionResult as per the instruction.
//Now Create a Welcome page in Views/HelloWorld
//Name is Welcome.cshtml.
//Write a code as per instruction. 
// And run it //http://localhost:28620/HelloWorld/Welcome?name=Rick&numtimes=4

//Now Add a Data model class 
//it's end the task for the day. 11:40PM 13/10/2022
//Add Models folder > Add > Class. Name : Ice.cs
//Add a code.

// Add a NuGet packages
// NuGet Package Manager > Package Manager Console (PMC) or Manage NuGet Package for solution.. which is better Way
// Microsoft.EntityFrameworkCore.SqlServer > Add a package.

//Now add a database context class
// Name : MvcIceContext.cs with code accordingly my project.
// add a library on the top of startup.cs
// Startup.ConfigureServices Add a configuaration file.
// & Also examine the database connection string in appsettings.json file
// Add a dark green portion from the tutorial and edit the name MvcIceContext: ... and so on...
//It's end of the work in this day almost 12:30AM 14/10/2022.

// Let started with a Scaffolding 
// Controllers folder + Add + New Scaffolded Item.
// Mvc + Mvc Controller with views, using Entity Framework.
// Just Add it.
//Model class: Ice(Ice_Shapers.Models) 
//Data context class(Ice_ShapersContext(Ice_Shapers.Data)
//Controller name: IceController

//Now add a one of the important portion MIGRATION: 10/14/2022 12:15PM
//Open a PMC 
//Add-Migratation -Ice_ShapersContext.cs
//And getting a big error which is parameter not found......................
//At line:1 char: 15
/// Let's try with new command........
// Add-Migration InitialCreate -Context Ice_ShapersContext
// Build succeeded......................

//Now open file Migrations/{timestamp}_InitialCreate.cs
//In my case: name : 20221014162955_InitialCreate.cs

//



