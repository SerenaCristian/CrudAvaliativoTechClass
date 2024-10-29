using System;

namespace CrudAvaliativoTechClass.Core.Entidades
{
    internal class Cliente : ClienteBase
    {
        
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }


        public Cliente(string nome, DateTime nascimento, string email, int telefone)
        {
            Nome = nome;
            DataNascimento = nascimento;
            Email = email;
            Telefone = telefone;
        }



    }
}
