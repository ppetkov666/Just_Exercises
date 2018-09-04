using System;
using System.Collections.Generic;
using System.Text;

namespace EventExampleTask
{
    class Student
    {
        public string Name { get; set; }
        public void AttendClass(Teacher teacher)
        {
            teacher.StartTalking += Techer_StartTalking;
        }

        private void Techer_StartTalking(object sender, EventArgs e)
        {
            string teacher = ((Teacher)sender).Name;
            
            Console.WriteLine(this.Name + " "+"is listening to " + teacher);
        }
    }
}
