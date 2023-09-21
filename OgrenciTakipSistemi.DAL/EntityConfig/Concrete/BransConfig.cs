using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OgrenciTakipSistemi.DAL.EntityConfig.Abstract;
using OgrenciTakipSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi.DAL.EntityConfig.Concrete
{
    public class BransConfig : BaseConfig<Brans>
    {
        public override void Configure(EntityTypeBuilder<Brans> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.BransId).HasMaxLength(50);
            builder.Property(p => p.BransAdi).HasMaxLength(50);
          


            builder.HasIndex(p => p.BransId).IsUnique();
            builder.HasIndex(p => p.BransAdi).IsUnique();
        }
    }
}
