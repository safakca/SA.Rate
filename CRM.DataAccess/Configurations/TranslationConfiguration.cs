using CRM.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.DataAccess.Configurations;

public class TranslationConfiguration : IEntityTypeConfiguration<Translation>
{
    public void Configure(EntityTypeBuilder<Translation> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Text).HasMaxLength(2).HasColumnName("Text");

        builder.HasData(new Translation[]
        {
            new() { Id=1, Text="TR"},
            new() { Id=2, Text="EN"},
        });
    }
}
