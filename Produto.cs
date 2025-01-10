using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    internal class Produto
    {
     public string Nome;
     public string Categoria;
     public decimal Preco;
     public int Quantidade;

     public Produto(){
       Nome = "Produto desconhecido";
       Categoria = "Sem categoria";
       Preco = 0.0m;
       Quantidade = 0;

     }
     public Produto(string nome,string categoria,decimal preco,int quantidade){
        Nome = nome;
        Categoria = categoria;
        Preco = preco;
        Quantidade = quantidade;

      }

     public Produto(string nome,string categoria){
         Nome = nome;
         Categoria = categoria;
         Preco = 0.0m;
         Quantidade = 0;

      }
     public void ExibirInfo(){
      Console.WriteLine($"Nome: {Nome}");
      Console.WriteLine($"Categoria: {Categoria}");
      Console.WriteLine($"Preco: {Preco.ToString("F2",CultureInfo.InvariantCulture)}");
      Console.WriteLine($"Quantidade: {Quantidade}");
     }
     public void AlterarPreco(decimal preco){
      Preco = preco;
      Console.WriteLine($"Novo Preço atualizado de {Preco}");
            
     } 
     public void AdicionarEstoque(int quantidade){
     Quantidade += quantidade;
            Console.WriteLine($"{quantidade} unidades adicionadas ao estoque. total em estoque {Quantidade}");
        
        
      }







    }
}
