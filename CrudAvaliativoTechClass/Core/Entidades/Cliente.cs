﻿using System;

namespace CrudAvaliativoTechClass.Core.Entidades
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
    }
}