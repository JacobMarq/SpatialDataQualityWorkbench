FROM mcr.microsoft.com/dotnet/sdk:10.0

WORKDIR /src

EXPOSE 8080

ENV ASPNETCORE_URLS=http://+:8080

CMD ["dotnet", "watch", "run", "--project", "src/SpatialDataQuality.Api/SpatialDataQuality.Api.csproj", "--no-launch-profile"]
