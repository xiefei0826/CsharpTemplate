
docker build -t identityserver ./IdentityServer


docker stack deploy --prune  -c docker-compose.yml oauth