FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /app

COPY backend.csproj ./
RUN dotnet restore backend.csproj

COPY . ./
RUN dotnet publish backend.csproj -c Release -o /out

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app
COPY --from=build /out ./
EXPOSE 8080
ENTRYPOINT ["dotnet", "backend.dll"]