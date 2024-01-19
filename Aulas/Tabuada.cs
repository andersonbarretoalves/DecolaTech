using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecolaTech.Aulas
{
    public class Tabuada
    {
        public void ContatorTabuada(){
            
            int numero = Convert.ToInt32(Console.ReadLine());
                       

            for(int cont = 0; cont <= 10; cont++)
            {
                Console.WriteLine($"{numero} x {cont} = { numero * cont}");
            }
        }
    }
}