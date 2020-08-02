/********************************************************************************
 * Solution:    TestSolution_1.sln
 * Project:     TestProject_1.csproj
 * File:        Program.cs
 * Author:      SSQ66648
 * Description: 
 *      Entry point for test application: 
 *      Used for experimentation while learning how to operate Visual Studio.
 *      Includes basic-arithemetic calculator class for testing unit-tests.
 * Notes:
 *  +   Solution and project renamed from "TestApplication_1" for hierarchical clarity.
 * To Do:
 *  +   Experiment with C# basic methods
 *  +   Add calculator class
 *  +   Create unit test for calculator class
 *******************************************************************************/


using System;

namespace TestApplication_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstString = "first string";
            string secondString;

            Console.WriteLine("Uppercase string: " + firstString);
            Console.WriteLine("Enter second string contents:");
            secondString = Console.ReadLine();
            Console.WriteLine("Entered text: \n\t" + secondString);



        }
    }
}
