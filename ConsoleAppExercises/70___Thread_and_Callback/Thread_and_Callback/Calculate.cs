using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Thread_and_Callback
{
    public class Calculate
    {
        int _number;
        public CalculateNumbers _calculate;
        public Calculate(int number, CalculateNumbers calculate)
        {
            this._number = number;
            this._calculate = calculate;
        }

        public void CalculateSum()
        {
            int sum = 0;
            for (int i = 1; i <= _number; i++)
            {
                sum += i;
            }
            Thread.Sleep(3000);
            _calculate(sum);
        }
    }
}
