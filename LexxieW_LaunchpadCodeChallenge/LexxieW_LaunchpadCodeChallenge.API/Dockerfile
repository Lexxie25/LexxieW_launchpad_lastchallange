#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LexxieW_LaunchpadCodeChallenge.API/LexxieW_LaunchpadCodeChallenge.API.csproj", "LexxieW_LaunchpadCodeChallenge.API/"]
COPY ["LaunchpadCodeChallange.Service/LaunchpadCodeChallange.Service.csproj", "LaunchpadCodeChallange.Service/"]
COPY ["LaunchpadCodeChallange.Repository/LaunchpadCodeChallange.Repository.csproj", "LaunchpadCodeChallange.Repository/"]
COPY ["LaunchpadCodeChallenge.Models/LaunchpadCodeChallenge.Models.csproj", "LaunchpadCodeChallenge.Models/"]
RUN dotnet restore "LexxieW_LaunchpadCodeChallenge.API/LexxieW_LaunchpadCodeChallenge.API.csproj"
COPY . .
WORKDIR "/src/LexxieW_LaunchpadCodeChallenge.API"
RUN dotnet build "LexxieW_LaunchpadCodeChallenge.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LexxieW_LaunchpadCodeChallenge.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LexxieW_LaunchpadCodeChallenge.API.dll"]