FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim-arm64v8 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["./InternDetails.csproj", "src/"]
RUN dotnet restore "src/InternDetails.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "InternDetails.csproj" -c Release -o /app/build
FROM build AS publish
RUN dotnet publish "InternDetails.csproj" -c Release -o /app/publish
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ["dotnet", "InternDetails.dll"]