#FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443
#
#FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
#WORKDIR /src
#COPY ["EDIFabricWebAPI/EDIFabricWebAPI.csproj", "EDIFabricWebAPI/"]
#COPY ["../../../../../EDI Fabric Project/X12-Examples-master/X12-Examples-master/EdiFabric.Examples.X12.T835/EdiFabric.Examples.X12.T835.csproj", "../../../../../EDI Fabric Project/X12-Examples-master/X12-Examples-master/EdiFabric.Examples.X12.T835/"]
#COPY ["../../../../../EDI Fabric Project/X12-Examples-master/X12-Examples-master/EdiFabric.Examples.X12.Common/EdiFabric.Examples.X12.Common.csproj", "../../../../../EDI Fabric Project/X12-Examples-master/X12-Examples-master/EdiFabric.Examples.X12.Common/"]
#COPY ["../../../../../EDI Fabric Project/X12-Examples-master/X12-Examples-master/EdiFabric.Examples.X12.Templates.V5010.NoValidation/EdiFabric.Examples.X12.Templates.V5010.NoValidation.csproj", "../../../../../EDI Fabric Project/X12-Examples-master/X12-Examples-master/EdiFabric.Examples.X12.Templates.V5010.NoValidation/"]
#RUN dotnet restore "EDIFabricWebAPI/EDIFabricWebAPI.csproj"
#COPY . .
#WORKDIR "/src/EDIFabricWebAPI"
#RUN dotnet build "EDIFabricWebAPI.csproj" -c Release -o /app
#
#FROM build AS publish
#RUN dotnet publish "EDIFabricWebAPI.csproj" -c Release -o /app
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app .
#ENTRYPOINT ["dotnet", "EDIFabricWebAPI.dll"]

#
## Use Microsoft's official .NET image.
## https://hub.docker.com/r/microsoft/dotnet
#FROM microsoft/dotnet:2.2-sdk
#
## Install production dependencies.
## Copy csproj and restore as distinct layers.
#WORKDIR /app
#COPY *.csproj .
#COPY ["../../../../../EDI Fabric Project/X12-Examples-master/X12-Examples-master/EdiFabric.Examples.X12.T835/EdiFabric.Examples.X12.T835.csproj", "../../../../../EDI Fabric Project/X12-Examples-master/X12-Examples-master/EdiFabric.Examples.X12.T835/"]
#COPY ["../../../../../EDI Fabric Project/X12-Examples-master/X12-Examples-master/EdiFabric.Examples.X12.Common/EdiFabric.Examples.X12.Common.csproj", "../../../../../EDI Fabric Project/X12-Examples-master/X12-Examples-master/EdiFabric.Examples.X12.Common/"]
#COPY ["../../../../../EDI Fabric Project/X12-Examples-master/X12-Examples-master/EdiFabric.Examples.X12.Templates.V5010.NoValidation/EdiFabric.Examples.X12.Templates.V5010.NoValidation.csproj", "../../../../../EDI Fabric Project/X12-Examples-master/X12-Examples-master/EdiFabric.Examples.X12.Templates.V5010.NoValidation/"]
#RUN dotnet restore
#
## Copy local code to the container image.
#COPY . .
#
## Build a release artifact.
#RUN dotnet publish -c Release -o out
#
## Make sure the app binds to port 8080
#ENV ASPNETCORE_URLS http://*:8080
#
## Run the web service on container startup.
#CMD ["dotnet", "out/EDIFabricWebAPI.dll"]

#FROM microsoft/aspnetcore:latest
FROM microsoft/dotnet:2.2-sdk
WORKDIR /app
EXPOSE 80
COPY ./Publish/. ./
ENTRYPOINT ["dotnet", "BanqEDIService.dll"]