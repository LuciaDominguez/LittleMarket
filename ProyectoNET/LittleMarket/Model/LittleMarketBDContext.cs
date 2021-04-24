using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace LittleMarket.Model
{
    public class LittleMarketBDContext : DbContext
    {

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Ciudad> Ciudad { get; set; }
        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Direccion> Direccion { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Imagen> Imagen { get; set; }
        public DbSet<LikeProducto> LikeProducto { get; set; }
        public DbSet<Multimedia> Multimedia { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Video> Video { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pais>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsRequired();//Es not null

            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id_Pais)

                .IsRequired();//Es not null

                entity.Property(e => e.Nombre)
              .HasMaxLength(50)
              .IsUnicode(false)
              .IsRequired();//Es not null

                entity.HasOne(e => e.Pais) // estos son los virtua lpublic de  public virtual Student Student { get; set; }
                  .WithMany(y => y.Estado) // este es el Icoleccion DE LA CLASE que se conecta que es en Student   public virtual ICollection<StudentSchoolSubject> StudentSchoolSubject { get; set; }
                  .HasForeignKey(x => x.Id_Pais);


            });

            modelBuilder.Entity<Ciudad>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id_Estado)
                .IsRequired();//Es not null

                entity.Property(e => e.Nombre)
              .HasMaxLength(50)
              .IsUnicode(false)
              .IsRequired();//Es not null

                entity.HasOne(e => e.Estado) // estos son los virtua lpublic de  public virtual Student Student { get; set; }
                  .WithMany(y => y.Ciudad) // este es el Icoleccion DE LA CLASE que se conecta que es en Student   public virtual ICollection<StudentSchoolSubject> StudentSchoolSubject { get; set; }
                  .HasForeignKey(x => x.Id_Estado);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Id);


                entity.Property(e => e.Nombre)
              .HasMaxLength(50)
              .IsUnicode(false)
              .IsRequired();//Es not null

                entity.Property(e => e.ApellidoPaterno)
              .HasMaxLength(50)
              .IsUnicode(false)
              .IsRequired();//Es not null

                entity.Property(e => e.ApellidoMaterno)
              .HasMaxLength(50)
              .IsUnicode(false)
              .IsRequired();//Es not null

                entity.Property(e => e.Correo)
          .HasMaxLength(50)
          .IsUnicode(false)
          .IsRequired();//Es not null

                entity.Property(e => e.Contra)
          .HasMaxLength(50)
          .IsUnicode(false)
          .IsRequired();//Es not null

                entity.Property(e => e.Id_Pais)
               .IsRequired();//Es not null
                entity.Property(e => e.Id_Estado)
               .IsRequired();//Es not null
                entity.Property(e => e.Id_Ciudad)
               .IsRequired();//Es not null

                entity.Property(e => e.Id_Ciudad)
              .IsRequired();

                entity.Property(e => e.Activo)
              .HasColumnType("bit")
               .IsRequired();

                entity.Property(e => e.UltimaConexion)
              .HasColumnType("DATE")
               .IsRequired();

                entity.Property(e => e.Telefono)
        .HasMaxLength(13)
        .IsRequired();

                entity.Property(e => e.FechaDeRegistro)
            .HasColumnType("DATE")
             .IsRequired();

                entity.Property(e => e.FechaDeNacimiento)
            .HasColumnType("DATE")
             .IsRequired();

                entity.Property(e => e.Id_MetodoDePago)
             .IsRequired();

                entity.HasOne(e => e.Estado) // estos son los virtua lpublic de  public virtual Student Student { get; set; }
                  .WithMany(y => y.Usuario) // este es el Icoleccion DE LA CLASE que se conecta que es en Student   public virtual ICollection<StudentSchoolSubject> StudentSchoolSubject { get; set; }
                  .HasForeignKey(x => x.Id_Estado);

                entity.HasOne(e => e.Ciudad) // estos son los virtua lpublic de  public virtual Student Student { get; set; }
                .WithMany(y => y.Usuario) // este es el Icoleccion DE LA CLASE que se conecta que es en Student   public virtual ICollection<StudentSchoolSubject> StudentSchoolSubject { get; set; }
                .HasForeignKey(x => x.Id_Ciudad);


                entity.HasOne(e => e.Pais) // estos son los virtua lpublic de  public virtual Student Student { get; set; }
                .WithMany(y => y.Usuario) // este es el Icoleccion DE LA CLASE que se conecta que es en Student   public virtual ICollection<StudentSchoolSubject> StudentSchoolSubject { get; set; }
                .HasForeignKey(x => x.Id_Pais);
            });

            modelBuilder.Entity<Direccion>(entity =>
            {
                entity.HasKey(e => e.Id);


                entity.Property(e => e.Id_Usuario)
              .IsRequired();

                entity.Property(e => e.Id_Ciudad)
            .IsRequired();


                entity.Property(e => e.Calle)
              .HasMaxLength(50)
              .IsUnicode(false)
              .IsRequired();//Es not null

                entity.Property(e => e.Numero)
              .HasMaxLength(50)
              .IsUnicode(false)
              .IsRequired();//Es not null

                entity.Property(e => e.CodigoPostal)
          .HasMaxLength(6)
          .IsUnicode(false)
          .IsRequired();//Es not null
                entity.Property(e => e.Departamento)
          .HasMaxLength(50)
          .IsUnicode(false)
          .IsRequired();//Es not null

                entity.HasOne(e => e.Usuario)
                .WithMany(y => y.Direccion)
                  .HasForeignKey(x => x.Id_Usuario);

                entity.HasOne(e => e.Ciudad)
                .WithMany(y => y.Direccion)
                .HasForeignKey(x => x.Id_Ciudad);

            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.Id);


                entity.Property(e => e.Nombre).
                HasMaxLength(50).
                IsUnicode(false)
              .IsRequired();


                entity.Property(e => e.Descripcion).
                IsUnicode(false)
              .IsRequired();

            });

            modelBuilder.Entity<Imagen>(entity =>
            {
                entity.HasKey(e => e.Id);


                entity.Property(e => e.Foto).
            HasColumnType("varbinary(max)")
              .IsRequired();

            });

            modelBuilder.Entity<Video>(entity =>
            {
                entity.HasKey(e => e.Id);


                entity.Property(e => e.LinkVideo).
              IsRequired();

            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.Id);


                entity.Property(e => e.Precio)
              .IsRequired();
               
                entity.Property(e => e.CantidadAlmacen)
              .IsRequired();

                entity.Property(e => e.Descripcion)
                .IsUnicode(false)
              .IsRequired();

                entity.Property(e => e.FechaDePublicacion)
                .HasColumnType("Date")
              .IsRequired();
                entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
              .IsRequired();

                entity.Property(e => e.Activo)
                .HasColumnType("bit")
              .IsRequired();

                entity.Property(e => e.Id_Categoria)
              .IsRequired();

                entity.HasOne(e => e.Categoria) // estos son los virtua lpublic de  public virtual Student Student { get; set; }
              .WithMany(y => y.Producto) // este es el Icoleccion DE LA CLASE que se conecta que es en Student   public virtual ICollection<StudentSchoolSubject> StudentSchoolSubject { get; set; }
              .HasForeignKey(x => x.Id_Categoria);

            });

            modelBuilder.Entity<Multimedia>(entity =>
            {
                entity.HasKey(e => e.Id);


                entity.Property(e => e.Id_Producto).
              IsRequired();

                entity.Property(e => e.Tipo).
                HasColumnType("bit").
             IsRequired();

                entity.Property(e => e.Id_Imagen).
             IsRequired();

                entity.Property(e => e.Id_Video).
             IsRequired();

                entity.HasOne(e => e.Producto)
              .WithMany(y => y.Multimedia)
              .HasForeignKey("FK_MultimediaProducto_Producto");

                entity.HasOne(e => e.Imagen)
              .WithMany(y => y.Multimedia)
              .HasForeignKey("FK_MultimediaImagen_Imagen");

                entity.HasOne(e => e.Video)
              .WithMany(y => y.Multimedia)
              .HasForeignKey("FK_MultimediaVideo_Video");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id_Usuario).
             IsRequired();

                entity.Property(e => e.Id_Producto).
              IsRequired();

             
                entity.Property(e => e.Id_Direccion).
             IsRequired();

                entity.Property(e => e.Cantidad).
               IsRequired();

                entity.Property(e => e.TotalAPagar).
               IsRequired();

                entity.Property(e => e.FechaDePedido).
                HasColumnType("date").
                 IsRequired();

                entity.Property(e => e.FechaDePedido).
               HasColumnType("date").
            IsRequired();

                entity.Property(e => e.PedidoRecibido).
                HasColumnType("bit").
              IsRequired();

                entity.Property(e => e.Comentarios).
               IsRequired();

                entity.HasOne(e => e.Usuario)
              .WithMany(y => y.Pedido)
              .HasForeignKey(x => x.Id_Usuario);

                entity.HasOne(e => e.Producto)
              .WithMany(y => y.Pedido)
              .HasForeignKey(x => x.Id_Producto);

                entity.HasOne(e => e.Direccion)
              .WithMany(y => y.Pedido)
              .HasForeignKey(x => x.Id_Direccion);
            });

            modelBuilder.Entity<Comentario>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.TextoComentario).
                IsUnicode(false).
            IsRequired();

                entity.Property(e => e.Id_Usuario).
             IsRequired();

                entity.Property(e => e.Id_Producto).
              IsRequired();


                entity.Property(e => e.Activo)
              .HasColumnType("bit")
               .IsRequired();

                entity.Property(e => e.FechaDePublicacion)
              .HasColumnType("DATE")
               .IsRequired();

             

                entity.HasOne(e => e.Usuario)
              .WithMany(y => y.Comentario)
              .HasForeignKey("FK_ComentarioUsuario_Usuario");

                entity.HasOne(e => e.Producto)
              .WithMany(y => y.Comentario)
              .HasForeignKey("FK_ComentarioProducto_Producto");

               
            });

            modelBuilder.Entity<LikeProducto>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Like).
                HasColumnType("bit").
                IsRequired();

                entity.Property(e => e.Id_Usuario).
             IsRequired();

                entity.Property(e => e.Id_Producto).
              IsRequired();

                entity.HasOne(e => e.Usuario)
              .WithMany(y => y.LikeProducto)
              .HasForeignKey("FK_LikeProductoUsuario_Usuario");

                entity.HasOne(e => e.Producto)
              .WithMany(y => y.LikeProducto)
              .HasForeignKey("FK_LikeProductoProducto_Producto");


            });


        }

        internal void Add(Pais pais)
        {
            throw new NotImplementedException();
        }

        internal void Add(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public LittleMarketBDContext(DbContextOptions<LittleMarketBDContext> options)
        : base(options)
        {

        }


    }
}
