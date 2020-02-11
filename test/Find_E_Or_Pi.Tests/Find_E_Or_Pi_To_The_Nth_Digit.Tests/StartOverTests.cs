using Find_E_To_The_Nth_Digit;
using System;
using FakeItEasy;
using Shouldly;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace Find_E_Or_Pi_To_The_Nth_Digit.Tests
{
    [TestClass]
    public class StartOverTests
    {
        StartOver blah = A.Fake<StartOver>();

        [Fact]
        public void StartOverEInvalidInput()
        {
            StartOver invalidInput = new StartOver();
            IsValid isValid = A.Fake<IsValid>();
            invalidInput.startOverE();

            A.CallTo(() => isValid.isValidInput("")).Returns(false);
            A.CallTo(() => invalidInput.startOverE()).MustHaveHappened();
        }

        [Fact]
        public void StartOverESwitchToStartOverPi()
        {
            StartOver invalidInput = new StartOver();
            IsValid isValid = A.Fake<IsValid>();
            A.CallTo(() => blah.userInputMethod()).Returns("s");
            
            
            invalidInput.startOverE();
A.CallTo(() => blah.startOverPi()).MustHaveHappened();
        }
    }
}