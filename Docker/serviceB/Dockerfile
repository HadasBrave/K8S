FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

COPY script.cs ./

RUN dotnet new console -n MyAppB
RUN mv script.cs MyAppB/Program.cs

WORKDIR /app/MyAppB
RUN dotnet build -c Release

FROM mcr.microsoft.com/dotnet/runtime:6.0
WORKDIR /app

COPY --from=build /app/MyAppB/bin/Release/net6.0/ .

ENTRYPOINT ["dotnet", "MyAppB.dll"]
