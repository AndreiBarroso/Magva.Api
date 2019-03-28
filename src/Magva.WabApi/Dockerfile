FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["src/Magva.WabApi/Magva.WabApi.csproj", "src/Magva.WabApi/"]
RUN dotnet restore "src/Magva.WabApi/Magva.WabApi.csproj"
COPY . .
WORKDIR "/src/src/Magva.WabApi"
RUN dotnet build "Magva.WabApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Magva.WabApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Magva.WabApi.dll"]