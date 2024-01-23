using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecolaTech.Aulas
{
    public class MenuInterativo()
    {
        public void Menu()
        {
            string opção;
            bool exibirMenu = true;

            while(exibirMenu)
            {
                Console.WriteLine("Digite a sua opção: ");
                Console.WriteLine("1 - Cadastrar Cliente:");
                Console.WriteLine("2 - Buscar Cliente:");
                Console.WriteLine("3 - Apagar Cliente:");
                Console.WriteLine("4 - Encerrar");     

                opção = Console.ReadLine();

                switch(opção)
                {
                    case "1":
                        Console.WriteLine("Cadastro de Cliente");
                        break;

                    case "2":
                        Console.WriteLine("Buscar Cliente");
                        break;

                    case "3":
                        Console.WriteLine("Apagar Cliente");
                        break;

                    case "4":
                        Console.WriteLine("Encerrar");
                        exibirMenu = false;
                        //Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opção Invalida!");
                        break;
        
                } 

            Console.WriteLine("O programa se encerrou!");    

            }
        }     
    }
}