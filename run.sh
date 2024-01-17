#!/bin/sh

docker stop minimal-api
docker build -t minimal-api-img:latest .
docker run --rm -p 8008:5123 --name minimal-api -d minimal-api-img