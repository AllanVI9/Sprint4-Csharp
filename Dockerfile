# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar arquivos de projeto e restaurar dependências
COPY *.csproj ./
RUN dotnet restore

# Copiar todo o código e publicar a aplicação em modo Release
COPY . ./
RUN dotnet publish -c Release -o out

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copiar arquivos publicados da etapa de build
COPY --from=build /app/out ./

# Expor porta 80 para acessar a aplicação
EXPOSE 80

# Comando para rodar a aplicação
ENTRYPOINT ["dotnet", "BibliotecaApi.dll"]
