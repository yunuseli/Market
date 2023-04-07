using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Market.Entity.Classes.DbClasses.BaseClasses
{
  public class BaseObject
  {
    //[Key]
    //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public DateTime CreatedOn { get; set; }
    public DateTime LastModifiedOn { get; set; }

    //[StringLength(150)]
    public string CreatedBy { get; set; }
    //[StringLength(150)]
    public string LastModifiedBy { get; set; }

    public bool IsDeleted { get; set; }
    public bool IsActive { get; set; }

 
  }
}
