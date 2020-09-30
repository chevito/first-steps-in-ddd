using FluentAssertions;
using Xunit;

namespace Chevito.FirstStepsInDdd.Tests
{
    public class PreChargeDecisionTests
    {
        [Fact(Skip = "So the CI build stays green. Remove this to get coding.")]
        public void ShouldRecordAlternativeOffenceAdviceAgainstsSuspects()
        {
            true.Should().BeFalse();
        }
    }
}