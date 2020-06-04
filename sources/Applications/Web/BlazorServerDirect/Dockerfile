#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Applications/Web/TheSharpFactory.App.BlazorServer/TheSharpFactory.App.BlazorServer.csproj", "Applications/Web/TheSharpFactory.App.BlazorServer/"]
RUN dotnet restore "Applications/Web/TheSharpFactory.App.BlazorServer/TheSharpFactory.App.BlazorServer.csproj"
COPY . .
WORKDIR "/src/Applications/Web/TheSharpFactory.App.BlazorServer"
RUN dotnet build "TheSharpFactory.App.BlazorServer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TheSharpFactory.App.BlazorServer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TheSharpFactory.App.BlazorServer.dll"]