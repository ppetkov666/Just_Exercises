namespace ConcatTwoNames
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            Test name = new Test("Petko", "Petkov");
            if (name.IsValid(name))
            {
                name.ConcatenameTwoNames();
            }
        }
    }
}
