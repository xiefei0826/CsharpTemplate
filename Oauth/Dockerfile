FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
#EXPOSE 80
EXPOSE 7001

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["OAuth.csproj", "OAuth/"]
RUN dotnet restore "OAuth.csproj"
COPY . .
WORKDIR "/src/OAuth"
RUN dotnet build "OAuth.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OAuth.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OAuth.dll"]