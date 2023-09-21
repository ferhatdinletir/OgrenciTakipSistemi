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
    public class BolumConfig : BaseConfig<Bolum>
    {
        public override void Configure(EntityTypeBuilder<Bolum> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.BolumId).HasMaxLength(50);
            builder.Property(p => p.BolumId).HasMaxLength(50);



            builder.HasIndex(p => p.BolumId).IsUnique();
            builder.HasIndex(p => p.BolumAdi).IsUnique();
        }

    }
}
