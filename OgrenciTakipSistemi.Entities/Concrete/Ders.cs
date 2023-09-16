using OgrenciTakipSistemi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi.Entities.Concrete
{
    public class Ders:BaseEntity
    {
        public string DersAdi { get; set; }
        public string DersAciklama { get;set; }
    }
}
