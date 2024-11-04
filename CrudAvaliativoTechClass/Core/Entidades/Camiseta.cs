namespace CrudAvaliativoTechClass.Core.Entidades
{
    internal class Camiseta : BaseCamiseta
    {
        public Camiseta(string nome, string tamanho, string cor, double preco)
        {
            Nome = nome;
            Tamanho = tamanho;
            Cor = cor;
            Preco = preco;
        }

        public string Nome { get; set; }           
        public string Tamanho { get; set; }        
        public string Cor { get; set; }            
        public double Preco { get; set; }         
            

        
      
    }
}
