using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecolaTech.Aulas
{
    public class OperadoresLogicos
    {
        public void acesso()
        {
            bool ehMaiorDeIdade = false;
            bool possuiAutorizacaoDoResponsavel = true;

            if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel) //Ou
            {
                Console.WriteLine("Entrata liberada");
            }
            else
            {
                Console.WriteLine("Entrada não libarada");
            }
        }

        public void presenca() 
        {
            bool possuiPresencaMinima = true;
            double media = 6.5;

            if (possuiPresencaMinima && media >= 7) //e
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }

        public void clima()
        {
            bool choveu = true;
            bool estaTarde = true;

            if (!choveu && !estaTarde) //not
            {
                Console.WriteLine("Vou Pedalar");
            }
            else
            {
                Console.WriteLine("Vou pedalar um outro dia");
            }
        }
    }
}