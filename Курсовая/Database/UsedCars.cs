using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Курсовая.Database
{
    public partial class UsedCars : DbContext
    {
        public UsedCars()
            : base("name=UsedCars")
        {
        }

        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Carcase> Carcase { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<Dealer> Dealer { get; set; }
        public virtual DbSet<Model> Model { get; set; }
        public virtual DbSet<Photo_car> Photo_car { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>()
                .Property(e => e.name_brand)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Car>()
                .Property(e => e.color)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.type_engine)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.fuel_type)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.availability)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.model_name)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.engine_capacity)
                .HasPrecision(2, 1);

            modelBuilder.Entity<Car>()
                .HasOptional(e => e.State)
                .WithRequired(e => e.Car)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Carcase>()
                .Property(e => e.type_carcase)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.name_client)
                .IsUnicode(false);

            modelBuilder.Entity<Contract>()
                .Property(e => e.actual_price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Dealer>()
                .Property(e => e.name_dealer)
                .IsUnicode(false);

            modelBuilder.Entity<Dealer>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<Dealer>()
                .Property(e => e.telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Model>()
                .Property(e => e.model_name)
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .Property(e => e.state_description)
                .IsUnicode(false);
        }
    }
}
