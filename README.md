webapi

- AspNetCoreRateLimit

- AutoMapper.Extensions.Microsoft.DependencyInjection

- Microsoft.AspNetCore.Authentication.JwtBearer

- Microsoft.AspNetCore.Mvc.Versioning

- Microsoft.AspNetCore.OpenApi

- Microsoft.EntityFrameworkCore.Design


Domain

- FluentValidation.AspNetCore

- itext7.pdfhtml" Version

- Microsoft.EntityFrameworkCore


Persistence

- Microsoft.EntityFrameworkCore

- Pomelo.EntityFrameworkCore.MySql


- dotnet new sln
- dotnet new classlib -o Domain
- dotnet new classlib -o Persistence
- dotnet new classlib -o Application
- dotnet new webapi -o API

- dotnet sln add .\Domain
- dotnet sln add .\Persistence
- dotnet sln add .\API

- cd Application
- dotnet add reference ..\Domain
- dotnet add reference ..\Persistence
- cd ..
- cd .\API
- dotnet add reference ..\Application
- cd ..
- cd Persistence
- dotnet add reference ..\Domain
- cd ..


