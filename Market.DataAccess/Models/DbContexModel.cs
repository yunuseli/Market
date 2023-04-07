using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.DataAccess.Models
{
  public class DbContexModel
  {
    protected string Data_Source { get; set; }
    protected string Initial_Catalog { get; set; }
    protected string Persist_Security_Info { get; set; }
    protected string User_ID { get; set; }
    protected string Password { get; set; }
  }
}
