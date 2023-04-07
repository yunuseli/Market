using DBTest.SystemClasses.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTest.DataModels.BaseModels
{
  public class ResultObject
  {

    public ResultStatus Status { get; set; }
    public string Message { get; set; }
    public string Description { get; set; }
    public string SenderName { get; set; }
  }
}
