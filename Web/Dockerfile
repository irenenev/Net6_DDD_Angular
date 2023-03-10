FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Web/Web.csproj", "Web/"]
COPY ["Database/Database.csproj", "Database/"]
COPY ["Domain/Domain.csproj", "Domain/"]
RUN dotnet restore "Web/Web.csproj"
COPY . .
WORKDIR "/src/Web"
RUN dotnet build "Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Angular
FROM node AS angular
WORKDIR ./Web/Frontend/
COPY Web/Frontend/package.json ./
RUN npm run restore
COPY Web/Frontend ./
RUN npm run publish

# .NET Runtime
FROM base AS final
RUN apk add --no-cache icu-libs
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
WORKDIR /app
COPY --from=publish /app/publish .
COPY --from=angular /Web/Frontend/dist ./Frontend
ENTRYPOINT ["dotnet", "Web.dll"]