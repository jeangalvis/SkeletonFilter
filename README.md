webapi

    <PackageReference Include="AspNetCoreRateLimit" Version="5.0.0" />
    <PackageReference Include="AutoMapper.Extensions.Microsoft.DependencyInjection" Version="12.0.1" />
    <PackageReference Include="Microsoft.AspNetCore.Authentication.JwtBearer" Version="7.0.12" />
    <PackageReference Include="Microsoft.AspNetCore.Mvc.Versioning" Version="5.1.0" />
    <PackageReference Include="Microsoft.AspNetCore.OpenApi" Version="7.0.12" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="7.0.12">

Domain

    <PackageReference Include="FluentValidation.AspNetCore" Version="11.3.0" />
    <PackageReference Include="itext7.pdfhtml" Version="5.0.1" />
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="7.0.12" />

Persistence

    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="7.0.12" />
    <PackageReference Include="Pomelo.EntityFrameworkCore.MySql" Version="7.0.0" />

dotnet new sln
dotnet new classlib -o Domain
dotnet new classlib -o Persistence
dotnet new classlib -o Application
dotnet new webapi -o API

dotnet sln add .\Domain
dotnet sln add .\Persistence
dotnet sln add .\API

cd Application
dotnet add reference ..\Domain
dotnet add reference ..\Persistence
cd ..
cd .\API
dotnet add reference ..\Application
cd ..
cd Persistence
dotnet add reference ..\Domain
cd ..


