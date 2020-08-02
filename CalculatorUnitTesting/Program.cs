/********************************************************************************
 * Solution:    TestSolution_1.sln
 * Project:     TestProject_1.csproj
 * File:        Program.cs
 * Author:      SSQ66648
 * Description: 
 *      Contains unit tests for class "CalculatorClass" in external project: "TestProject_1".
 *      used to learn how unit testing works in Visual Studio.
 * Notes:
 *  +   v1.0 (addition only) uses manual inclusion of existing item: CalculatorClass from project in same solution.
 *          -created in reference to unclear online resource: refactoring to Unit testing framework for v2.0.
 * To Do:
 *******************************************************************************/
using System;
using TestProject_1;

namespace CalculatorUnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //naive implementation of test for addition
            var calculator = new CalculatorClass();
            int result = calculator.Add(8, 6);
            if (result != 14)
            {
                throw new InvalidOperationException();
            }
            else
            {
                Console.WriteLine("Addition test passed.");
            }
        }
    }
}
