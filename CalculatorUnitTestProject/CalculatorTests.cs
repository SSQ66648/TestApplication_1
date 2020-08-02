/********************************************************************************
 * Solution:    TestSolution_1.sln
 * Project:     CalculatorUnitTestProject.csproj
 * File:        UnitTest1.cs
 * Author:      SSQ66648
 * Description: 
 *      Unit test for CalculatorClass (project: TestProject_1).
 * Condition:
 *  +
 * Notes:
 *  + using xUnit framework.
 *  + attempts to use the "AAA" (Arrange, Act, Assert) pattern for unit tests.
 *      -Arrange: Initialize objects and set value of data passed to method.
 *      -Act: Invoke method being tested.
 *      -Assert: Verify method invoked behaves as expected.
 * To Do:
 *  + get reference to external project
 *  + implement methods
 * Lesser ToDo:
 *  + look into library project namespace ?
 *  + address and adopt naming conventions
 *******************************************************************************/
using System;
using Xunit;

namespace CalculatorUnitTestProject
{
    public class CalculatorTests
    {
        //toDo: addition
        [Fact]
        public void Test_Add()
        {
            //arrange
            int firstNumber = 8;
            int secondNumber = 6;
            int expected = 14;

            //act


            //assert
        }

        //toDo: subtraction
        //toDo: multiplication
        //toDo: division

    }
}
