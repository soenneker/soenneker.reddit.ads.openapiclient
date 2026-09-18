[![](https://img.shields.io/nuget/v/soenneker.reddit.ads.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.reddit.ads.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.reddit.ads.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.reddit.ads.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.reddit.ads.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.reddit.ads.openapiclient/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Reddit.Ads.OpenApiClient
### A generated OpenAPI client for the Reddit Ads API.

## Installation

```
dotnet add package Soenneker.Reddit.Ads.OpenApiClient
```

## Generated API

Generated from Reddit's Ads API v3 document at
<https://ads-api.reddit.com/api/v3/openapi.json>. The repository includes the upstream
`openapi.json`, normalized `openapi.fixed.json`, and generated request builders and models.
Use `Soenneker.Reddit.Ads.OpenApiClientUtil` for configured dependency injection and
bearer authentication, or construct `RedditAdsOpenApiClient` with a Kiota request adapter.

Available request builders include `Ad_accounts`, `Campaigns`, `Ad_groups`, `Ads`,
`Custom_audiences`, `Product_catalogs`, `Pixels`, and `Me`.

Regenerate with `Soenneker.Reddit.Ads.Runners.OpenApiClient`; do not hand-edit generated
models. The runner reapplies the image-asset factory workaround required by Kiota.
