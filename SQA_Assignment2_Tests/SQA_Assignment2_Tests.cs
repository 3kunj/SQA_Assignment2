using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQA_Assignment2;
using NUnit.Framework;


namespace SQA_Assignment2_Tests
{
    [TestFixture]
    public class SQA_Assignment2_Tests
    {
        [Test]
        public void Input0_ItIsZero()
        {
            //set values
            int line1=2;
            int line2=0;
            int line3=3;

            //implement Test
            string answer = TriangleSolver.Analyze(line1, line2, line3);

            //assert check
            StringAssert.Contains("This dimensions do not form triangle.Because dimension's size is zero,which is invaild",answer);

        }
        [Test]
        public void IsItNegative()
        {
            //set values
            int line1 = 2;
            int line2 = 1;
            int line3 = -3;

            //implement Test
            string answer = TriangleSolver.Analyze(line1, line2, line3);

            //assert check
            StringAssert.Contains("This dimensions do not form triangle.Because dimension's size is in negative,which is invaild", answer);

        }
        [Test]
        public void TwoEqualDimensionsSumNotEquals()
        {
            //set values
            int line1 = 1;
            int line2 = 1;
            int line3 = 2;

            //implement Test
            string answer = TriangleSolver.Analyze(line1, line2, line3);

            //assert check
            StringAssert.Contains("This dimensions do not form triangle.", answer);

        }
        [Test]
        public void ItformEquilateralTriangle()
        {
            //set values
            int line1 = 25;
            int line2 = 25;
            int line3 = 25;

            //implement Test
            string answer = TriangleSolver.Analyze(line1, line2, line3);

            //assert check
            StringAssert.Contains("Yes, it form triangle and It is an equilateral triangle", answer);

        }
        [Test]
        public void ItformIsoscelesTriangle()
        {
            //set values
            int line1 = 25;
            int line2 = 25;
            int line3 = 30;

            //implement Test
            string answer = TriangleSolver.Analyze(line1, line2, line3);

            //assert check
            StringAssert.Contains("Yes, it form triangle and It is an isosceles triangle", answer);

        }
        [Test]
        public void ItformScaleneTriangle()
        {
            //set values
            int line1 = 21;
            int line2 = 24;
            int line3 = 30;

            //implement Test
            string answer = TriangleSolver.Analyze(line1, line2, line3);

            //assert check
            StringAssert.Contains("Yes, it form triangle and It is a scalene triangle", answer);

        }
        [Test]
        public void ItDoesNotformEquilateralTriangle()
        {
            //set values
            int line1 = 21;
            int line2 = 24;
            int line3 = 30;

            //implement Test
            string answer = TriangleSolver.Analyze(line1, line2, line3);

            //assert check
            StringAssert.DoesNotContain("Yes, it form triangle and It is an equilateral triangle", answer);

        }
        [Test]
        public void ItDoesNotformTriangle()
        {
            //set values
            int line1 = 25;
            int line2 = 50;
            int line3 = 3;

            //implement Test
            string answer = TriangleSolver.Analyze(line1, line2, line3);

            //assert check
            StringAssert.Contains("This dimensions do not form triangle.", answer);

        }
    }
}
