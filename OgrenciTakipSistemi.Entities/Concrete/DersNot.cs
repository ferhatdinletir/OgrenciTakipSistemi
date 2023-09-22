using OgrenciTakipSistemi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi.Entities.Concrete
{
    public class DersNot:BaseEntity
    {
        public Ders dersler { get; set; }
        public string? DersId { get; set;}

        public string? Vize { get; set; }

        public string? Final { get; set; }
    }
}
