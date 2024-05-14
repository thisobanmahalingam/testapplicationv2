FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env 
WORKDIR /app

COPY testapplicationv2/testapplicationv2.csproj ./testapplicationv2/
RUN dotnet restore ./testapplicationv2/

COPY . .
RUN dotnet build ./testapplicationv2/
RUN dotnet publish ./testapplicationv2/ -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT [ "dotnet", "testapplicationv2.dll" ]