﻿using Cv_Information.Entities.ORM.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv_Information.Map.Option
{
    public class BaseMapping<T> : IEntityTypeConfiguration<T> where T:BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(i => i.ID);
            builder.Property(i => i.AddDate).IsRequired();
            builder.Property(i => i.DeleteDate).IsRequired(false);
            builder.Property(i => i.UpdateDate).IsRequired(false);
            builder.Property(i => i.DeleteDate).IsRequired();
        }
    }
}
