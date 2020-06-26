using System;

namespace Aula26Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinhO = new Carrinho();
            //Criamos alhuns produtos
            Produto p1 = new Produto( "Livro Angustia - Graciliano Ramos",01, 45.90f);
            Produto p2 = new Produto("Livro A culpa é das estrelas - John Green",02, 38.9f);
            Produto p3 = new Produto( "Black Bird - Anna Carey",03, 29.90f);
            Produto p4 = new Produto( "Livro Serial Killers - Ilana Casoy",04, 69.90f);
            Produto p5 = new Produto( "Livro O Alienista - Machado de Assis",05, 29.90f);
            Produto p6 = new Produto( "Psicopatas do cotidiano - Katia Mecler",06, 29.90f);


            //Adicionamos eles ao carrinho
            carrinhO.Adicionar(p1);
            carrinhO.Adicionar(p2);
            carrinhO.Adicionar(p3);
            carrinhO.Adicionar(p4);
            carrinhO.Adicionar(p5);
            carrinhO.Adicionar(p6);

            
            
            
            carrinhO.Remover(p2);
    
          
            //Mostramos nosso carrinho completo:

            carrinhO.Ler();
            carrinhO.MostrarTotal();


        }
    }
}
