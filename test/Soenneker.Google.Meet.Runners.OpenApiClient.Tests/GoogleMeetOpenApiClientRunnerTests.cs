using Soenneker.Tests.HostedUnit;

namespace Soenneker.Google.Meet.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class GoogleMeetOpenApiClientRunnerTests : HostedUnitTest
{
    public GoogleMeetOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
