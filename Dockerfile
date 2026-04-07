FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Копируем проект в правильную папку
COPY GenshinImpactManager/GenshinImpactManager.csproj ./GenshinImpactManager/
RUN dotnet restore ./GenshinImpactManager/GenshinImpactManager.csproj

# Копируем все остальные файлы
COPY GenshinImpactManager/. ./GenshinImpactManager/

WORKDIR /src/GenshinImpactManager
RUN dotnet publish -c Release -o /app/publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "GenshinImpactManager.dll"]
