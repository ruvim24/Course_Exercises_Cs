using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course_Exercises_Cs.UTs;
namespace TestProject1
{
    public class StringValidatorTest
    {
        [Fact]
        public void IsValidEmail_ShouldWork()
        {
            //Arange
            string email = "example@example.com";

            //Act
            bool actual = StringValidator.IsValidEmail(email);

            //Assert
            Assert.True(actual);
        }

        [Theory]
        [InlineData("example@example")]
        [InlineData("example.example")]
        [InlineData("example")]

        public void ValidateEmail_ShouldFail(string parameter)
        {
            //Arange
            bool actual = StringValidator.IsValidEmail(parameter);

            Assert.False(actual);
        }

        [Fact]
        public void IsPhoneNumber_ShouldWork()
        {
            //Arange
            string parameter = "0690174799";

            //Act
            bool actual = StringValidator.IsPhoneNumber(parameter);

            Assert.True(actual);
        }

        [Theory]
        [InlineData("1234")]
        [InlineData("1243asd")]
        [InlineData("asdfasdfasd")]
        public void IsPhoneNumber_ShouldFail(string parameter)
        {
            //Arange
            bool actual = StringValidator.IsPhoneNumber(parameter);
            //Assert
            Assert.False(actual);
        }
    }
}