using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecolaTech.Aulas
{
    public class OperadoresCondicionais
    {
        public void Estoque()
        {
            int quantidadeEmEstoque = 10;
            int quantidadeCompra = 0;
            bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

            Console.WriteLine("Quantidade em Estoque: " + quantidadeEmEstoque);
            Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
            Console.WriteLine($"É possível realizar a Venda? {possivelVenda}");

            if (quantidadeCompra == 0)
            {
                Console.WriteLine("Venda Invalida!");
            }

            else if (possivelVenda)
            {
                Console.WriteLine("Venda realizada!");
            }
            else
            {
                Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
            }
        }
    }
}