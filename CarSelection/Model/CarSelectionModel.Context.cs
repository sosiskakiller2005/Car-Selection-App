﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarSelection.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CarSelectionEntities : DbContext
    {
        public CarSelectionEntities()
            : base("name=CarSelectionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Advertisement> Advertisement { get; set; }
        public virtual DbSet<Body> Body { get; set; }
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Colour> Colour { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<DealerShip> DealerShip { get; set; }
        public virtual DbSet<Drive> Drive { get; set; }
        public virtual DbSet<Engine> Engine { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<Transmission> Transmission { get; set; }
        public virtual DbSet<TypeOfFuel> TypeOfFuel { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Favourites> Favourites { get; set; }
    }
}
