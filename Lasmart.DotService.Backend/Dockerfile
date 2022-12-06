FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Lasmart.DotService.Backend/Lasmart.DotService.Backend.csproj", "Lasmart.DotService.Backend/"]
RUN dotnet restore "Lasmart.DotService.Backend/Lasmart.DotService.Backend.csproj"
COPY . .
WORKDIR "/src/Lasmart.DotService.Backend"
RUN dotnet build "Lasmart.DotService.Backend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Lasmart.DotService.Backend.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Lasmart.DotService.Backend.dll"]
