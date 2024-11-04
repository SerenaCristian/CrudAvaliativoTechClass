namespace CrudAvaliativoTechClass.Core.Entidades
{
    internal class EnderecoCliente : BaseEnderecoCliente
    {
        public string Endereco { get; set; }
        public int Numero { get; set; }

        public EnderecoCliente(string endereco, int numero)
        {
            Endereco = endereco;
            Numero = numero;
        }
    }
}
