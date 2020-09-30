using FluentAssertions;
using System;
using Xunit;

namespace Chevito.FirstStepsInDdd.Tests
{
    public class PoliceInvestigationTests
    {
        private readonly PNCId _pncId;
        private readonly Suspect _suspect;
        private readonly PoliceInvestigation _policeInvestigation;

        public PoliceInvestigationTests()
        {
            _pncId = new PNCId("1234-ESDT");
            _suspect = new Suspect(CriminalOffence.FALSE_ACCOUNTING);
            _policeInvestigation = new PoliceInvestigation(_pncId, _suspect);
        }

        [Fact]
        public void MustHaveAPoliceNationalComputerId()
        {
            _policeInvestigation.PNCId.Should().NotBeNull();
        }

        [Fact]
        public void CannotBeCreatedWithEmptyPoliceNationalComputerId()
        {
            var result = Record.Exception(() => new PoliceInvestigation(null, _suspect));

            result.Should().NotBeNull();
            result.Should().BeOfType<ArgumentNullException>();
        }

        [Fact]
        public void CannotBeCreatedWithNoSuspect()
        {
            var result = Record.Exception(() => new PoliceInvestigation(_pncId, null));

            result.Should().NotBeNull();
            result.Should().BeOfType<ArgumentNullException>();
        }
    }
}