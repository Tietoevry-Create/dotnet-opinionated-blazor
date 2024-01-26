# An opinionated Blazor app

A web app sample using .NET 8.0 Blazor SSR+WASM, Tailwind CSS and with htmx.org+hyperscript.org support.

Put together as quick _proof of concept_, starting from the default dotnet templates, by the .NET _Keep Learning_ Community at Tietoevry.

Ideas are to avoid Blazor Server Web Socket/SignalR scaling and connection worries but still be able to use Web Assembly for interactive Blazor where suitable.

When in a more classic request/response mode, we can use Blazor SSR components and lean on htmx.org+hyperscript.org for interactivity.

<img src="https://raw.githubusercontent.com/Tietoevry-Create/dotnet-opinionated-blazor/main/docs/screenshot.png" width="500" height="815" alt="Screenshot">

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
cd BlazorAppSsrWasm
dotnet watch run
```

Now app should be browsable: https://localhost:7182
