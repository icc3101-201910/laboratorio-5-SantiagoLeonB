using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_5
{
    class Calculadora2
    {
        private int numero;
        public List<ICalcular> calculadoras;
        public Calculadora2(int numero)
        {
            this.numero = numero;
            calculadoras = new List<ICalcular>();
        }
        public int GetNumero()
        {
            return numero;
        }
        public void Calcular(int indice)
        {                      
            ICalcular xd = calculadoras[indice];
            int monochino = xd.Calcular(numero);
            numero = monochino;
        }
    }
}

