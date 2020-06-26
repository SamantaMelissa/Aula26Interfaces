namespace Aula26Interfaces
{
    public class Produto
    {
    

        public int Codigo { get; set; }

       public string Nome { get; set; }

       public float Preco { get; set; }
       
       public Produto(){

       }
        public Produto(string _nome, int _codigo, float _preco){

            this.Nome = _nome;
            this.Codigo = _codigo;
            this.Preco = _preco;
        }
    }
}