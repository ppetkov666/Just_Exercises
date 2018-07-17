using System;
using System.Collections.Generic;
using System.Text;

namespace _04___Set_Value
{
    class TestReflection
    {
        private string name;

        public TestReflection(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return this.name; }
            
        }
    }
}
