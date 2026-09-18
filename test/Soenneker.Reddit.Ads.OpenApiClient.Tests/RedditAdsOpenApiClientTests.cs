using Soenneker.Tests.HostedUnit;

namespace Soenneker.Reddit.Ads.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class RedditAdsOpenApiClientTests : HostedUnitTest
{
    public RedditAdsOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
