using ConsoleApp35;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Produto produto1 = new Produto();
            produto1.ExibirInfo();

         Console.WriteLine();
         Produto produto2 = new Produto("TV 65 Polegadas OLED", "Eletrônico", 2500.00m, 10);
         produto2.ExibirInfo();

         Console.WriteLine();
        Produto produto3 = new Produto("Smartphone Iphone Pro", "Eletrônico");
          produto3.ExibirInfo();

         Console.WriteLine();
         produto3.AlterarPreco(800.09m);
         Console.WriteLine();
         produto3.ExibirInfo();

         Console.WriteLine();
         produto3.AdicionarEstoque(8);
         Console.WriteLine();
         produto3.ExibirInfo();

         Console.WriteLine();
         produto3.AdicionarEstoque(3);
         Console.WriteLine();
         produto3.ExibirInfo();

         Console.WriteLine();
         produto3.AdicionarEstoque(4);
         Console.WriteLine();
         produto3.ExibirInfo();


        }
    }
}