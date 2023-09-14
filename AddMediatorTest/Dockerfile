FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["AddMediatorTest/AddMediatorTest.csproj", "AddMediatorTest/"]
RUN dotnet restore "AddMediatorTest/AddMediatorTest.csproj"
COPY . .
WORKDIR "/src/AddMediatorTest"
RUN dotnet build "AddMediatorTest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AddMediatorTest.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AddMediatorTest.dll"]
