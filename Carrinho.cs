using System;
using System.Collections.Generic;

namespace Aula26Interfaces
{
    public class Carrinho : ICarrinho
    {
        List<Produto> carrinho = new List<Produto>();

        public float ValorTotal { get; set; }

       public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Alterar(int _codigo, Produto _produtoAlterado)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = _produtoAlterado.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _produtoAlterado.Preco;
        }

        public void Ler()
        {
            foreach(Produto p in carrinho){
                System.Console.WriteLine($"R${p.Preco,2} - {p.Nome}");
            }
        }

        public void Remover(Produto _produto)
        {
           carrinho.Remove(_produto);
        }
    
        public void NovoMetodo(){

        }

       public void MostrarTotal()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
                foreach(Produto item in carrinho){
                    ValorTotal += item.Preco;
                }
            Console.WriteLine($"Total do carrinho: ${ValorTotal.ToString("n2")}");
            
            Console.ResetColor();
        }
    }
}