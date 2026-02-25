using Microsoft.EntityFrameworkCore;
using Smurfs.SmurfsBL.entities;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace SmurfsGame.Data
{
    public class SmurfsDbContext : DbContext
    {
        public DbSet<Forest> Forests { get; set; }
        public DbSet<Creature> Creatures { get; set; }
        public DbSet<Schtroumpf> Schtroumpfs { get; set; }
        public DbSet<Spider> Spiders { get; set; }
        public DbSet<BzzFly> BzzFlies { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<RedPotion> RedPotions { get; set; }
        public DbSet<BluePotion> BluePotions { get; set; }
        public DbSet<Berry> Berries { get; set; }

        public SmurfsDbContext()
        {
        }

        public SmurfsDbContext(DbContextOptions<SmurfsDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=(localdb)\mssqllocaldb;Database=SmurfsGameDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TPH pour Creature
            modelBuilder.Entity<Creature>()
                .HasDiscriminator<string>("CreatureType")
                .HasValue<Schtroumpf>("Schtroumpf")
                .HasValue<Spider>("Spider")
                .HasValue<BzzFly>("BzzFly");

            // TPH pour Item
            modelBuilder.Entity<Item>()
                .HasDiscriminator<string>("ItemType")
                .HasValue<RedPotion>("RedPotion")
                .HasValue<BluePotion>("BluePotion")
                .HasValue<Berry>("Berry");

            // Relation Forest → Creatures / Items
            modelBuilder.Entity<Forest>()
                .HasMany(f => f.Creatures)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Forest>()
                .HasMany(f => f.Items)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}