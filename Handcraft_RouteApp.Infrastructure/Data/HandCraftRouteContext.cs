//cSpell:disable
using System;    
using Microsoft.EntityFrameworkCore;
using Handcraft_RouteApp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Handcraft_RouteApp.Infrastructure.Data
{
    public partial class HandCraftRouteContext : DbContext
    {
        public HandCraftRouteContext()
        {
        }

        public HandCraftRouteContext(DbContextOptions<HandCraftRouteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Association> Associations { get; set; }
        public virtual DbSet<Commerce> Commerces { get; set; }
        public virtual DbSet<Craft> Crafts { get; set; }
        public virtual DbSet<CraftTour> CraftTours { get; set; }
        public virtual DbSet<Craftman> Craftmen { get; set; }
        public virtual DbSet<FoodTour> FoodTours { get; set; }
        public virtual DbSet<GeoLocation> GeoLocations { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Municipality> Municipalities { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<SocialNetwork> SocialNetworks { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=HandCraftRoute.mssql.somee.com;Initial Catalog=HandCraftRoute;User ID=NatsuDragneel01_SQLLogin_1;Password=x5mxr4jr1n;Persist Security Info=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => e.IdAddress)
                    .HasName("PK_Addreess");

                entity.ToTable("Address");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Number)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCraftmanNavigation)
                    //.WithMany(p => p.Address)
                    //.HasForeignKey(d => d.IdCraftman)
                    .WithOne(p => p.Address)
                    .HasForeignKey<Address>(d => d.IdCraftman)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_Craftman");
            });

            modelBuilder.Entity<Association>(entity =>
            {
                entity.HasKey(e => e.IdAssociation)
                    .HasName("PK__Associat__F3D0E63D61B4FBA6");

                entity.ToTable("Association");

                entity.Property(e => e.IdAssociation).HasColumnName("Id_Association");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCraftmanNavigation)
                    //.WithMany(p => p.Associations)
                    //.HasForeignKey(d => d.IdCraftman)
                    .WithOne(p => p.Association)
                    .HasForeignKey<Association>(d => d.IdCraftman)
                    .HasConstraintName("FK_Association_Craftman");
            });

            modelBuilder.Entity<Commerce>(entity =>
            {
                entity.HasKey(e => e.IdCommerce)
                    .HasName("PK_Id_commerce");

                entity.Property(e => e.IdCommerce).HasColumnName("Id_commerce");

                entity.Property(e => e.NameCommerce)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Name_Commerce");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Craft>(entity =>
            {
                entity.ToTable("Craft");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.NameCraft)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Name_craft");

                entity.HasOne(d => d.MaterialNavigation)
                    .WithMany(p => p.Crafts)
                    .HasForeignKey(d => d.Material)
                    .HasConstraintName("Fk_Material");
            });

            modelBuilder.Entity<CraftTour>(entity =>
            {
                entity.ToTable("CraftTour");

                entity.Property(e => e.DescriptionCTour)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DescriptionC_Tour");

                entity.Property(e => e.MeetingPoint)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NameCTour)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NameC_Tour");

                entity.HasOne(d => d.MatrialCraftNavigation)
                    .WithMany(p => p.CraftTourMatrialCraftNavigations)
                    .HasForeignKey(d => d.MatrialCraft)
                    .HasConstraintName("Fk_MatrialCraft");

                entity.HasOne(d => d.VisitPointOneNavigation)
                    .WithMany(p => p.CraftTourVisitPointOneNavigations)
                    .HasForeignKey(d => d.VisitPointOne)
                    .HasConstraintName("FK_VisitPointOne");

                entity.HasOne(d => d.VisitPointThreeNavigation)
                    .WithMany(p => p.CraftTourVisitPointThreeNavigations)
                    .HasForeignKey(d => d.VisitPointThree)
                    .HasConstraintName("Fk_VisitPointThree");

                entity.HasOne(d => d.VisitPointTwoNavigation)
                    .WithMany(p => p.CraftTourVisitPointTwoNavigations)
                    .HasForeignKey(d => d.VisitPointTwo)
                    .HasConstraintName("FK_VisitPointTwo");
            });

            modelBuilder.Entity<Craftman>(entity =>
            {
                entity.HasKey(e => e.IdCraftman)
                    .HasName("PK_IdCraftman");

                entity.ToTable("Craftman");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Logo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FoodTour>(entity =>
            {
                entity.HasKey(e => e.IdFoodTour)
                    .HasName("PK_IdFoodTour");

                entity.ToTable("FoodTour");

                entity.Property(e => e.IdFoodTour).HasColumnName("Id_FoodTour");

                entity.Property(e => e.DescriptionFTour)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DescriptionF_Tour");

                entity.Property(e => e.FinalPoint)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImageOne)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImageThree)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImageTwo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingPoint)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MenuDescription)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NameFTour)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NameF_Tour");

                entity.HasOne(d => d.NameComerceOneNavigation)
                    .WithMany(p => p.FoodTourNameComerceOneNavigations)
                    .HasForeignKey(d => d.NameComerceOne)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NameComerceOne");

                entity.HasOne(d => d.NameComerceThreeNavigation)
                    .WithMany(p => p.FoodTourNameComerceThreeNavigations)
                    .HasForeignKey(d => d.NameComerceThree)
                    .HasConstraintName("FK_NameComerceThree");

                entity.HasOne(d => d.NameComerceTwoNavigation)
                    .WithMany(p => p.FoodTourNameComerceTwoNavigations)
                    .HasForeignKey(d => d.NameComerceTwo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NameComerceTwo");
            });

            modelBuilder.Entity<GeoLocation>(entity =>
            {
                entity.HasKey(e => e.IdGeoLocation);

                entity.ToTable("GeoLocation");

                entity.Property(e => e.Altitude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.IdLogin);

                entity.ToTable("Login");

                entity.Property(e => e.Password)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.Property(e => e.TypeMaterial)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Type_Material");
            });

            modelBuilder.Entity<Municipality>(entity =>
            {
                entity.HasKey(e => e.IdMunicipality)
                    .HasName("PK__Municipa__1BFD284402297AA5");

                entity.ToTable("Municipality");

                entity.Property(e => e.NameMunicp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Name_Municp");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol);

                entity.ToTable("Rol");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NameRol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Name_Rol");
            });

            modelBuilder.Entity<SocialNetwork>(entity =>
            {
                entity.HasKey(e => e.IdSocialNetworks);

                entity.ToTable("Social_Networks");

                entity.Property(e => e.IdSocialNetworks).HasColumnName("Id_SocialNetworks");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCraftmanNavigation)
                    //.WithMany(p => p.SocialNetworks)
                    //.HasForeignKey(d => d.IdCraftman)
                    .WithOne(p => p.SocialNetwork)
                    .HasForeignKey<SocialNetwork>( d => d.IdCraftman)
                    .HasConstraintName("FK_Social_Networks_Craftman");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.RolNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Rol)
                    .HasConstraintName("FK_Users_Rol");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
