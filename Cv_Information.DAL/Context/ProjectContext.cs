using Cv_Information.Entities.ORM.Concrete;
using Cv_Information.Map.Option;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv_Information.DAL.Context
{
    public class ProjectContext:IdentityDbContext<AppUser,AppRole,int>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=Cv_Information; integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new AboutMapping());
            builder.ApplyConfiguration(new EducationMapping());
            builder.ApplyConfiguration(new ExperinceMapping());
            builder.ApplyConfiguration(new AppUserMapping());
            base.OnModelCreating(builder);

        }

        public DbSet<Abouts> About { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Experience> Experience { get; set; }
        public DbSet<Skills> Skills { get; set; }

    }
}
