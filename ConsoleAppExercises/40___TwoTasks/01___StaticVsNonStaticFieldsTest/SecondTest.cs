using System;
using System.Collections.Generic;
using System.Text;

namespace StaticVsNonStaticFieldsTest
{
    class SecondTest
    {
        static int a; // Static fields:
        static int b;
        static int c;
        public void X()
        {
            a++; // Change static field values:
            b++;
            c++;
        }
    }
}
