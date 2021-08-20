using FluentAssertions;
using Newtonsoft.Json;
using PactNet.Matchers;
using Xunit;

namespace PactNet.Tests.Matchers
{
    public class IncludeMatcherTests
    {
        [Fact]
        public void Ctor_WhenCalled_SerialisesCorrectly()
        {
            const string example = "partial";

            var matcher = new IncludeMatcher(example);

            string actual = JsonConvert.SerializeObject(matcher);
            string expected = $@"{{""messagePact:matcher:type"":""include"",""value"":""{example}""}}";

            actual.Should().BeEquivalentTo(expected);
        }
    }
}