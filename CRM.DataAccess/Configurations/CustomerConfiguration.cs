using CRM.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.DataAccess.Configurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name).HasColumnName("Name");
         
        builder.HasData(new Customer[]
        {
            new() { Id=1, Name="Customer1"},
            new() { Id=2, Name="Customer2"},
        });
    }
}
