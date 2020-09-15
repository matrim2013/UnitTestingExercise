using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(10,10,10,30)]

        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var testOne = new UnitTestMethods();
            //Act
            var actual = testOne.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20,10,10)]
        [InlineData(30,5,25)]
        [InlineData(10, 15, -5)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var testTwo = new UnitTestMethods();
            //Act
            var actual = testTwo.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,2, 10)]
        [InlineData(4,2, 8)]
        [InlineData(9,0,0)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var testThree = new UnitTestMethods();
            //Act
            var actual = testThree.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,5,2)]
        [InlineData(8,2,4)]
        
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var testFour = new UnitTestMethods();
            //Act
            var actual = testFour.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(9, 0)]
        public void DivideException(int num1, int num2)
        {

            //Arrange
            var testFour = new UnitTestMethods();
            var expected = new DivideByZeroException();

            //Act
            //var actual = testFour.Divide(num1, num2);
            //Assert
            var answer = Assert.Throws<DivideByZeroException>(() => testFour.Div(9, 0));

            Assert.Equal(expected.Message, answer.Message);
        }


        [Fact]
        public void YourMethodName()
        {
            //Arrange

            //Act

            //Assert

        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
