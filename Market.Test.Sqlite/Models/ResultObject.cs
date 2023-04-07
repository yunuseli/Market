
using Market.Test.Sqlite.Enums;

namespace Market.Test.Sqlite.Models
{
  public class ResultObject
  {
    public ResultStatus ResultStatus { get; set; }

    public string Title { get; set; }
    public string Message { get; set; }
    public string Description { get; set; }
    public string OriginProcess { get; set; }

    public int AffectedId { get; set; }
  }
}
