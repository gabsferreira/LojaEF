using LojaEF.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaEF
{
    class Program
    {
        static void Main(string[] args)
        {
            var contexto = new EntidadesContext();
            Produto produto = new Produto()
            {
                Nome = "Impressora",
                Preco = 100.0m
            };
            contexto.Produtos.Add(produto);
            contexto.SaveChanges();
        }
    }
}
