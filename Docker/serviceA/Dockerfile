FROM mcr.microsoft.com/dotnet/sdk:8.0@sha256:35792ea4ad1db051981f62b313f1be3b46b1f45cadbaa3c288cd0d3056eefb83 AS build-env
WORKDIR /App

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0@sha256:6c4df091e4e531bb93bdbfe7e7f0998e7ced344f54426b7e874116a3dc3233ff
WORKDIR /App
COPY --from=build-env /App/out .
ENTRYPOINT ["dotnet", "serviceA.dll"]

# # The base image for our docker container
# FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
# WORKDIR /app

# # Copy .csproj and restore as distinct layers
# COPY . ./
# RUN dotnet restore

# # Copy the remaining files and build the project
# COPY . ./
# RUN dotnet publish -c Release -o /app/publish

# # Stage 2 - Runtime
# FROM mcr.microsoft.com/dotnet/runtime:6.0
# WORKDIR /app
# COPY --from=build /app/publish .

# # Command to run your service
# ENTRYPOINT ["dotnet", "serviceA.dll"]



