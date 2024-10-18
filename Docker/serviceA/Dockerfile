# The base image for our docker container
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

COPY script.cs ./
RUN dotnet new console -n MyApp
RUN mv script.cs MyApp/Program.cs

WORKDIR /app/MyApp
RUN dotnet build -c Release

FROM mcr.microsoft.com/dotnet/runtime:6.0
WORKDIR /app

COPY --from=build /app/MyApp/bin/Release/net6.0/ .

ENTRYPOINT ["dotnet", "MyApp.dll"]


