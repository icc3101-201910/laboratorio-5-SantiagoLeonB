using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_5
{
    class Cubo : ICalcular
    {
        public int Calcular(int num)
        {
            return num * num * num;
        }    
    }
}
