using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_5
{
    class RobotFibonacci : ICalcular
    {
        public int Calcular(int num)
        {
            int fibo0 = 0;
            int fibo1 = 1;
            if (num != 0)
            {
                for (int i = num; i > 0; i--)
                {
                    int var = fibo0 + fibo1;
                    fibo0 = fibo1;
                    fibo1 = var;
                }
                return fibo1;
            }
            else
            {
                return 0;
            }
        }
    }
}
