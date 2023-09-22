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
    public class DersNotConfig:BaseConfig<DersNot>
    {
        public override void Configure(EntityTypeBuilder<DersNot> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Vize).HasMaxLength(50);
            builder.Property(p => p.Final).HasMaxLength(1000);




        }
    }
}
