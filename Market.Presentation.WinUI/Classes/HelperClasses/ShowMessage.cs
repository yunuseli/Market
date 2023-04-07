using Market.Entity.Classes.ResponseClasses;
using Market.Entity.Enums;

namespace Market.Presentation.WinUI.Classes.HelperClasses
{
  public class ShowMessage
  {
    public static void MesajGoster(ResultObject result)
    {
      string msg = $"Mesaj:\n{result.Message}\n";
      if (!String.IsNullOrEmpty(result.Description))
        msg += $"\nAyrıntı:\n{result.Description}\n";
      if (!String.IsNullOrEmpty(result.OriginProcess))
        msg += $"\nKaynak:\n{result.OriginProcess}\n";

      string caption = result.Title;
      switch (result.ResultStatus)
      {
        case ResultStatus.Success:
        case ResultStatus.Info:
          if (String.IsNullOrEmpty(caption))
            caption = "Bilgi";
          MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
          break;
        case ResultStatus.Warning:
          if (String.IsNullOrEmpty(caption))
            caption = "Uyarı";
          MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
          break;
        case ResultStatus.Error:
          if (String.IsNullOrEmpty(caption))
            caption = "Hata";
          MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
          break;
        default:
          break;
      }
    }
  }
}
