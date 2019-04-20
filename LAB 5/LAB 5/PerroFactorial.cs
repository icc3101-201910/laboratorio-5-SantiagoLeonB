using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_5
{
    class PerroFactorial : ICalcular
    {
        public int Calcular(int num)
        {
            int numero = 1;
            for (int i = num; i > 0; i--)
            {
                numero *= i;
            }
            return numero;  
        }
    }
}
