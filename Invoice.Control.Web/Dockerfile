FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS build
LABEL version="1.0" description="Invoice Control Web API"
WORKDIR /src
COPY Invoice.Control.Web.sln ./
COPY Invoice.Control.Api/*.csproj ./Invoice.Control.Api/
COPY Invoice.Control.Domain/*.csproj ./Invoice.Control.Domain
COPY Invoice.Control.Infrastructure/*.csproj ./Invoice.Control.Infrastructure/


RUN dotnet restore
COPY . .

WORKDIR /src/Invoice.Control.Domain
RUN dotnet build -c Release -o /app

WORKDIR /src/Invoice.Control.Infrastructure
RUN dotnet build -c Release -o /app

WORKDIR /src/Invoice.Control.Api
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Invoice.Control.Api.dll"]