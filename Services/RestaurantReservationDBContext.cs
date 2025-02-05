﻿using Microsoft.EntityFrameworkCore;
using RestRes.Models;

namespace RestRes.Services
{
    public class RestaurantReservationDBContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; init; }
        public DbSet<Reservation> Reservations { get; init; }

        public RestaurantReservationDBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Restaurant>();
            modelBuilder.Entity<Reservation>();
        }
    }
}
