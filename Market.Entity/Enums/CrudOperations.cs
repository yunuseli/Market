using System.ComponentModel.DataAnnotations;

namespace Market.Entity.Enums
{
  public enum CrudOperations
  {
    None = 0,

    [Display(Name = "Read", Description = "Oku")]
    Read = 1,
    List = 2,

    Insert = 10,
    InsertRange = 11,
    Update = 12,
    UpdateRange = 13,
    Delete = 14,
    DeleteRange = 15,
    DeleteHard = 16,
    DeleteHardRange = 17,

    Save = 20,
    Cancel = 21,
  }
}
