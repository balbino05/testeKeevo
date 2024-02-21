FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app

# Copie o arquivo csproj e restaura dependências
COPY *.csproj ./
RUN dotnet restore

# Copie e publique o código
COPY . ./
RUN dotnet publish -c Release -o out

# Construa a imagem final
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "SeuProjeto.dll"]
