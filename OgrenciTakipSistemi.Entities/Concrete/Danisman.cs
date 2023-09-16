using OgrenciTakipSistemi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi.Entities.Concrete
{
    public class Danisman:BaseEntity
    {
        public string DanismanAdi { get; set; }
        public string DanismanSoyadi { get; set; }
        public bool Cinsiyet { get; set; }
        public string? TcNO { get; set; }
        public string? Gsm { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

