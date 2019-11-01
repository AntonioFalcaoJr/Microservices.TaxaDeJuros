FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["1 - Presentation/Microservices.TaxaDeJuros.Api/Microservices.TaxaDeJuros.Api.csproj", "1 - Presentation/Microservices.TaxaDeJuros.Api/"]
RUN dotnet restore "1 - Presentation/Microservices.TaxaDeJuros.Api/Microservices.TaxaDeJuros.Api.csproj"
COPY . .
WORKDIR "/src/1 - Presentation/Microservices.TaxaDeJuros.Api"
RUN dotnet build "Microservices.TaxaDeJuros.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Microservices.TaxaDeJuros.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Microservices.TaxaDeJuros.Api.dll"]