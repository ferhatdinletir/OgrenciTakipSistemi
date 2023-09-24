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
    public class DanismanConfig:BaseConfig<Danisman>
    {
        public override void Configure(EntityTypeBuilder<Danisman> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.DanismanAdi).HasMaxLength(50);
            builder.Property(p => p.DanismanSoyadi).HasMaxLength(50);
            builder.Property(p => p.TcNO).HasMaxLength(11);
            builder.Property(p => p.Gsm).HasMaxLength(20);
            builder.Property(p => p.Email).HasMaxLength(50);
            builder.Property(p => p.Password);
            builder.Property(p => p.Cinsiyet);
            builder.Property(p => p.Brans).HasMaxLength(50);
            builder.Property(p => p.Devamsizlik).HasMaxLength(50);
            builder.Property(p => p.Ders).HasMaxLength(50);
            builder.Property(p => p.DersNotlar).HasMaxLength(50);
            builder.Property(p => p.DersProgrami).HasMaxLength(50);
            builder.Property(p => p.SinavProgrami).HasMaxLength(50);



            builder.HasIndex(p => p.TcNO).IsUnique();
            builder.HasIndex(p => p.Gsm).IsUnique();
            builder.HasIndex(p => p.Email).IsUnique();
            builder.HasIndex(p =>p.Brans).IsUnique();
            builder.HasIndex(p => p.Ders).IsUnique();
        }
    }
}
