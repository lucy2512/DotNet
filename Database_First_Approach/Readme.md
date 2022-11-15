# DatabaseFirstAppPK
## A MVC application using Database First Approcah (Entity Framework)
### Step-1
#### Add 3 Dependencies
#### 1.Microsoft.EntityFrameworkCore.SqlServer
#### 2.Microsoft.EntityFrameworkCore.Tools
#### 3.Microsoft.Extensions.Configuration
### Step-2
#### Add ConnectionString in appsettings.json file
### Step-3
#### Tools->NuGet Package Manager->Package Manager Control
#### Run Command-> Scaffold-DbContext "Server=DESKTOP-9POA90V\SQLEXPRESS;Database=StudentDB;Integrated Security=True;Encrypt = False" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
### Step-4
#### Add MVC Controller with view, using Entity Framework
