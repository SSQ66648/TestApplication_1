﻿/********************************************************************************
 * Solution:    TestSolution_1.sln
 * Project:     TestProject_1.csproj
 * File:        CalculatorClass.cs
 * Author:      SSQ66648
 * Description: 
 *      Class representative of basic arithmetic caluclator.
 *      Used to experiment with classes and unit tests in Visual Studio.
 *      Contains methods for addition, subtraction, multiplication and division.
 * Notes:
 *  +   
 * To Do:
 *******************************************************************************/


using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject_1
{
    class CalculatorClass
    {
        //--------------------------------------
        // Methods
        //--------------------------------------
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            return x / y;
        }

    }
}
