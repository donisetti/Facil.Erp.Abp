FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/Facil.Erp.Web.Host/Facil.Erp.Web.Host.csproj", "src/Facil.Erp.Web.Host/"]
COPY ["src/Facil.Erp.Web.Core/Facil.Erp.Web.Core.csproj", "src/Facil.Erp.Web.Core/"]
COPY ["src/Facil.Erp.Application/Facil.Erp.Application.csproj", "src/Facil.Erp.Application/"]
COPY ["src/Facil.Erp.Core/Facil.Erp.Core.csproj", "src/Facil.Erp.Core/"]
COPY ["src/Facil.Erp.EntityFrameworkCore/Facil.Erp.EntityFrameworkCore.csproj", "src/Facil.Erp.EntityFrameworkCore/"]
WORKDIR "/src/src/Facil.Erp.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Facil.Erp.Web.Host", "src/Facil.Erp.Web.Host"]
COPY ["src/Facil.Erp.Web.Core", "src/Facil.Erp.Web.Core"]
COPY ["src/Facil.Erp.Application", "src/Facil.Erp.Application"]
COPY ["src/Facil.Erp.Core", "src/Facil.Erp.Core"]
COPY ["src/Facil.Erp.EntityFrameworkCore", "src/Facil.Erp.EntityFrameworkCore"]
WORKDIR "/src/src/Facil.Erp.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Facil.Erp.Web.Host.dll"]
