# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# csproj dosyalarını kopyala (cache için önemli)
COPY ["Core/MovieApi.Domain/MovieApi.Domain.csproj", "Core/MovieApi.Domain/"]
COPY ["Infrastructure/MovieApi.Persistence/MovieApi.Persistence.csproj", "Infrastructure/MovieApi.Persistence/"]
COPY ["Presentation/MovieApi.Presentation.csproj", "Presentation/"]

RUN dotnet restore "Presentation/MovieApi.Presentation.csproj"

# Tüm projeyi kopyala
COPY . .

WORKDIR "/src/Presentation"
RUN dotnet publish "MovieApi.Presentation.csproj" -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "MovieApi.Presentation.dll"]
