# Doordash Client

A modern .NET library to help facilitate Doordash deliveries.

# IDoorDashClient

This uses Refit in the background. The client generates a JWT token based on the given Doordash credentials in your appsettings files, and is automatically used on each request.

# Usage
Use the extension method AddDoorDashClient as part of building your services/dependencies. Then, inject IDoorDashClient in the service of your choice. Simple as that!

