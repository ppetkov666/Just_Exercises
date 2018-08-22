using System;
using System.Collections.Generic;
using System.Text;

namespace StaticVsNonStaticFieldsTest
{
    class FirstTest
    {
        int a; // Instance fields:
        int b;
        int c;
        public void X()
        {
            this.a++; // Change instance field values:
            this.b++;
            this.c++;
            
        }
    }
}
