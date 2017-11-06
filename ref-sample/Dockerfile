FROM microsoft/dotnet:2.0-sdk AS build-env
WORKDIR /app

# copy everything and build the project
COPY . ./
RUN dotnet restore dotnetapp/*.csproj
RUN dotnet publish dotnetapp/*.csproj -c Release -o out

# build runtime image
FROM microsoft/dotnet:2.0-runtime
WORKDIR /app
COPY --from=build-env /app/dotnetapp/out ./
ENTRYPOINT ["dotnet", "dotnetapp.dll"]
