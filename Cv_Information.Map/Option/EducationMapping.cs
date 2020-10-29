﻿using Cv_Information.Entities.ORM.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv_Information.Map.Option
{
    public class EducationMapping:BaseMapping<Education>
    {

        public override void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.Property(i => i.Description).IsRequired().HasMaxLength(100);
            builder.Property(i => i.Title).IsRequired();
            builder.Property(i => i.UnderTitle).IsRequired();
        }

    }
}
