using Find_E_To_The_Nth_Digit;
using System;
using FakeItEasy;
using Shouldly;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace Find_E_Or_Pi_To_The_Nth_Digit.Tests
{
    [TestClass]
    public class ChooseEOrPiTests
    {
        
        [Fact]
        public void ChooseEOrPiCallstartOverPi()
        {
            ChooseEOrPi choice = A.Fake<ChooseEOrPi>();
            StartOver repeat = A.Fake<StartOver>();
            choice.choose("pi",repeat);
            
            A.CallTo(() => repeat.userInputMethod()).Returns("pi");
            A.CallTo(() => repeat.startOverPi()).MustHaveHappened();
        }
        
        [Fact]
        public void ChooseEOrPiCallstartOverE()
        {
            ChooseEOrPi choice = A.Fake<ChooseEOrPi>();
            StartOver repeat = A.Fake<StartOver>();
            choice.choose("e", repeat);

            A.CallTo(() => repeat.userInputMethod()).Returns("e");
            A.CallTo(() => repeat.startOverE()).MustHaveHappened();
        }

        [Fact]
        public void ChooseEOrPiQuitTheProgram()
        {
            ChooseEOrPi choice = A.Fake<ChooseEOrPi>();
            StartOver repeat = A.Fake<StartOver>();
            string message = choice.displayString("q");

            A.CallTo(() => repeat.userInputMethod()).Returns("q");
            message.ShouldBe("\nYou have quit the program");
        }

        [Theory]
        [InlineData("f", "\nInvalid input, please enter either 'e' or 'pi'\n")]
        [InlineData("g", "\nInvalid input, please enter either 'e' or 'pi'\n")]
        [InlineData("h", "\nInvalid input, please enter either 'e' or 'pi'\n")]
        public void ChooseEOrPiDisplayInvalidInput(string userInput, string message)
        {
            ChooseEOrPi choice = A.Fake<ChooseEOrPi>();
            StartOver repeat = A.Fake<StartOver>();
            string test = choice.displayString(userInput);

            A.CallTo(() => repeat.userInputMethod()).Returns("f");
            test.ShouldBe(message);
        }
    }
}
