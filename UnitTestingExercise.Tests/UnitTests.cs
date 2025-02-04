using System;
using Xunit;

namespace UnitTestingExercise.Tests;

public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(0, 1, 1, 2)]
        [InlineData(3, 6, 9, 18)]
        public void Add_Test(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var c = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            var actual = c.Add(num1, num2, num3);

            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 0)] //Add test data <-------
        [InlineData(10, 5, 5)]
        [InlineData(3, 6, -3)]
        public void Subtract_Test(int num1, int num2, int expected)
        {
            // Start Step 3 here:

            // Arrange
            // create a Calculator object
            var c = new Calculator();

            // Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            var actual = c.Subtract(num1, num2);

            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 8, 32)] //Add test data <-------
        [InlineData(3, 3, 9)]
        [InlineData(-5, 6, -30)]
        public void Multiply_Test(int num1, int num2, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var c = new Calculator();

            // Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            var actual = c.Multiply(num1, num2);


            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(12, 2, 6)] //Add test data <-------
        [InlineData(3, 3, 1)]
        [InlineData(100, 4, 25)]
        public void Divide_Test(int num1, int num2, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var c = new Calculator();

            // Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            var actual = c.Divide(num1, num2);


            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }
    }