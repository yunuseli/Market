using OgrenciTakip.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakip.Models
{
  public class CevapModel
  {
    public CevapDurumlari Durum { get; set; }
    public string Mesaj { get; set; }
    public string Aciklama { get; set; }
    public string Kaynak { get; set; }
  }
}
