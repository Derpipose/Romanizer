using FluentAssertions;
using Romanizer;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CommonModels;

namespace TestingRomanizing.Features
{
    [Binding]
    public class RomanizingSteps
    {

        private readonly Romanize _romanizer = new Romanize();
        private string _result = "";

        [Given(@"input of (.*)")]
        public void GivenInputOf(int p0)
        {
            _romanizer.Input = p0;

        }

        [Given(@"our input is (.*)")]
        public void GivenOurInputIs(int p0)
        {
            _romanizer.Input = p0;
        }


        [When(@"converted to Roman numerals")]
        public void WhenConvertedToRomanNumerals()
        {
            _result = _romanizer.Romanization();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(string result)
        {
            _result.Should().Be(result);
        }
    }
}
