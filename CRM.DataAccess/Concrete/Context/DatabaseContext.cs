using CRM.DataAccess.Configurations;
using CRM.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CRM.DataAccess.Concrete;
public class DatabaseContext : DbContext
{
    private readonly IConfiguration _configuration;
    public DatabaseContext(DbContextOptions<DatabaseContext> options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }
      
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

     
        modelBuilder.ApplyConfiguration(new RateConfiguration());
        modelBuilder.ApplyConfiguration(new RateQNConfiguration());

        modelBuilder.ApplyConfiguration(new TranslationConfiguration());

        modelBuilder.ApplyConfiguration(new RateResultConfiguration());
        modelBuilder.ApplyConfiguration(new RateResultDetailConfiguration());
         
    }


    public DbSet<Rate> Rates { get; set; }
    public DbSet<RateQN> RateQNs { get; set; }
    public DbSet<Translation> Translations { get; set; }
    public DbSet<RateResult> RateResults { get; set; }
    public DbSet<RateResultDetail> RateResultDetails { get; set; }
     
}

