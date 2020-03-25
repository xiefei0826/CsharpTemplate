FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
#EXPOSE 80
EXPOSE 7001

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Oauth.csproj", "Oauth/"]
RUN dotnet restore "Oauth.csproj"
COPY . .
WORKDIR "/src/Oauth"
RUN dotnet build "Oauth.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Oauth.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Oauth.dll"]