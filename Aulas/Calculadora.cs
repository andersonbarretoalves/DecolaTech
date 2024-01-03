using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecolaTech.Aulas
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"Soma {x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"Subtração {x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"Multiplicação {x} x {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"Divisão {x} / {y} = {x / y}");
        }
    }
}