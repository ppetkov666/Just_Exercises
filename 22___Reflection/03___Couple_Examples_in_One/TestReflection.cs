using System;
using System.Collections.Generic;
using System.Text;

namespace _03___Couple_Examples_in_One
{
    class TestReflection:IDeriverdInterface,IBaseInterace
    {
        private string testPropertyString;
        private int testPropertyInteger;

        private static string name;
        public static int age;


        public TestReflection(string inputString, int inputInteger)
        {
            this.TestPropertyString = inputString;
            this.TestPropertyInteger = inputInteger;
        }
        public string TestPropertyString
        {
            get { return this.testPropertyString; }
            set { this.testPropertyString = value; }
        }

        // i will leave this property in this way just for test purposes!!! 
        public int TestPropertyInteger { get; set; }

        public string DoSomething()
        {
            return "I did It";
        }
    }
    interface IBaseInterace
    {

    }
    interface IDeriverdInterface
    {

    }


}
