using System;
using System.Collections.Generic;
using System.Text;

namespace MyTestLibrary
{
    class University
    {
        public void CreateStudent()
        {
            var student = new Student();
            student.internalField = "SetInternalField";
            student.publicField = "SetPublicField";
        }
    }
}
