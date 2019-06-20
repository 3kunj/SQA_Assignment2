using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_Assignment2
{
    public static class TriangleSolver
    {
        public static string Analyze(int a,int b,int c)
        {
            string result = "This dimensions do not form triangle.";
            if(a==0 || b==0 || c==0)
            {
                result += "Because dimension's size is zero,which is invaild";  
            }
            if (a < 0 || b < 0 || c < 0)
            {
                result += "Because dimension's size is in negative,which is invaild";
            }

            if(a>0 && b>0 && c>0)
            {
            
                if(a+b>c && b+c>a && a+c>b)
                {
                    if(a==b && b==c)
                    {
                        result = "Yes, it form triangle and It is an equilateral triangle";
                    }
                    else if(a==b || b==c || c==a)
                    {
                        result = "Yes, it form triangle and It is an isosceles triangle";
                    }
                    else
                    {
                        result = "Yes, it form triangle and It is a scalene triangle";
                    }
                }
            }

            return result;
        }
    }
}
