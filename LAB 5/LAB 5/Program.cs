    using System;

namespace LAB_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elija opcion con la que desea operar: ");
            Console.WriteLine("[0] Al azar");
            Console.WriteLine("[1] Elegir opcion (Esta es la parter bonus, no funciona :( F )");
            string xdxdxd = Console.ReadLine();
            Calculadora calculadora = new Calculadora(0);
            Calculadora2 calculadora2 = new Calculadora2(0);
            PersonaQueSuma5 calc1 = new PersonaQueSuma5();
            RobotFibonacci calc2 = new RobotFibonacci();
            PerroFactorial calc3 = new PerroFactorial();
            Cubo calc4 = new Cubo();
            Cuadrado calc5 = new Cuadrado();
            calculadora.calculadoras.Add(calc1);
            calculadora.calculadoras.Add(calc2);
            calculadora.calculadoras.Add(calc3);
            calculadora.calculadoras.Add(calc4);
            calculadora.calculadoras.Add(calc5);
            calculadora2.calculadoras.Add(calc1);
            calculadora2.calculadoras.Add(calc2);
            calculadora2.calculadoras.Add(calc3);
            calculadora2.calculadoras.Add(calc4);
            calculadora2.calculadoras.Add(calc5);
            if (xdxdxd == "0")
            {
                Console.Write("¿Cuantas operaciones desea realizar? : ");
                int seleccion = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < seleccion; i++)
                {
                    calculadora.Calcular();
                    Console.WriteLine(calculadora.GetNumero());
                    Console.WriteLine();
                }
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("Ingrese la operacion que desea realizar: ");
                    Console.WriteLine("[0] Terminar");
                    Console.WriteLine("[1] Persona que suma 5");
                    Console.WriteLine("[2] Robot Fibonacci");
                    Console.WriteLine("[3] Perro Factorial");
                    Console.WriteLine("[4] Cubo");
                    Console.WriteLine("[5] Cuadrado");
                    
                    string seleccion = Console.ReadLine();
                    if (seleccion == "1")
                    {
                        calculadora2.Calcular(0);
                        Console.WriteLine(calculadora.GetNumero());
                    }
                    if (seleccion == "2")
                    {
                        calculadora2.Calcular(1);
                        Console.WriteLine(calculadora.GetNumero());
                    }
                    if (seleccion == "3")
                    {
                        calculadora2.Calcular(2);
                        Console.WriteLine(calculadora.GetNumero());
                    }
                    if (seleccion == "4")
                    {
                        calculadora2.Calcular(3);
                        Console.WriteLine(calculadora.GetNumero());
                    }
                    if (seleccion == "5")
                    {
                        calculadora2.Calcular(4);
                        Console.WriteLine(calculadora.GetNumero());
                    }
                    if (seleccion == "0")
                    {
                        break;
                    }                   
                }
            }
        }
    }
}
