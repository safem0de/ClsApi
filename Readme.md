dotnet new sln -n ClsApi

dotnet new classlib -n ClsApi.Domain
dotnet new classlib -n ClsApi.Application
dotnet new classlib -n ClsApi.Infrastructure
dotnet new webapi -n ClsApi.Api

dotnet sln add ClsApi.Domain 
dotnet sln add ClsApi.Application 
dotnet sln add ClsApi.Infrastructure 
dotnet sln add ClsApi.Api

# Application Dependencies
cd ClsApi.Application
dotnet add reference ../ClsApi.Domain
 
# Infrastructure Dependencies
cd ../ClsApi.Infrastructure
dotnet add reference ../ClsApi.Application

# API Dependencies
cd ../ClsApi.Api
dotnet add reference ../ClsApi.Application
dotnet add reference ../ClsApi.Infrastructure