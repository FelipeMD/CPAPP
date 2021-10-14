FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["CPAPP.API/CPAPP.API.csproj", "CPAPP.API/"]
RUN dotnet restore "CPAPP.API/CPAPP.API.csproj"
COPY . .
WORKDIR "/src/CPAPP.API"
RUN dotnet build "CPAPP.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CPAPP.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CPAPP.API.dll"]
