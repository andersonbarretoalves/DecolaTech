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
            Console.WriteLine($"Soma: {x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"Subtração: {x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"Multiplicação: {x} x {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"Divisão: {x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);  //utilizado a classe "Math", onde já tem várias operações prontas.
            Console.WriteLine($"Potência: {x} ^ {y} = {pot}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}* = {Math.Round(seno, 4)}");
        }

        public void Cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"CosSeno de {angulo}* = {Math.Round(cosseno, 4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}* = {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz Quadrada de {x} = {raiz}");
        }
    }
}