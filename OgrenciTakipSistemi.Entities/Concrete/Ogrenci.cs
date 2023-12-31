﻿using OgrenciTakipSistemi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi.Entities.Concrete
{
    public class Ogrenci:BaseEntity
    {
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool Cinsiyet { get; set; }
        public string? TcNO { get; set; }
        public string? Gsm { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Brans { get; set; }
        public string Ders {  get; set; }   
        public string Devamsizlik { get; set; }
        public string DersProgrami { get; set; }
        public string SinavProgrami { get; set; }
        public string DersNotlar { get; set; }

        public ICollection<Danisman> Danismanlar { get; set; }

    }
}
