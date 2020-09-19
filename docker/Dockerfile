FROM mcr.microsoft.com/dotnet/core/sdk:5.0-alpine as build

WORKDIR /app

COPY src/MyWeb/MyWeb.csproj src/MyWeb/
RUN dotnet restore src/MyWeb
COPY src/MyWeb src/MyWeb

RUN dotnet publish src/MyWeb \
    -r linux-musl-x64 \
    -c Release \
    -o /out

# runtime
FROM mcr.microsoft.com/dotnet/core/runtime:5.0-alpine
WORKDIR /app
COPY --from=build /out .
CMD dotnet MyWeb.dll
EXPOSE 80