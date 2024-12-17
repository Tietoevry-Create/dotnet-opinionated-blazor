# An opinionated Blazor app

A web app sample using .NET 9.0 Blazor Static SSR (and none of the interactive modes), Tailwind CSS and with htmx.org+hyperscript.org support.

Put together as quick _proof of concept_, starting from the default dotnet templates, by the .NET _Keep Learning_ Community at Tietoevry.

App uses a classic request/response mode, we can use Blazor Static SSR components to structure markup and lean on htmx.org+hyperscript.org for interactivity.

_Note:_ Look in the `net8.0-with-wasm-example` branch for older code that also had Blazor WASM component support.

The [demo site on an Azure Linux App Service](https://blazorappssrwasm20240130173653.azurewebsites.net/) is published on push to `main`.

## Build frontend

This setup has very little JS involved, but we use npm to deliver updates for the Tailwind CLI and the JS libraries.

### Required to run the sample

From repository root, do:

`npm ci` (or `npm install`)

Then run `npm run prodbuild`

### When changing or adding stuff

To only monitor for Tailwind classes added, after getting JS built, the fastest option while developing is `npm run dev:css`

To monitor for JS changes as well, use `npm run dev`

## Start .NET app

Then or in parallel, from repository root, do:

```
cd src
cd BlazorApp
dotnet watch run
```

Now app should be browsable: https://localhost:7182

## Backlog

In addition to just adding more components such as the other types of common form controls and generic things:

* Add a strict Content Security Policy.
* Optimize cache headers.
* Add compression to all responses.
* Add minimal endpoint concept for rendering components partially.

## Open source references

Built using .NET 9.0 and with these packages and projects. Thank you!

| Project                                                   | License                   |
|-----------------------------------------------------------|---------------------------|
| [Tailwind CSS](https://tailwindcss.com/)                  | MIT                       |
| [htmx.org](https://htmx.org/)                             | Zero-Clause BSD           |
| [hyperscript.org](https://hyperscript.org/)               | BSD 2-Clause              |
| [FluentValidation](https://github.com/FluentValidation)   | Apache License 2.0        |
| [Webpack](https://webpack.js.org/)                        | MIT                       |
| [cross-env](https://github.com/kentcdodds/cross-env)      | MIT                       |
| [npm-run-all](https://github.com/mysticatea/npm-run-all)  | MIT                       |

Other things can be involved too but these are the ones we take a direct dependency on.
