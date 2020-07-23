using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Context
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<RandomData>(entity =>
            {
                // add index
                entity.HasIndex(p => new { p.Date });
            });


            //do not create model
            //modelBuilder.Ignore<RandomData>();
        }

        public DbSet<RandomData> RandomDatas { get; set; }
    }
}
