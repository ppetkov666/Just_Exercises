using System;

namespace _02___Example_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            // Coaleascing Operator 
            string first = null;
            string second = null;
            string third = null;
            string fourth = "not empthy string";
            string finalResult = first ?? second ?? third ?? fourth;
            Console.WriteLine(finalResult);

           // this code firther down just demonstrate how many if else statement we have type if we dont use 
           // Coalescing Operator
           //if (first != null)
           //{
           //    finalResult = first;
           //}
           //else
           //{
           //    if (second != null)
           //    {
           //        finalResult = second;
           //    }
           //    else
           //    {
           //        if (third != null)
           //        {
           //            finalResult = third;
           //        }
           //        else
           //        {
           //            if (fourth != null)
           //            {
           //                finalResult = fourth;
           //            }
           //        }
           //    }
           //}
           //Console.WriteLine(finalResult);
        }
    }
}
