﻿using Bootcamp.EntityLayer.Concrete;
using System.Data.Entity;


namespace Bootcamp.DataAccessLayer.Context
{
    public class BootcampContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
