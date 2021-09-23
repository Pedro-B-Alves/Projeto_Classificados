using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XPTO.Domains;

namespace XPTO.Contexts
{
    public class XPTOContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Anuncio> Anuncio { get; set; }
        public DbSet<Interesse> Interesse { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=XPTO; Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define as entidades já com dados
            modelBuilder.Entity<TipoUsuario>().HasData(
                new TipoUsuario
                {
                    idTipoUsuario = 1,
                    titulo = "Administrador"
                },
                new TipoUsuario
                {
                    idTipoUsuario = 2,
                    titulo = "Cliente"
                });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasData(
                    new Usuario
                    {
                        idUsuario = 1,
                        email = "admin@admin.com",
                        senha = "admin1234",
                        nome = "admin",
                        telefone = 11912345678,
                        imagem = "",
                        cidade = "São Paulo",
                        estado = "São Paulo",
                        idTipoUsuario = 1
                    },
                    new Usuario
                    {
                        idUsuario = 2,
                        email = "cliente@cliente.com",
                        senha = "cliente1234",
                        nome = "cliente",
                        telefone = 11912345678,
                        imagem = "",
                        cidade = "São Paulo",
                        estado = "São Paulo",
                        idTipoUsuario = 2
                    });

                entity.HasIndex(u => u.email).IsUnique();
            });

            modelBuilder.Entity<Anuncio>(entity =>
            {
                entity.HasData(
                    new Anuncio
                    { idAnuncio = 1, nome = "playstation 2", descricao = "Em boa condição", imagem = "", preco = 500.00, idUsuario = 1 }
                    
                );

            });


            modelBuilder.Entity<Interesse>().HasData(
                new Interesse
                {
                    idInteresse = 1,
                    idUsuario = 2,
                    idAnuncio = 1
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
