## Environment

- [x] Multiple environment
- [x] Pass environment variables

```bash
sh build-docker.sh
docker-compose -f docker/docker-compose.yaml up
open http://localhost/app/weatherForecast
```

## Run

```bash
set ASPNETCORE_ENVIRONMENT Production
dotnet src/MyWeb/bin/Debug/net5.0/MyWeb.dll
```

## App

```bash
set ConnectionString 'Host=xyz'
dotnet run --project src/MyApp
```