using CrudAvaliativoTechClass.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudAvaliativoTechClass.Infra.Repositorios
{
    internal class CamisetaRepositorio
    {
        private static List<Camiseta> camisetas = new List<Camiseta>();
        private static int id = 0;

        public void AdicionarCamiseta(Camiseta camiseta)
        {
            
            var camisetaExistente = camisetas.FirstOrDefault(x => x.Nome == camiseta.Nome && x.Tamanho == camiseta.Tamanho);
            if (camisetaExistente != null)
            {
                Console.WriteLine("Camiseta já cadastrada.");
                return;
            }

            camiseta.Id = id++;
            camisetas.Add(camiseta);
        }

        public void Atualizar(Camiseta camiseta)
        {
            var atualizarCamiseta = camisetas.FirstOrDefault(x => x.Id == camiseta.Id);

            if (atualizarCamiseta != null)
            {
                atualizarCamiseta.Nome = camiseta.Nome;
                atualizarCamiseta.Tamanho = camiseta.Tamanho;
                atualizarCamiseta.Cor = camiseta.Cor;
                atualizarCamiseta.Preco = camiseta.Preco;
            }
            else
            {
                Console.WriteLine("Camiseta não encontrada para atualização.");
            }
        }

        public void DeleteFisico(Camiseta camiseta)
        {
            camisetas.Remove(camiseta);
        }

        public List<Camiseta> GetCamisetas()
        {
            return camisetas;
        }
    }
}
