# Doordash Client

A modern .NET library to help facilitate Doordash deliveries.

## Drive API Support

We support using Drive Classic and V2. Both can be used at the same time if desired.

## How It's Done

This uses Refit in the background. The client generates a JWT token based on the given Doordash credentials in your appsettings files, and is automatically used on each request.

## Usage

Use the appropriate client for your needs. It needs the configuration so it can retrieve the Doordash settings from appsettings or in the environment.

For classic:
- Use the IServiceCollection extension method AddDoordashDriveClassic as part of building your services/dependencies.

---
    services.AddDoordashDriveClassic(IConfiguration config)
---

For V2:
- Use the IServiceCollection extension method AddDoordashDriveV2 as part of building your services/dependencies.

---
    services.AddDoordashDriveV2(IConfiguration config)
---

Simple as that!