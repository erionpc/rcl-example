# Razor Class Library example
This solution illustrates how to serve content from a ASP.NET application based on .NET 6 in response to web requests towards Razor pages and API controllers, using a Razor Class Library.

## Solution contents
- [RCLExample.XRCLLib](RCLExample/RCLExample.XRCLLib): is a sample razor class library with contains razor pages and static content.
- [RCLExample.Web](RCLExample/RCLExample.Web) is a sample web application which references RCLExample.XRCLLib and serves content from it as if it was part of the web app. It also contains 2 controllers:
  - [WeatherForecastController](RCLExample/RCLExample.Web/Controllers/WeatherForecastController.cs): sample controller which returns a JSON response
  - [ProxyController](RCLExample/RCLExample.Web/Controllers/ProxyController.cs): redirects to a razor page or to an external URL as defined on configuration
