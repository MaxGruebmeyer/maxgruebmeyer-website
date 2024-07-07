# maxgruebmeyer-website

## Prerequisites

This project was made via Microsoft's ASP.NET. Therefore you need to install both
[.NET as well as ASP.NET](https://dotnet.microsoft.com/en-us/download).

## How to run

Navigate to `src/Website` and launch the ASP.NET project via `dotnet run`.
Per default (which can be adjusted by modifying `src/Website/Properties/launchSettings.json`)
the website starts on `localhost:5000`.

## TODO

- Once you're done with Sopro lift this to .NET 8.0 (and change nullable properties to required)
- Implement Pipeline with auto-formatter
- Implement Frontend Tests with Selenium
- What does someone need for DSGVO (cookie banner etc)
- Beautify shit with tailwindcss
- Purchase domain
- Create CI
- Link AWS and Deploy
- Automate deployment with terraform
- Create CD
- Check that website does not return any errors (console log, status codes)
- Perftest website & optimize
    - Chrome dev tools
    - Optimize bundle size & loading
- Review security & check for potential vulnerabilities
