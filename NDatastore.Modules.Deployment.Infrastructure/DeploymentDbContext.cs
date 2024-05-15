using Datastore.Common.Infrastructure;
using Datastore.Modules.Deployment.Domain.Entities.Customer;
using Datastore.Modules.Deployment.Domain.Entities.Site;
using Microsoft.EntityFrameworkCore;

namespace Datastore.Modules.Deployment.Presentation;

public class DeploymentDbContext(DbContextOptions<DeploymentDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema(Schema.Deployment);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DeploymentDbContext).Assembly,
            x => x.Namespace == "NDatastore.Modules.Deployment.Infrastructure.DbConfigurations");
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Site> Sites { get; set; }
    public DbSet<Field> Fields { get; set; }
    public DbSet<CropRow> CropRows { get; set; }
}