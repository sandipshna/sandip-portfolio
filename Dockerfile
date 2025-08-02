FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 10000

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MVC_AJAX(Lear)/MVC_AJAX(Lear).csproj", "MVC_AJAX(Lear)/"]
RUN dotnet restore "MVC_AJAX(Lear)/MVC_AJAX(Lear).csproj"
COPY . .
WORKDIR "/src/MVC_AJAX(Lear)"
RUN dotnet build "MVC_AJAX(Lear).csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MVC_AJAX(Lear).csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SandipPortfolio.dll"]