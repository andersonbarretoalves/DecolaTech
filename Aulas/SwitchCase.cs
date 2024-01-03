using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecolaTech.Aulas
{
    public class SwitchCase
    {
        public void TipoDeLetra()
        {
            Console.WriteLine("Digite uma Letra");
            string letra = Console.ReadLine();

            switch (letra)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":

                    Console.WriteLine("Vogal");
                    break;
                
                default:
                    Console.WriteLine("Não é uma Vogal");
                    break;

            }

        }
    }
}