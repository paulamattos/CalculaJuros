FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["CalculaJuros/CalculaJuros.csproj", "CalculaJuros/"]
RUN dotnet restore "CalculaJuros/CalculaJuros.csproj"
COPY . .
WORKDIR "/src/CalculaJuros"
RUN dotnet build "CalculaJuros.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CalculaJuros.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CalculaJuros.dll"]