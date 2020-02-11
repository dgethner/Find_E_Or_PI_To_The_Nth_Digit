using Find_E_To_The_Nth_Digit;
using System;
using FakeItEasy;
using Shouldly;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace Find_E_Or_Pi_To_The_Nth_Digit.Tests
{
    [TestClass]
    public class IsValidTests
    {
        [Theory]
        [InlineData(null, false)]
        [InlineData("1111", false)]
        [InlineData("-2", false)]
        [InlineData("q", true)]
        [InlineData("s", true)]
        [InlineData("3", true)]
        public void IsValidValidatesUserInput(string number, bool blah)
        {
            IsValid input = new IsValid();
            bool confirmValue = input.isValidInput(number);

            confirmValue.ShouldBe(blah);
        }

    }
}