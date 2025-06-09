FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src/ProjectBoardApp

COPY ["ProjectBoardApp.csproj", "."]

RUN dotnet restore

COPY . .

# Build a framework-dependent application
RUN dotnet publish -c Release -o /app/publish \
    && ls -l /app/publish 

FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS final
WORKDIR /app

# Ensure icu-libs and libstdc++ are present (still good practice for AspNet base image on Alpine)
RUN apk add --no-cache icu-libs libstdc++

COPY --from=build /app/publish .

# Run the application using 'dotnet' and the DLL
ENTRYPOINT ["dotnet", "ProjectBoardApp.dll"]