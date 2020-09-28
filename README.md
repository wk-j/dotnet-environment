## Environment


```bash
sh build-docker.sh
docker-compose -f docker/docker-compose.yaml up
open http://localhost/app/weatherForecast
```

## Run

```bash
ASPNETCORE_ENVIRONMENT=Production dotnet src/MyWeb/bin/Debug/net5.0/MyWeb.dll
```