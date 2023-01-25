using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppImageDbToFolder.Models;

namespace WinFormsAppImageDbToFolder.AppContext;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Product { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<Brand> Brand { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=##########;Initial Catalog=##########;User ID=##########;Password=##########; MultipleActiveResultSets=True;");
}
