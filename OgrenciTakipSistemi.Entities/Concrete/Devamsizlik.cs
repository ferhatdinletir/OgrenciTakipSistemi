using OgrenciTakipSistemi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi.Entities.Concrete
{
    public class Devamsizlik:BaseEntity
    {
        public DateTime? DevamsizlikTarihi { get; set; }
        public string? DevamsizlikSayisi { get; set; }
        public ICollection<Danisman> Danismanlar { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}
