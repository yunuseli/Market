using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakip.Models
{
    public class OgrenciModel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sinif { get; set; }
        public string Sube { get; set; }
        public ushort Numara { get; set; }
        public byte Not1 { get; set; }
        public byte Not2 { get; set; }
        public byte Not3 { get; set; }
        public float Ortalama { get; set; }
        public bool Durum { get; set; }

        public string Isim
        {
            get { return $"{Ad} {Soyad}"; }
        }
    }
}
