using DBTest.DataModels.BaseModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBTest.DataModels.UserModels
{
  public class UserModel : BaseObject
    {
        //[LocalizedDisplayName("Name", NameResourceType = typeof(IRehberinResourceService))]
        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(150)]
        //[LocalizedDisplayName("SurName", NameResourceType = typeof(IRehberinResourceService))]
        public string SurName { get; set; }

        //[LocalizedDisplayName("FullName", NameResourceType = typeof(IRehberinResourceService))]
        public string FullName => $"{Name} {SurName}";

        //[LocalizedDisplayName("Password", NameResourceType = typeof(IRehberinResourceService))]
        [StringLength(100)]
        public string Password { get; set; }

        [NotMapped]
        //[LocalizedDisplayName("Password_Repeat", NameResourceType = typeof(IRehberinResourceService))]
        public string PasswordRepeat { get; set; }

        //[LocalizedDisplayName("EMail", NameResourceType = typeof(IRehberinResourceService))]
        [StringLength(256)]
        public string EMail { get; set; }

        //public ICollection<ManagerUserLoginLog> ManagerUserLoginLogs { get; set; }
    }
}
