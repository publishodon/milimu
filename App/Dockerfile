FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine-amd64 AS builder

WORKDIR /src

COPY . .

RUN dotnet restore \
    && dotnet publish -c release -o /app

FROM mcr.microsoft.com/dotnet/runtime:5.0-alpine-amd64

WORKDIR /app

COPY --from=builder /app .