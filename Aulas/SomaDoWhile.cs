using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecolaTech.Aulas
{
    public class SomaDoWhile()
    {
        public void Soma()
        {
            int soma = 0, numero = 0;

            do
            {
                Console.WriteLine("Digite um numero (0 para parar): ");
                numero = Convert.ToInt32(Console.ReadLine());
                soma += numero;
            }while(numero != 0);

            Console.WriteLine($"Total da Soma dos Numeros digitados {soma}");
        }
    }
}