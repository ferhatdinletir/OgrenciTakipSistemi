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
    public class DevamsizlikConfig : BaseConfig<Devamsizlik>
    {
        public override void Configure(EntityTypeBuilder<Devamsizlik> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.DevamsizlikTarihi);

        }
    }
}
