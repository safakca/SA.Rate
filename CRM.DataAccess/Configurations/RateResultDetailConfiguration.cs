﻿using CRM.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.DataAccess.Configurations;

public class RateResultDetailConfiguration : IEntityTypeConfiguration<RateResultDetail>
{
    public void Configure(EntityTypeBuilder<RateResultDetail> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.ValueInt).HasColumnName("ValueInt");
        builder.Property(x => x.ValueString).HasColumnName("ValueString");

        //builder.HasOne(x => x.RateResult).WithMany(x => x.RateResultDetails).HasForeignKey(x => x.RateResultId).OnDelete(DeleteBehavior.Cascade);
    //    builder.HasOne(x => x.RateQN).WithMany(x => x.RateResultDetails).HasForeignKey(x => x.RateQNId).OnDelete(DeleteBehavior.Cascade);


        builder.HasData(new RateResultDetail[]
        {
            new() { Id=1,RateQNId=1, ValueInt=1, ValueString="test1", RateResultId=1},
            new() { Id=2,RateQNId=2, ValueInt=1, ValueString="test", RateResultId=2},
       });
   }
}
