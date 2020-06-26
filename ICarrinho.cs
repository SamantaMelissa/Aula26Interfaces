namespace Aula26Interfaces
{
    public interface ICarrinho
    {   //REGULAMENTAR COM A REGRA DE NEGÓCIOS DO SISTEMA
        //CRUD --> Create, Read, Update, Delete

        void Ler();

        void Adicionar(Produto _produto);

        void Remover(Produto _produto);

        void Alterar(int _codigo, Produto _produtoAlterado);
   
       // void MostrarTotal();
   
    }
}