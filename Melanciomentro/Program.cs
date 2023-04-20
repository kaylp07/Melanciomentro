using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 
    VerduraoDoJoao.Melanciomentro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Melancia Comum 2-Melancia Baby");
            int op =
                int.Parse(Console.ReadLine());
            double preco;
            if (op == 1)
            {
                preco = 5.50;
                Console.WriteLine("Melancia Comum:"+ preco.ToString());
                
             }
            else if (op ==2) 
            {
                preco = 8.56;
                Console.WriteLine("Melancia Baby:" + preco.ToString());
            }
            else

            {
                Console.WriteLine("Não existe esta opção!");

            }
        }

    }
}
