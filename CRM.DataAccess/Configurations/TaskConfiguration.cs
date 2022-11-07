using CRM.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.DataAccess.Configurations;

public class TaskConfiguration : IEntityTypeConfiguration<Tasks>
{
    public void Configure(EntityTypeBuilder<Tasks> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name).HasColumnName("Name"); 

        builder.HasData(new Tasks[]
        {
            new() { Id=1, Name="Task1"},
            new() { Id=2, Name="Task2"},
        });
    }
}
