using Cv_Information.Entities.ORM.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv_Information.Map.Option
{
    public class AboutMapping:BaseMapping<Abouts>
    {
        public override void Configure(EntityTypeBuilder<Abouts> builder)
        {
            builder.Property(i => i.About).IsRequired().HasMaxLength(500);
            
        }

    }
}
