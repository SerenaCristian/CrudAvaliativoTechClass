namespace CrudAvaliativoTechClass.Core.Entidades
{
    public class Camiseta
    {
        public int Id { get; set; }                
        public string Nome { get; set; }           
        public string Tamanho { get; set; }        
        public string Cor { get; set; }            
        public double Preco { get; set; }         
            

        
        public Camiseta(int id, string nome, string tamanho, string cor, double preco)
        {
            Id = id;
            Nome = nome;
            Tamanho = tamanho;
            Cor = cor;
            Preco = preco;
            
        }
    }
}
