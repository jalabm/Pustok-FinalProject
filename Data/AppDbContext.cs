﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pustok.Models;

namespace Pustok.Data;

public class AppDbContext : IdentityDbContext<AppUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
   
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Product>().HasQueryFilter(x => !x.SoftDelete);
    }

    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<ProductImg> ProductImgs { get; set; } = null!;
    public DbSet<Service> Services { get; set; } = null!;
    public DbSet<Slider> Sliders { get; set; } = null!;
    public DbSet<Tag> Tags { get; set; } = null!;
    public DbSet<Brand> Brands { get; set; } = null!;
    public DbSet<BasketItem> BasketItems { get; set; } = null!;
    public DbSet<ProductTag> ProductTags { get; set; } = null!;

    public DbSet<Author> Authors { get; set; } = null!;
    public DbSet<Setting> Settings { get; set; } = null!;

}

