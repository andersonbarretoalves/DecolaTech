using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecolaTech.Aulas
{
    public class TabuadaWhile()
    
    {
        public void WhileTabuada()
        {
            int numero = Convert.ToInt32(Console.ReadLine());

            int contador = 0;

            while (contador <= 10)
            {
                Console.WriteLine($" {contador + 1}º Tabuada: {numero} x {contador} = {numero * contador}");
                contador++;

                if (contador == 6)
                {
                    break;
                }
            }
        }
    }
}