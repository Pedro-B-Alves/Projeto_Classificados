using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
using ProjetoClassificados.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClassificados.Infra.Data.Contexts
{
    public class ProjetoClassificadosContext : DbContext
    {
        public ProjetoClassificadosContext(DbContextOptions<ProjetoClassificadosContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Anuncio> Anuncios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Notification>();

            #region Mapeamento de tabela de Usuários

            modelBuilder.Entity<Usuario>().ToTable("Usuarios");

            modelBuilder.Entity<Usuario>().Property(x => x.Id);

            modelBuilder.Entity<Usuario>().Property(x => x.Email).HasMaxLength(40);
            modelBuilder.Entity<Usuario>().Property(x => x.Email).HasColumnType("varchar(40)");
            modelBuilder.Entity<Usuario>().Property(x => x.Email).IsRequired();

            modelBuilder.Entity<Usuario>().Property(x => x.Senha).HasMaxLength(30);
            modelBuilder.Entity<Usuario>().Property(x => x.Senha).HasColumnType("varchar(30)");
            modelBuilder.Entity<Usuario>().Property(x => x.Senha).IsRequired();

            modelBuilder.Entity<Usuario>().Property(x => x.Nome).HasMaxLength(40);
            modelBuilder.Entity<Usuario>().Property(x => x.Nome).HasColumnType("varchar(40)");
            modelBuilder.Entity<Usuario>().Property(x => x.Nome).IsRequired();

            modelBuilder.Entity<Usuario>().Property(x => x.Telefone).HasMaxLength(11);
            modelBuilder.Entity<Usuario>().Property(x => x.Telefone).HasColumnType("bigint");
            modelBuilder.Entity<Usuario>().Property(x => x.Telefone).IsRequired();

            modelBuilder.Entity<Usuario>().Property(x => x.Image).HasMaxLength(255);
            modelBuilder.Entity<Usuario>().Property(x => x.Image).HasColumnType("varchar(255)");

            modelBuilder.Entity<Usuario>().Property(x => x.Cidade).HasMaxLength(50);
            modelBuilder.Entity<Usuario>().Property(x => x.Cidade).HasColumnType("varchar(50)");
            modelBuilder.Entity<Usuario>().Property(x => x.Cidade).IsRequired();

            modelBuilder.Entity<Usuario>().Property(x => x.Estado).HasMaxLength(50);
            modelBuilder.Entity<Usuario>().Property(x => x.Estado).HasColumnType("varchar(50)");
            modelBuilder.Entity<Usuario>().Property(x => x.Estado).IsRequired();

            modelBuilder.Entity<Usuario>().Property(x => x.DataCriacao).HasColumnType("DateTime");

            #endregion

            #region Mapeamento de tabela de Anuncios

            // Muda o nome da tabela para o plural
            modelBuilder.Entity<Anuncio>().ToTable("Anuncios");

            // Id - Como está como Id, ele automaticamente indentificará que é chave primária
            modelBuilder.Entity<Anuncio>().Property(x => x.Id);

            // Nome
            modelBuilder.Entity<Anuncio>().Property(x => x.Nome).HasMaxLength(50);
            modelBuilder.Entity<Anuncio>().Property(x => x.Nome).HasColumnType("varchar(50)");
            modelBuilder.Entity<Anuncio>().Property(x => x.Nome).IsRequired();

            // Descrição
            modelBuilder.Entity<Anuncio>().Property(x => x.Descricao).HasMaxLength(200);
            modelBuilder.Entity<Anuncio>().Property(x => x.Descricao).HasColumnType("varchar(200)");
            modelBuilder.Entity<Anuncio>().Property(x => x.Descricao).IsRequired();

            // Imagem
            modelBuilder.Entity<Anuncio>().Property(x => x.Imagem).HasMaxLength(200);
            modelBuilder.Entity<Anuncio>().Property(x => x.Imagem).HasColumnType("varchar(200)");

            // Preço
            modelBuilder.Entity<Anuncio>().Property(x => x.Preco).HasMaxLength(24);
            modelBuilder.Entity<Anuncio>().Property(x => x.Preco).HasColumnType("float(24)");
            modelBuilder.Entity<Anuncio>().Property(x => x.Preco).IsRequired();

            // DataCriação
            modelBuilder.Entity<Anuncio>().Property(x => x.DataCriacao).HasColumnType("DateTime");

            // configurando relacionamento
            //modelBuilder.Entity<Anuncio>()
                //.HasMany(a => a.Anuncio)
                //.WithOne(u => u.Usuario)
                //.HasForeignKey ?

            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
