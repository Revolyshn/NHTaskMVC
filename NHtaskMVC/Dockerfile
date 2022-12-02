FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["NHtaskMVC/NHtaskMVC.csproj", "NHtaskMVC/"]
RUN dotnet restore "NHtaskMVC/NHtaskMVC.csproj"
COPY . .
WORKDIR "/src/NHtaskMVC"
RUN dotnet build "NHtaskMVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NHtaskMVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NHtaskMVC.dll"]
