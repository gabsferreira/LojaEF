﻿using LojaEF.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaEF
{
    public class EntidadesContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var usuarioBuilder = modelBuilder.Entity<Usuario>();
            usuarioBuilder.ToTable("tbl_Usuarios");
            usuarioBuilder.Property(usuario => usuario.Nome)
                          .HasColumnName("col_nome");
        }
    }
}
