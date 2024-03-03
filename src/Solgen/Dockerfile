FROM mcr.microsoft.com/dotnet/sdk:8.0-bookworm-slim AS build
WORKDIR /src

COPY . .
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o output

FROM mcr.microsoft.com/dotnet/aspnet:8.0-bookworm-slim AS serve
WORKDIR /app

COPY --from=build /src/output .
ENV ASPNETCORE_URLS=http://+:5000
EXPOSE 5000

CMD ["dotnet", "Solgen.Api.dll"]