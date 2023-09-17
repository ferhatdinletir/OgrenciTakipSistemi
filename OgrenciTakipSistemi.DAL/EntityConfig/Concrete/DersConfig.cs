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
    public class DersConfig:BaseConfig<Ders>
    {
        public override void Configure(EntityTypeBuilder<Ders> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.DersAdi).HasMaxLength(50);
            builder.Property(p => p.DersAciklama).HasMaxLength(1000);
          


            builder.HasIndex(p => p.DersAdi).IsUnique();
            
        }
    }
}
