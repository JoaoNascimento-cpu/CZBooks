using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CZBooks.WebAPI.Domains;

#nullable disable

namespace CZBooks.WebAPI.Contexts
{
    public partial class CZBctx : DbContext
    {
        public CZBctx()
        {
        }

        public CZBctx(DbContextOptions<CZBctx> options)
            : base(options)
        {
        }

        public virtual DbSet<Autore> Autores { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Instituico> Instituicoes { get; set; }
        public virtual DbSet<Livro> Livros { get; set; }
        public virtual DbSet<TiposUsuario> TiposUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#pragma warning disable CS1030 // diretiva de #aviso
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-II7UP0KL; initial catalog=CZBooks; user Id=sa; pwd=Senai@132;");
#pragma warning restore CS1030 // diretiva de #aviso
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Autore>(entity =>
            {
                entity.HasKey(e => e.IdAutor)
                    .HasName("PK__Autores__9AE8206A8DA4E71B");

                entity.Property(e => e.IdAutor).HasColumnName("idAutor");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.NomeAutor)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("nomeAutor");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Autores)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Autores__idUsuar__42E1EEFE");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__Categori__8A3D240C70445AB1");

                entity.HasIndex(e => e.Categoria1, "UQ__Categori__1179412FE3C47BEC")
                    .IsUnique();

                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.Categoria1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("categoria");
            });

            modelBuilder.Entity<Instituico>(entity =>
            {
                entity.HasKey(e => e.IdInstituicao)
                    .HasName("PK__Institui__8EA7AB00FF40182F");

                entity.Property(e => e.IdInstituicao).HasColumnName("idInstituicao");

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("cnpj");

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("endereco");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<Livro>(entity =>
            {
                entity.HasKey(e => e.IdLivro)
                    .HasName("PK__Livros__63C546D773114A4F");

                entity.HasIndex(e => e.Titulo, "UQ__Livros__38FA640FEA280B0A")
                    .IsUnique();

                entity.Property(e => e.IdLivro).HasColumnName("idLivro");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("categoria");

                entity.Property(e => e.DataPublicacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dataPublicacao");

                entity.Property(e => e.IdAutor).HasColumnName("idAutor");

                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.IdInstituicao).HasColumnName("idInstituicao");

                entity.Property(e => e.NomeAutor)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nomeAutor");

                entity.Property(e => e.Preco)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("preco");

                entity.Property(e => e.Sinopse)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("sinopse");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("titulo");

                entity.HasOne(d => d.IdAutorNavigation)
                    .WithMany(p => p.Livros)
                    .HasForeignKey(d => d.IdAutor)
                    .HasConstraintName("FK__Livros__idAutor__4D5F7D71");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Livros)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK__Livros__idCatego__4B7734FF");

                entity.HasOne(d => d.IdInstituicaoNavigation)
                    .WithMany(p => p.Livros)
                    .HasForeignKey(d => d.IdInstituicao)
                    .HasConstraintName("FK__Livros__idInstit__4C6B5938");
            });

            modelBuilder.Entity<TiposUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK__TiposUsu__03006BFF07AF3D04");

                entity.HasIndex(e => e.TituloTipoUsuario, "UQ__TiposUsu__C6B29FC37EBCD650")
                    .IsUnique();

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.TituloTipoUsuario)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("tituloTipoUsuario");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuarios__645723A66DFC4638");

                entity.HasIndex(e => e.Email, "UQ__Usuarios__AB6E61649992F420")
                    .IsUnique();

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("senha");

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK__Usuarios__idTipo__40058253");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
