namespace Thread_and_Callback_simple_example
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    public class Calculate
    {
        readonly int _number;
        public CalculateNumbers _calculate;
        public Calculate(int number, CalculateNumbers calculate)
        {
            this._number = number;
            this._calculate = calculate;
        }

        public void CalculateSum ()
        {
            int sum = 0;
            for (int i = 1; i <= _number; i++)
            {
                sum += i;
            }            
            _calculate(sum);
        }
    }
}
