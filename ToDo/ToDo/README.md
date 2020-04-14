# ToDo App

A basic app to list your todos

## Items Used
    * Project type: Asp.Net Core 3.0
    * IDE: Jetbrains Rider
    * Data base: SQLite
 
# Entity
    * Item

# Steps
    * Set up Environment
        -   dotnet add package Microsoft.EntityFrameworkCore.SQLite
        -   dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
        -   dotnet add package Microsoft.EntityFrameworkCore.Design
        -   dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    
    * Generate razorpage of Entity (Item) (.cshtml and .cs)
        -   dotnet aspnet-codegenerator razorpage -m Item -dc ItemContext -udl -outDir Pages/Items --referenceScriptLibraries
    
    * Update Entity Framework tool
            -   dotnet tool update --global dotnet-ef --version 3.1.3
    
    * Add Migrations
        -   dotnet ef migrations add InitialCreate
    
    * Create or update database
        -   dotnet ef database update
    
    * Test App
      