using OgrenciTakipSistemi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi.Entities.Concrete
{
    public class Bolum:BaseEntity
    {
        public int BolumId { get; set; }
        public string BolumAdi { get; set; }

    }
}
