using Datastore.Modules.Deployment.Domain.Aggregates.Customer;
using Datastore.Modules.Deployment.Domain.Aggregates.Site;
using Microsoft.EntityFrameworkCore;

namespace Datastore.Modules.Deployment.Presentation;

public class DeploymentDbContext(DbContextOptions<DeploymentDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DeploymentDbContext).Assembly,
            x => x.Namespace == "NDatastore.Modules.Deployment.Infrastructure.DbConfigurations");
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Site> Sites { get; set; }
    public DbSet<Field> Fields { get; set; }
    public DbSet<CropRow> CropRows { get; set; }
}