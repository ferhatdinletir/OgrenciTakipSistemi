using OgrenciTakipSistemi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi.Entities.Concrete
{
    public class Brans:BaseEntity
    {
        public int BransId { get; set; }
        public string BransAdi { get; set;}

    }
}
