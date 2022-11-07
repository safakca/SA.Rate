using CRM.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.DataAccess.Configurations;
public class RateQNConfiguration : IEntityTypeConfiguration<RateQN>
{
    public void Configure(EntityTypeBuilder<RateQN> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.EQNType)
               .HasConversion<string>()
               .HasColumnName("EQNType");

        //builder.HasOne(x => x.Rate)
        //       .WithMany(x => x.RateQNs)
        //       .HasForeignKey(x => x.RateId)
        //       .OnDelete(DeleteBehavior.Cascade);

        //builder.HasOne(x => x.Translation)
        //       .WithOne(x => x.RateQN)
        //       .HasForeignKey<RateQN>(x => x.TranslationId)
        //       .OnDelete(DeleteBehavior.Cascade);

        //builder.HasOne(d => d.Translation)
        //           .WithMany(p => p.RateQNs)
        //           .HasForeignKey(d => d.TranslationId)
        //           .OnDelete(DeleteBehavior.ClientSetNull);

        builder.HasData(new RateQN[]
       {
            new() { Id=1,EQNType=Entity.Enums.EQNType.Star , RateId=1 , TranslationId=1}, 
            new() { Id=2,EQNType=Entity.Enums.EQNType.Star , RateId=1 , TranslationId=1},
            new() { Id=3,EQNType=Entity.Enums.EQNType.Star, RateId=1 , TranslationId=1},
            new() { Id=4,EQNType=Entity.Enums.EQNType.Star, RateId=2 , TranslationId=2},
            new() { Id=5,EQNType=Entity.Enums.EQNType.Star, RateId=2 , TranslationId=2},
            new() { Id=6,EQNType=Entity.Enums.EQNType.Star, RateId=2 , TranslationId=2},
            new() { Id=7,EQNType=Entity.Enums.EQNType.Star, RateId=2 , TranslationId=2},
       });
    }
}

