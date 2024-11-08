## Project create 
```bash
dotnet new sln -n ClsApi
```
```bash
dotnet new classlib -n ClsApi.Domain
```
```bash
dotnet new classlib -n ClsApi.Application
```
```bash
dotnet new classlib -n ClsApi.Infrastructure
```
```bash
dotnet new webapi -n ClsApi.Api
```
```bash
dotnet sln add ClsApi.Domain
```
```bash
dotnet sln add ClsApi.Application
```
```bash
dotnet sln add ClsApi.Infrastructure
```
```bash
dotnet sln add ClsApi.Api
```

## Application Dependencies
```bash
cd ClsApi.Application
dotnet add reference ../ClsApi.Domain
```
 
## Infrastructure Dependencies
```bash
cd ../ClsApi.Infrastructure
dotnet add reference ../ClsApi.Application
```

## API Dependencies
```bash
cd ../ClsApi.Api
dotnet add reference ../ClsApi.Application
dotnet add reference ../ClsApi.Infrastructure
```

```bash
cd ClsApi.Infrastructure
dotnet tool update --global dotnet-ef

dotnet ef migrations add InitialCreate --project ../ClsApi.Infrastructure --startup-project ../ClsApi.Api
dotnet ef database update --project ../ClsApi.Infrastructure --startup-project ../ClsApi.Api
```

### GET : http://localhost:5147/api/Employee/AllEmployees
### GET : http://localhost:5147/api/Employee/GetEmployeeById/{EmpNo}
### POST : http://localhost:5147/api/Employee/CreateEmployee
```bash
{
  "empNo": 1018,
  "firstName": "string",
  "lastName": "string",
  "designation": "string",
  "hireDate": "2024-01-01",
  "salary": 0,
  "deptNo": 0,
}
```
### PUT : http://localhost:5147/api/Employee/UpdateEmployee
### DELETE : http://localhost:5147/api/Employee/DeleteEmployee/{EmpNo}