# maxgruebmeyer-website

## Prerequisites

This project was made via Microsoft's ASP.NET. Therefore you need to install both
[.NET as well as ASP.NET](https://dotnet.microsoft.com/en-us/download).

## How to run

Navigate to `src/Website` and launch the ASP.NET project via `dotnet run`.
Per default (which can be adjusted by modifying `src/Website/Properties/launchSettings.json`)
the website starts on `localhost:5000`.

## TODO

- Develop basic website
    - Contact Information (incl. mail sending service)
    - CV
    - About me
    - Link to GitHub
    - Projects Page
    - Useful resources
        - Recommended Books
        - Recommended Videos (e.g. Essence of Linear Algebra) - would be nice to have a latex parser for that one
        - Some interesting exercises - possibly in German (e.g. Thomaesche Funktion)
        - Lecture notes - possibly in German
        - Redirect page with useful links (like unia.xyz)
        - Interesting research papers
        - Blog?
    - Impressum
    - What does someone need for DSGVO (cookie banner etc)
    - Some dev tools (make this hidden?)
        - Hex/bin conversion
        - Binominalkoeffizient rechner
        - etc
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
