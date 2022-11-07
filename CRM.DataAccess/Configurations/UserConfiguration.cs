using CRM.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.DataAccess.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name).HasColumnName("Name");

        builder.HasData(new User[]
        {
            new() { Id=1, Name="Username1"}, 
            new() { Id=2, Name="Username2"}, 
        });
    }
}