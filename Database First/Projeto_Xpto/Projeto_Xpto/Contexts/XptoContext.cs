using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Projeto_Xpto.Domains;

#nullable disable

namespace Projeto_Xpto.Contexts
{
    public partial class XptoContext : DbContext
    {
        public XptoContext()
        {
        }

        public XptoContext(DbContextOptions<XptoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Anuncio> Anuncios { get; set; }
        public virtual DbSet<Interesse> Interesses { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-AGDJFBQ9\\SQLEXPRESS; Initial Catalog=Projeto_Xpto; Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Anuncio>(entity =>
            {
                entity.HasKey(e => e.IdAnuncio)
                    .HasName("PK__anuncio__0BC1EC3E6FBCDFB4");

                entity.ToTable("anuncio");

                entity.Property(e => e.IdAnuncio).HasColumnName("idAnuncio");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Imagem)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("imagem");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Preco).HasColumnName("preco");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Anuncios)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__anuncio__idUsuar__2B3F6F97");
            });

            modelBuilder.Entity<Interesse>(entity =>
            {
                entity.HasKey(e => e.IdInteresse)
                    .HasName("PK__interess__EC19CAE5D0F36670");

                entity.ToTable("interesse");

                entity.Property(e => e.IdInteresse).HasColumnName("idInteresse");

                entity.Property(e => e.IdAnuncio).HasColumnName("idAnuncio");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.HasOne(d => d.IdAnuncioNavigation)
                    .WithMany(p => p.Interesses)
                    .HasForeignKey(d => d.IdAnuncio)
                    .HasConstraintName("FK__interesse__idAnu__2F10007B");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Interesses)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__interesse__idUsu__2E1BDC42");
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK__tipoUsua__03006BFF51FB1F11");

                entity.ToTable("tipoUsuario");

                entity.HasIndex(e => e.Titulo, "UQ__tipoUsua__38FA640F2827F2C7")
                    .IsUnique();

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("titulo");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__usuario__645723A64C068A95");

                entity.ToTable("usuario");

                entity.HasIndex(e => e.Email, "UQ__usuario__AB6E61643F8BB2C0")
                    .IsUnique();

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cidade");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.Imagem)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("imagem");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("senha");

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("telefone");

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK__usuario__idTipoU__286302EC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
