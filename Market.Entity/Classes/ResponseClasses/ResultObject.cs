using Market.Entity.Enums;

namespace Market.Entity.Classes.ResponseClasses
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
