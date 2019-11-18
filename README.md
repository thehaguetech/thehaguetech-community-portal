# thehaguetech-community-portal
The Hague Tech Community Portal Development

Backend:
For the Backend we are using Dotnet and the Entitiy Framework
Install the dotnet SDK from: 
https://dotnet.microsoft.com/download

run the backend with: dotnet run
see the website on localhost/5000

make sure you have all the Entitiy Framework packages installed.
If not run following queries in the terminal:
dotnet add package Microsoft.EntityFramework.sqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet restore
dotnet tool install --global dotnet-ef