using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_5
{
    class Calculadora
    {
        private int numero;
        public List<ICalcular> calculadoras;
        public Calculadora(int numero)
            {
            this.numero = numero;
            calculadoras = new List<ICalcular>();
            }
        public int GetNumero()
        {
            return numero;
        }
        public void Calcular()
        {
            int TotalCalculadoras = calculadoras.Count;
            Random rnd = new Random();
            int calcula2ra = rnd.Next(0, TotalCalculadoras);
            ICalcular xd = calculadoras[calcula2ra];
            Console.WriteLine(calcula2ra);   //*Sirve para ver el indice de la operacion realizada(0=suma5, 1=Fibo...)
            numero = xd.Calcular(numero);           
        }
    }
}
