using Microsoft.EntityFrameworkCore;
using System;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options): base(options)
    {

    }

    public DbSet<Post> Posts { get; set; }
}
