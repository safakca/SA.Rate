﻿using CRM.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.DataAccess.Configurations;

public class RateResultConfiguration : IEntityTypeConfiguration<RateResult>
{
    public void Configure(EntityTypeBuilder<RateResult> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Notes).HasMaxLength(500).HasColumnName("Notes");
        builder.Property(x => x.CreatedOn).HasColumnName("CreatedOn");
         
        //builder.HasMany(x => x.RateResultDetails).WithOne(x => x.RateResult).HasForeignKey(x => x.RateResultId).OnDelete(DeleteBehavior.Cascade); 
        //builder.HasOne(x => x.User).WithMany(x => x.RateResults).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.Cascade);
        //builder.HasOne(x => x.Task).WithMany(x => x.RateResults).HasForeignKey(x => x.TaskId).OnDelete(DeleteBehavior.Cascade); 
        //builder.HasOne(x => x.Customer).WithMany(x => x.RateResults).HasForeignKey(x=>x.CustomerId).OnDelete(DeleteBehavior.Cascade);

        builder.HasData(new RateResult[]
        {
            new() { Id=1, Notes="Test1", RateId=1, CustomerId=1, TaskId=1, CreatedBy="1", CreatedOn=DateTime.Now },
            new() { Id=2, Notes="Test2", RateId=2, CustomerId=2, TaskId=2, CreatedBy="2", CreatedOn=DateTime.Now },
        });
    }
}
