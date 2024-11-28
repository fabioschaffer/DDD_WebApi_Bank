using Entity.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Configuration;

public class AppDbContext : DbContext {

    public DbSet<Person> Person { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options) {
        options.UseSqlServer("Server=localhost,1433;Database=Bank;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;");
        base.OnConfiguring(options);
    }
}