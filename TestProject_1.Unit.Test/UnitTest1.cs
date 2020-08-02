/********************************************************************************
 * Solution:    TestSolution_1.sln
 * Project:     TestProject_1.Unit.Test.csproj
 * File:        UnitTest1.cs
 * Author:      SSQ66648
 * Description: 
 *      Contains unit tests for class "CalculatorClass" in external project: "TestProject_1".
 *      used to learn how unit testing works in Visual Studio.
 * Notes:
 *  + TestProject_1 has been added as a project reference to access namespace.
 *  + uses "AAA" pattern for layout (Arrange, Act, Assert)
 * To Do:
 *  +
 * Lesser To Do:
 *  + check if variables can be global or must be repeated locally?
 *******************************************************************************/
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject_1;

namespace TestProject_1.Unit.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Add()
        {
            //Arrange
            var calculator = new CalculatorClass();
            int firstNumber = 6;
            int secondnumber = 8;
            int expected = 14;

            //Act
            int actual = calculator.Add(firstNumber, secondnumber);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Subtract()
        {
            //Arrange
            var calculator = new CalculatorClass();
            int firstNumber = 8;
            int secondnumber = 6;
            int expected = 2;

            //Act
            int actual = calculator.Subtract(firstNumber, secondnumber);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Multiply()
        {
            //Arrange
            var calculator = new CalculatorClass();
            int firstNumber = 6;
            int secondnumber = 8;
            int expected = 48;

            //Act
            int actual = calculator.Multiply(firstNumber, secondnumber);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Divide()
        {
            //Arrange
            var calculator = new CalculatorClass();
            int firstNumber = 30;
            int secondnumber = 10;
            int expected = 3;

            //Act
            int actual = calculator.Divide(firstNumber, secondnumber);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
