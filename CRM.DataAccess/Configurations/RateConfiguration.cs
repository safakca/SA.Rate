using CRM.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.DataAccess.Configurations;
public class RateConfiguration : IEntityTypeConfiguration<Rate>
{
    public void Configure(EntityTypeBuilder<Rate> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Stopped)
               .HasColumnName("Stopped"); 

        builder.HasData(new Rate[]
        {
            new() { Id=1, Name="Rate1", Stopped=true },
            new() { Id=2, Name="Rate2" ,Stopped=false},
        });
    }
}
