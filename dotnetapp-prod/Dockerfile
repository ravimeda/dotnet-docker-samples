FROM microsoft/dotnet:2.0-sdk AS build-env
WORKDIR /app

# copy csproj files and restore as distinct layers
COPY dotnetapp-prod/*.csproj ./dotnetapp-prod/
COPY library/*.csproj ./library/
RUN dotnet restore dotnetapp-prod/dotnetapp.csproj 

# copy everything else and build
COPY dotnetapp-prod/ ./dotnetapp-prod/
COPY library/ ./library/
RUN dotnet publish dotnetapp-prod/dotnetapp.csproj -c Release -o out

# build runtime image
FROM microsoft/dotnet:2.0-runtime 
WORKDIR /app
COPY --from=build-env /app/dotnetapp-prod/out ./
ENTRYPOINT ["dotnet", "dotnetapp.dll"]
