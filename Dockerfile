# Use the official .NET SDK image for the build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the solution file and restore the dependencies
COPY ["Tenders.Api/Tenders.Api.csproj", "Tenders.Api/"]
COPY ["Tenders.Api.Application/Tenders.Api.Application.csproj", "Tenders.Api.Application/"]
COPY ["Tenders.Api.Contracts/Tenders.Api.Contracts.csproj", "Tenders.Api.Contracts/"]

# Restore all the dependencies for the solution
RUN dotnet restore "Tenders.Api/Tenders.Api.csproj"

# Copy the entire solution
COPY . .

# Build the solution
WORKDIR /src/Tenders.Api
RUN dotnet build "Tenders.Api.csproj" -c Release -o /app/build

# Publish the build artifacts
FROM build AS publish
RUN dotnet publish "Tenders.Api.csproj" -c Release -o /app/publish

# Use the official .NET runtime image for the runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Set the entry point for the container
ENTRYPOINT ["dotnet", "Tenders.Api.dll"]