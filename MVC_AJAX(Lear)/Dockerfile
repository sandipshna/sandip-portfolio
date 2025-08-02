FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["MVC_AJAX(Lear).csproj", "."]
RUN dotnet restore "./MVC_AJAX(Lear).csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "MVC_AJAX(Lear).csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MVC_AJAX(Lear).csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MVC_AJAX(Lear).dll"]