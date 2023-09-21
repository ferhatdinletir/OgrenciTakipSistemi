using OgrenciTakipSistemi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi.Entities.Concrete
{
    public class DersSinavProgrami:BaseEntity
    {
        public DateTime SinavTarihi { get; set; }
        public ICollection<Ders> Dersler { get; set; }
        public ICollection<Danisman> Danismanlar { get; set; }

    }
}
