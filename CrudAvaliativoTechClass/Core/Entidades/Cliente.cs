using System;

namespace CrudAvaliativoTechClass.Core.Entidades
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }


        public Cliente(int id, string nome, DateTime nascimento, string email, int telefone)
        {   
            Id = id; 
            Nome = nome;
            DataNascimento = nascimento;
            Email = email;  
            Telefone = telefone;

        }
    }
}
