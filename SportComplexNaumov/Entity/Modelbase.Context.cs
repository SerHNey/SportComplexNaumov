﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportComplexNaumov.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntitiesSportComplex : DbContext
    {
        public EntitiesSportComplex()
            : base("name=EntitiesSportComplex")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cekcia> Cekcia { get; set; }
        public virtual DbSet<Instryctor> Instryctor { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Abonement> Abonement { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Trenirovki> Trenirovki { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
