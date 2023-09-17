using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OgrenciTakipSistemi.DAL.EntityConfig.Abstract;
using OgrenciTakipSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi.DAL.EntityConfig.Concrete
{
    public class RolConfig : BaseConfig<Rol>
    {
        public override void Configure(EntityTypeBuilder<Rol> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.RolAdi).HasMaxLength(50);
        }
    }
}
