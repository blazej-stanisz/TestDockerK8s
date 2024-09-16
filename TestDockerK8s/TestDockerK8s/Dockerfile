FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

#copy .csproj file and restore packages
COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/sdk:8.0
WORKDIR /app
COPY --from=build-env /app/publish .
ENTRYPOINT ["dotnet", "TestDockerK8s.dll"]