using DBTest.DataClasses.FileOperations;
using DBTest.DataModels.BaseModels;
using DBTest.SystemClasses.DbClasses;
using DBTest.SystemClasses.Enums;
using DBTest.SystemClasses.ProgramClasses;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Text;

namespace DBTest
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    //**** start settings
    DbConnection SetDbConnection;
    ProgramInfo SetProgramInfo;
    //**** start settings

    ResultObject resultObject = new ResultObject();

    private void Form1_Load(object sender, EventArgs e)
    {
      pageStart();
    }
    private void pageStart()
    {
      string cn = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      try
      {
        SetDbConnection = new DbConnection();
        SetProgramInfo = new ProgramInfo();

        FileOperation fileOperation = new FileOperation();

        string readDbFile = fileOperation.dbFileRead(out resultObject);
        if (resultObject.Status != ResultStatus.Success)
        {
          MessageBox.Show(ProgramInfo.classMessage("Veritaban� ayar dosyas� bulunamad�, yeni olu�turulacak ve ayar sayfas� a��lacak", cn), "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          File.WriteAllText(ProgramInfo.DataBase.systemDbFileName, ProgramInfo.DataBase.defaultDbConnStr);

          UserInterface.SystemSettings.DbSettings dbSettings = new UserInterface.SystemSettings.DbSettings();
          if (dbSettings.ShowDialog() != DialogResult.OK)
          {
            MessageBox.Show(ProgramInfo.classMessage("Veritaban� ayarlanmadan program ba�lat�lamaz", cn), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
            return;
          }

          readDbFile = fileOperation.dbFileRead(out resultObject);
        }

        DbConnection.SetDBConn(readDbFile, out resultObject);
        if (resultObject.Status != ResultStatus.Success)
        {
          // veritaban� ba�lant�s� kurulamad�
          string msg = "Veritaban� ba�lant�s� kurulamad�, ayar ekran�na y�nlendirileceksiniz, ayr�nt� : " + Environment.NewLine;
          msg += ProgramInfo.classMessage(resultObject.Description, cn);
          MessageBox.Show(msg, resultObject.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

          UserInterface.SystemSettings.DbSettings dbSettings = new UserInterface.SystemSettings.DbSettings();
          dbSettings.sql = readDbFile;
          if (dbSettings.ShowDialog() != DialogResult.OK)
          {
            MessageBox.Show(ProgramInfo.classMessage("Veritaban� ayarlanmadan program ba�lat�lamaz", cn), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
            return;
          }

          MessageBox.Show(ProgramInfo.classMessage("Veritaban� dosyas� ayar de�i�ti, program yeniden ba�lat�lacak", cn), "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          Application.Restart();
          return;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ProgramInfo.classMessage(ex.Message, cn), "Program ba�lang�� hatas�, yetkiliyi aray�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
        Application.Exit();
        return;
      }









      DataTable dt = new DataTable();
      try
      {
        using (SqlDataAdapter da = new SqlDataAdapter(@"
            SELECT 
              Id
              ,CreatedOn
              ,CreatedBy
              ,LastModifiedOn
              ,LastModifiedBy
              ,IsDeleted
              ,IsActive
              ,Name
              ,SurName
              ,Password
              ,EMail
            FROM 
              Users
            WHERE 
              IsDeleted = @IsDeleted 
              AND IsActive = @IsActive 
              AND EMail = @EMail 
              AND Password = @Password ", DbConnection.GetDBConn()))
        {
          da.SelectCommand.Parameters.Add("@IsDeleted", SqlDbType.Bit).Value = false;
          da.SelectCommand.Parameters.Add("@IsActive", SqlDbType.Bit).Value = true;
          da.SelectCommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = "1234";
          da.SelectCommand.Parameters.Add("@EMail", SqlDbType.NVarChar).Value = "system@system.com";

          da.Fill(dt);
        }

        if (dt.Rows.Count == 0)
        {
          using (SqlDataAdapter da = new SqlDataAdapter(@"
            SELECT 
              Id
              ,CreatedOn
              ,CreatedBy
              ,LastModifiedOn
              ,LastModifiedBy
              ,IsDeleted
              ,IsActive
              ,Name
              ,SurName
              ,Password
              ,EMail
            FROM 
              Users
            WHERE 
              IsDeleted = @IsDeleted 
              AND IsActive = @IsActive", DbConnection.GetDBConn()))
          {
            da.SelectCommand.Parameters.Add("@IsDeleted", SqlDbType.Bit).Value = false;
            da.SelectCommand.Parameters.Add("@IsActive", SqlDbType.Bit).Value = true;
            da.Fill(dt);
          }

          if (dt.Rows.Count == 0)
          {
            MessageBox.Show("Hi� aktif kullan�c� yok, yeni ol�turuluyor");


            string yeniKayitId = "";
            using (SqlCommand cmd = new SqlCommand(@"
                      INSERT INTO Users(
                        CreatedOn
                        ,CreatedBy
                        ,IsDeleted
                        ,IsActive
                        ,Name
                        ,SurName
                        ,Password
                        ,EMail) 
                      VALUES(
                        @CreatedOn
                        ,@CreatedBy
                        ,@IsDeleted
                        ,@IsActive
                        ,@Name
                        ,@SurName
                        ,@Password
                        ,@EMail) 
                      SET @newRecID = SCOPE_IDENTITY()", DbConnection.GetDBConn()))
            {
              cmd.Parameters.Add("@newRecID", SqlDbType.Int).Direction = ParameterDirection.Output;

              cmd.Parameters.Add("@CreatedOn", SqlDbType.DateTime).Value = DateTime.Now;
              cmd.Parameters.Add("@CreatedBy", SqlDbType.NVarChar).Value = "Sistem";
              cmd.Parameters.Add("@IsDeleted", SqlDbType.Bit).Value = false;
              cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = true;

              cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = "Sistem";
              cmd.Parameters.Add("@SurName", SqlDbType.NVarChar).Value = "Sistem";
              cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = "1234";
              cmd.Parameters.Add("@EMail", SqlDbType.NVarChar).Value = "system@system.com";

              cmd.ExecuteNonQuery();

              yeniKayitId = cmd.Parameters["@newRecID"].Value.ToString();
            }

            int ykid = 0;
            if (int.TryParse(yeniKayitId, out ykid) == false)
            {
              MessageBox.Show("Kay�t olu�turulamad�");
              return;
            }

            MessageBox.Show("Yeni kullan�c� eklendi, email = system@system.com | �ifre = 1234");
            Application.Restart();
            Environment.Exit(1000);
          }
          else
          {
            MessageBox.Show("Kullan�c� ad� yada �ifre hatal�");
          }
        }


        // Kullan�c� do�ruland�
        ProgramInfo.Session.currentUser.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
        ProgramInfo.Session.currentUser.CreatedOn = Convert.ToDateTime(dt.Rows[0]["CreatedOn"]);
        ProgramInfo.Session.currentUser.CreatedBy = dt.Rows[0]["CreatedBy"].ToString();
        if (!String.IsNullOrEmpty(dt.Rows[0]["LastModifiedOn"].ToString()))
          ProgramInfo.Session.currentUser.LastModifiedOn = Convert.ToDateTime(dt.Rows[0]["LastModifiedOn"]);
        else
          ProgramInfo.Session.currentUser.LastModifiedOn = DateTime.MinValue;
        if (!String.IsNullOrEmpty(dt.Rows[0]["LastModifiedOn"].ToString()))
          ProgramInfo.Session.currentUser.LastModifiedBy = dt.Rows[0]["LastModifiedBy"].ToString();
        else
          ProgramInfo.Session.currentUser.LastModifiedBy = String.Empty;
        ProgramInfo.Session.currentUser.IsDeleted = Convert.ToBoolean(dt.Rows[0]["IsDeleted"]);
        ProgramInfo.Session.currentUser.IsActive = Convert.ToBoolean(dt.Rows[0]["IsActive"]);
        ProgramInfo.Session.currentUser.Name = dt.Rows[0]["Name"].ToString();
        ProgramInfo.Session.currentUser.SurName = dt.Rows[0]["Surname"].ToString();
        ProgramInfo.Session.currentUser.Password = dt.Rows[0]["Password"].ToString();
        ProgramInfo.Session.currentUser.EMail = dt.Rows[0]["EMail"].ToString();

        ProgramInfo.Session.currentClient.ClientName = Environment.MachineName;
        ProgramInfo.Session.currentClient.ClientUserName = Environment.OSVersion.VersionString;
        ProgramInfo.Session.currentClient.ClientUserName = Environment.UserName;


        NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces(); //get all network interfaces
        IPAddress[] ips = Dns.GetHostAddresses(Dns.GetHostName()); // get all IP addresses based on the local host name 
        foreach (NetworkInterface adapter in adapters) //for each Network interface in addapters
        {
          if (adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet || adapter.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
          {
            if (adapter.OperationalStatus == OperationalStatus.Up)
            {
              if (adapter.Name.Contains("VMware") == false)
              {
                IPInterfaceProperties properties = adapter.GetIPProperties(); // get the ip properties from the adapter and store them into properties
                foreach (UnicastIPAddressInformation ip in properties.UnicastAddresses) // for each UnicastIPAddressInformation in the IPInterfaceProperties Unicast address( this assocaites the IP address with the correct adapter)
                {
                  //if the operationalStatus of the adapter is up and the ip Address family is in the Internwork
                  if (ip.Address.AddressFamily == AddressFamily.InterNetwork) //test against the name of the adapter you want to get
                  {
                    ProgramInfo.Session.currentClient.ClientIp = ip.Address;

                  }//end if
                }//end inner for, the UnicastIPAddressInformation for
              }
            }
          }
        }

        //var ticks = DateTime.Now.Ticks;
        //var guid = Guid.NewGuid().ToString();
        //var uniqueSessionId = ticks.ToString() + '-' + guid; //guid created by combining ticks
        ProgramInfo.Session.sGuid = Guid.NewGuid();



      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }









    }
  }
}




//public DataTable ROLES_select(SqlConnection DBConn, string FPN, int SID, int UID, int RS, int KID, int PRGHRID)
//{
//  #region Fonksiyon Ad� --- Sabit, De�i�meyecek
//  string cn = String.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
//  #endregion

//  #region A��klamalar *** Her Kopyada De�i�ecek
//  // Tan�m
//  // -----
//  // Sistem tablolar� - roller -- T�m� (KID=0 - PRGHRID=0),  ID (KID>0 - PRGHRID=0) veya PRGHRID (KID=0 - PRGHRID>0) ile

//  // De�i�kenler
//  // -----------
//  // DBConn      : Database Connection (SqlConnection) [DataBaseConnection]
//  // FPN         : Fonksiyon / Sayfa ad� (String) [FunctionPageName]
//  // SID         : Oturum ID (Int) [SessionID] 
//  // UID         : Oturum Kullan�c� ID (Int) [UserID]
//  // RS          : Kay�t Durumu (TinyInt)
//  // KID         : Kay�t ID (Int)
//  // PRGHRID     : PRGHR ID (Int)

//  // A��klamalar
//  // -----------
//  // verilen parametreler i�in

//  // �li�ki
//  // ------
//  // Sistem ��lemleri / SYS / PRGHRO

//  // Versiyon
//  // --------
//  // V1.0 - CU:Fuat A�IK - CD:09.10.2015 - �lk Olu�turma
//  // V1.1 - MU:Fuat A�IK - MD:27.10.2015 - T�m b�l�mler iyile�tirildi ve g�zden ge�irildi, uyar�lar, hata mesajlar� d�zenlendi
//  #endregion

//  #region Counters (DataTable) --- Sabit, De�i�meyecek
//  try
//  {
//    string counterCVP = csLOGAPP.count_SYSCNT(DBConn, UID, SID, cn);
//    if (counterCVP.Contains("ws_ERR"))
//    {
//      try
//      {
//        csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, cn, String.Format("Sistem saya� hatas� : {0}", counterCVP));
//      }
//      catch (Exception exLOGA)
//      {
//        DataTable dthata = new DataTable();
//        dthata.Columns.Add("ERROR");
//        dthata.Rows.Add(String.Format("ws_ERR : Sistem saya� hatas� ({0}) s�ras�nda aLog i�lem hatas� -> {1}{2}({3})", counterCVP, exLOGA.Message, "�", cn));
//        return dthata;
//      }
//    }
//  }
//  catch (Exception ex)
//  {
//    DataTable dthata = new DataTable();

//    try
//    {
//      csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, cn, String.Format("Counter ex err : {0}", ex.Message));
//    }
//    catch (Exception exLOGA)
//    {
//      dthata.Columns.Add("ERROR");
//      dthata.Rows.Add(String.Format("ws_ERR : Sistem saya� ex hatas� ({0}) s�ras�nda aLog i�lem hatas� -> {1}{2}({3})", ex.Message, exLOGA.Message, "�", cn));
//      return dthata;
//    }

//    dthata.Columns.Add("ERROR");
//    dthata.Rows.Add(String.Format("ws_ERR : Sistem saya� ex hatas� -> {0}{1}({2})", ex.Message, "�", cn));
//    return dthata;
//  }
//  #endregion

//  #region ��LEM *** Her Kopyada De�i�ecek
//  DataTable dt = new DataTable();
//  try
//  {
//    #region Hata Kontrol  *** Her Kopyada De�i�ecek
//    bool isOK = false;
//    if (KID == 0 && PRGHRID == 0) isOK = true;  // T�M� BO�
//    else if (KID != 0 && PRGHRID == 0) isOK = true;  // UGID dolu
//    else if (KID == 0 && PRGHRID != 0) isOK = true;  // PRGHRID dolu

//    if (!isOK)
//    {
//      DataTable dthata = new DataTable();
//      const string hatastr = "Parametreler �ak���yor, KID veya PRGHRID parametrelerinden sadece biri dolu olabilir";

//      #region Log ��lem, Hata D�n��� --- Sabit, De�i�meyecek
//      try
//      {
//        csLOGAPP.log_SYSLOGU(DBConn, UID, SID, cn, String.Format("err_{0}", hatastr));
//        csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, cn, String.Format("err_{0}", hatastr));
//      }
//      catch (Exception exLOGA)
//      {
//        dthata.Columns.Add("ERROR");
//        dthata.Rows.Add(String.Format("ws_ERR : Hata logu ({0}) i�leme s�ras�nda i�lem hatas� -> {1}{2}({3})", hatastr, exLOGA.Message, "�", cn));
//        return dthata;
//      }

//      dthata.Columns.Add("ERROR");
//      dthata.Rows.Add(String.Format("ws_ERR : {0}{1}({2})", hatastr, "�", cn));
//      return dthata;
//      #endregion
//    }
//    #endregion

//    #region SQL Sorgu Standart Metin  *** Her Kopyada De�i�ecek
//    const string SQLquery = @"
//            SELECT 
//              MAST.ID,
//              MAST.RS,
//              RSS.TANIM AS RSTANIM,
//              CUU.AD + ' ' + CUU.SOYAD AS CU,
//              MAST.CD,
//              MUU.AD + ' ' + MUU.SOYAD AS MU,
//              MAST.MD,
//              MAST.PRGHRID,
//              PRGHR.KOD AS PRGHRKOD,
//              PRGHR.TANIM AS PRGHRTANIM,
//              MAST.KOD,
//              MAST.TANIM,
//              MAST.ACIKLAMA
//            FROM 
//              SYSF.T021 AS MAST
//              INNER JOIN SYSF.T001 AS RSS ON MAST.RS = RSS.DEGER AND RSS.GRUP = 'SYSRS'
//              INNER JOIN SYSF.T011 AS CUU ON MAST.CU = CUU.ID
//              LEFT OUTER JOIN SYSF.T011 AS MUU ON MAST.MU = MUU.ID
//              INNER JOIN SYSF.T020 AS PRGHR ON MAST.PRGHRID = PRGHR.ID";
//    #endregion

//    #region SQL ��lem  *** Her Kopyada De�i�ecek
//    if (KID == 0 && PRGHRID == 0) // T�m kay�tlar
//    {
//      using (SqlDataAdapter da = new SqlDataAdapter(SQLquery, DBConn))
//      {
//        da.Fill(dt);
//      }
//    }
//    else if (KID != 0) // Rol kay�t ID  ile
//    {
//      using (SqlDataAdapter da = new SqlDataAdapter(SQLquery + @"
//            WHERE 
//              MAST.ID = @KID", DBConn))
//      {
//        da.SelectCommand.Parameters.Add("@KID", SqlDbType.Int).Value = KID;

//        da.Fill(dt);
//      }
//    }
//    else if (PRGHRID != 0) // PRGHRID ID ile
//    {
//      using (SqlDataAdapter da = new SqlDataAdapter(SQLquery + @"
//            WHERE 
//              MAST.PRGHRID = @PRGHRID", DBConn))
//      {
//        da.SelectCommand.Parameters.Add("@PRGHRID", SqlDbType.Int).Value = PRGHRID;

//        da.Fill(dt);
//      }
//    }
//    #endregion

//    #region Di�er ��lem  *** Her Kopyada De�i�ecek
//    // Yok
//    #endregion
//  }
//  catch (Exception ex)
//  {
//    #region ��LEM Hata d�n��� ve hata logu, --- Sabit, De�i�meyecek
//    DataTable dthata = new DataTable();

//    #region Hata Log
//    try
//    {
//      csLOGAPP.log_SYSLOGU(DBConn, UID, SID, cn, String.Format("err_��LEM ex : {0}", ex.Message));
//      csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, cn, String.Format("��LEM ex err : {0}", ex.Message));
//    }
//    catch (Exception exLOGA)
//    {
//      dthata.Columns.Add("ERROR");
//      dthata.Rows.Add(String.Format("ws_ERR : ��LEM ex hatas� ({0}) logu i�leme s�ras�nda hata -> {1}{2}({3})", ex.Message, exLOGA.Message, "�", cn));
//      return dthata;
//    }
//    #endregion

//    dthata.Columns.Add("ERROR");
//    dthata.Rows.Add(String.Format("ws_ERR : Veri i�lem ex hatas� -> {0}{1}({2})", ex.Message, "�", cn));
//    return dthata;
//    #endregion
//  }
//  #endregion

//  #region UserLOG (Datatable)  *** Her Kopyada De�i�ecek
//  try
//  {
//    #region Kullan�c� Logu haz�rlama, *** Her kopyada de�i�ecek
//    const string _SQLquerryType = "SQLs";
//    string _SQLtableName = "SYSF.T021";

//    string _SQLprmSTR = "";
//    if (KID == 0 && PRGHRID == 0) // T�m kay�tlar
//      _SQLprmSTR = "*";
//    else if (KID != 0) // Kay�t ID ile
//      _SQLprmSTR = String.Format("* where ID={0}", KID);
//    else if (PRGHRID != 0) // PRGHRID ile
//      _SQLprmSTR = String.Format("* where PRGHRID={0}", PRGHRID);
//    #endregion

//    #region Log i�lemi --- Sabit, De�i�meyecek
//    string LOGcvp = csLOGAPP.log_SYSLOGU(DBConn, UID, SID, cn, String.Format("{0}({1}){2}", _SQLquerryType, _SQLprmSTR, _SQLtableName));
//    if (LOGcvp.Contains("ws_ERR"))
//    {
//      try
//      {
//        csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, cn, String.Format("uLog i�leme hatas� : {0}", LOGcvp));
//      }
//      catch (Exception exLOGA)
//      {
//        DataTable dthata = new DataTable();
//        dthata.Columns.Add("ERROR");
//        dthata.Rows.Add(String.Format("ws_ERR : Veritaban� i�lemi tamamland� fakat uLog i�leme hatas� ({0}) s�ras�nda aLog i�lem hatas� al�nd� -> {1}{2}({3})", LOGcvp, exLOGA.Message, "�", cn));
//        return dthata;
//      }
//    }
//    #endregion
//  }
//  catch (Exception ex)
//  {
//    #region uLog Hata d�n��� ve hata logu i�leme, --- Sabit, De�i�meyecek
//    DataTable dthata = new DataTable();

//    try
//    {
//      csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, cn, String.Format("uLog Function ex err : {0}", ex.Message));
//    }
//    catch (Exception exLOGA)
//    {
//      dthata.Columns.Add("ERROR");
//      dthata.Rows.Add(String.Format("ws_ERR : Veritaban� i�lemi tamamland� fakat uLog i�leme hatas� ({0}) s�ras�nda aLog i�lem hatas� al�nd� -> {1}{2}({3})", ex.Message, exLOGA.Message, "�", cn));
//      return dthata;
//    }

//    dthata.Columns.Add("ERROR");
//    dthata.Rows.Add(String.Format("ws_ERR : Veritaban� i�lemi tamamland� fakat uLog i�leme s�ras�nda hatas al�nd� -> {0}{1}({2})", ex.Message, "�", cn));
//    return dthata;
//    #endregion
//  }
//  #endregion

//  return dt;
//}
//public string ROLES_insert(SqlConnection DBConn, string FPN, int SID, int UID, int RS, int PRGHRID, string KOD, string TANIM, string ACIKLAMA)
//{
//  const string myFuncName = "csSYSAPP.ROLES_insert";

//  #region A��klamalar
//  // Tan�m
//  // -----
//  // ROLES_insert

//  // De�i�kenler
//  // -----------
//  // DBConn      : Database Connection (SqlConnection) [DataBaseConnection]
//  // FPN         : Fonksiyon / Sayfa ad� (String) [FunctionPageName]
//  // SID         : Oturum ID (Int) [SessionID] 
//  // UID         : Kullan�c� ID (Int) [UserID]
//  // RS          : Kay�t Durumu (TinyInt) [RecordStatu]
//  // PRGHROID    : PRGHR Obje ID (Int)
//  // KOD         : Kod (String)
//  // TANIM       : Tan�m (String)
//  // ACIKLAMA    : A��klama (String)


//  // A��klamalar
//  // -----------
//  // ROLES_insert

//  // �li�ki
//  // ------
//  // Sistem ��lemleri / SYS / ROLES

//  // Versiyon
//  // --------
//  // V1.0 - CU:Fuat A�IK - CD:13.10.2015 - �lk Olu�turma
//  // V0.0 - MU:Fuat A�IK - MD:00.00.0000 - 
//  #endregion

//  #region Counters (String)
//  try
//  {
//    string counterCVP = csLOGAPP.count_SYSCNT(DBConn, UID, SID, myFuncNameSpace + myFuncName);
//    if (counterCVP.Contains("ws_ERR"))
//    {
//      try
//      {
//        csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, myFuncNameSpace + myFuncName, String.Format("Sistem saya� hatas� : {0}", counterCVP));
//      }
//      catch (Exception exLOGA)
//      {
//        return String.Format("ws_ERR : Sistem saya� hatas� ({0}) s�ras�nda aLog i�lem hatas� -> {1}{2}({3})", counterCVP, exLOGA.Message, "�", myFuncName);
//      }
//    }
//  }
//  catch (Exception ex)
//  {
//    try
//    {
//      csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, myFuncNameSpace + myFuncName, String.Format("err_Counter ex : {0}", ex.Message));
//    }
//    catch (Exception exLOGA)
//    {
//      return String.Format("ws_ERR : Sistem saya� ex hatas� ({0}) s�ras�nda aLog i�lem hatas� -> {1}{2}({3})", ex.Message, exLOGA.Message, "�", myFuncName);
//    }

//    return String.Format("ws_ERR : Sistem saya� ex hatas� -> {0}{1}({2})", ex.Message, "�", myFuncName);
//  }
//  #endregion




//  #region ��LEM
//  string yeniID = "";
//  DateTime timeNow = DateTime.Now;
//  try
//  {
//    using (SqlCommand cmd = new SqlCommand(@"
//            INSERT INTO SYSF.T021(
//              RS,
//              CU,
//              CD, 
//              PRGHRID,
//              KOD,
//              TANIM,
//              ACIKLAMA) 
//            VALUES(
//              @RS,
//              @CU,
//              @CD, 
//              @PRGHRID,
//              @KOD,
//              @TANIM,
//              @ACIKLAMA)
//            SET @YeniID = SCOPE_IDENTITY()", DBConn))
//    {
//      cmd.Parameters.Add("@YeniID", SqlDbType.Int).Direction = ParameterDirection.Output;

//      cmd.Parameters.Add("@PRGHRID", SqlDbType.Int).Value = PRGHRID;

//      cmd.Parameters.Add("@CU", SqlDbType.Int).Value = UID;
//      cmd.Parameters.Add("@CD", SqlDbType.DateTime).Value = timeNow;
//      cmd.Parameters.Add("@RS", SqlDbType.TinyInt).Value = RS;

//      cmd.Parameters.Add("@KOD", SqlDbType.VarChar).Value = KOD;
//      cmd.Parameters.Add("@TANIM", SqlDbType.VarChar).Value = TANIM;
//      if (ACIKLAMA == "")
//        cmd.Parameters.Add("@ACIKLAMA", SqlDbType.VarChar).Value = DBNull.Value;
//      else
//        cmd.Parameters.Add("@ACIKLAMA", SqlDbType.VarChar).Value = ACIKLAMA;


//      cmd.ExecuteNonQuery();

//      yeniID = cmd.Parameters["@YeniID"].Value.ToString();
//    }
//  }
//  catch (Exception ex)
//  {
//    try
//    {
//      csLOGAPP.log_SYSLOGU(DBConn, UID, SID, myFuncNameSpace + myFuncName, String.Format("err_SQL : {0}", ex.Message));
//      csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, myFuncNameSpace + myFuncName, String.Format("err_SQL : {0}", ex.Message));
//    }
//    catch (Exception exLOGA)
//    {
//      return String.Format("ws_ERR : uLog i�leme hatas� {0} s�ras�nda Log i�lem hatas� -> {1}{2}({3})", ex.Message, exLOGA.Message, "�", myFuncName);
//    }

//    return String.Format("ws_ERR : Database i�lem hatas� -> {0}{1}({2})", ex.Message, "�", myFuncName);
//  }
//  #endregion

//  #region UserLOG (String)
//  try
//  {
//    string SQLprmSTR = String.Format("RS={0},CU={1},CD={2},PRGHRID={3},KOD={4},TANIM={5},ACIKLAMA={6}",
//      RS, UID, timeNow, PRGHRID, KOD, TANIM, ACIKLAMA);

//    string LOGcvp = csLOGAPP.log_SYSLOGU(DBConn, UID, SID, myFuncNameSpace + myFuncName, String.Format("SQLi({0})SYSF.T021", SQLprmSTR));
//    if (LOGcvp.Contains("ws_ERR"))
//    {
//      try
//      {
//        csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, myFuncNameSpace + myFuncName, String.Format("err_uLog i�leme hatas� : {0}", LOGcvp));
//      }
//      catch (Exception exLOGA)
//      {
//        return String.Format("ws_ERR : uLog i�leme hatas� {0} s�ras�nda aLog i�lem hatas� -> {1}{2}({3})", LOGcvp, exLOGA.Message, "�", myFuncName);
//      }
//    }
//  }
//  catch (Exception ex)
//  {
//    try
//    {
//      csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, myFuncNameSpace + myFuncName, String.Format("err_uLog ex : {0}", ex.Message));
//    }
//    catch (Exception exLOGA)
//    {
//      return String.Format("ws_ERR : uLog Fonksiyon hatas� {0} s�ras�nda aLog i�lem hatas� -> {1}{2}({3})", ex.Message, exLOGA.Message, "�", myFuncName);
//    }

//    return String.Format("ws_ERR : {0}{1}({2})", ex.Message, "�", myFuncName);
//  }
//  #endregion

//  return yeniID;
//}
//public string ROLES_update(SqlConnection DBConn, string FPN, int SID, int UID, int RS, int PRGHRID, string KOD, string TANIM, string ACIKLAMA, int KID)
//{
//  const string myFuncName = "csSYSAPP.ROLES_update";

//  #region A��klamalar
//  // Tan�m
//  // -----
//  // ROLES_update

//  // De�i�kenler
//  // -----------
//  // DBConn      : Database Connection (SqlConnection) [DataBaseConnection]
//  // FPN         : Fonksiyon / Sayfa ad� (String) [FunctionPageName]
//  // SID         : Oturum ID (Int) [SessionID] 
//  // UID         : Kullan�c� ID (Int) [UserID]
//  // RS          : Kay�t Durumu (TinyInt) [RecordStatu]
//  // PRGHROID    : PRGHR Obje ID (Int)
//  // KOD         : Kod (String)
//  // TANIM       : Tan�m (String)
//  // ACIKLAMA    : A��klama (String)

//  // A��klamalar
//  // -----------
//  // ROLES_update

//  // �li�ki
//  // ------
//  // Sistem ��lemleri / SYS / ROLES

//  // Versiyon
//  // --------
//  // V1.0 - CU:Fuat A�IK - CD:13.10.2015 - �lk Olu�turma
//  // V0.0 - MU:Fuat A�IK - MD:00.00.0000 - 
//  #endregion

//  #region Counters (String)
//  try
//  {
//    string counterCVP = csLOGAPP.count_SYSCNT(DBConn, UID, SID, myFuncNameSpace + myFuncName);
//    if (counterCVP.Contains("ws_ERR"))
//    {
//      try
//      {
//        csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, myFuncNameSpace + myFuncName, String.Format("Sistem saya� hatas� : {0}", counterCVP));
//      }
//      catch (Exception exLOGA)
//      {
//        return String.Format("ws_ERR : Sistem saya� hatas� ({0}) s�ras�nda aLog i�lem hatas� -> {1}{2}({3})", counterCVP, exLOGA.Message, "�", myFuncName);
//      }
//    }
//  }
//  catch (Exception ex)
//  {
//    try
//    {
//      csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, myFuncNameSpace + myFuncName, String.Format("err_Counter ex : {0}", ex.Message));
//    }
//    catch (Exception exLOGA)
//    {
//      return String.Format("ws_ERR : Sistem saya� ex hatas� ({0}) s�ras�nda aLog i�lem hatas� -> {1}{2}({3})", ex.Message, exLOGA.Message, "�", myFuncName);
//    }

//    return String.Format("ws_ERR : Sistem saya� ex hatas� -> {0}{1}({2})", ex.Message, "�", myFuncName);
//  }
//  #endregion

//  #region ��LEM
//  #region Eski Datalar (log ve d�zenleme onay� i�in)
//  DataTable dtOLD = ROLES_select(DBConn, FPN, SID, UID, 0, KID, 0);

//  if (dtOLD.Columns.Count == 1 && dtOLD.Columns[0].ColumnName == "ERROR")
//  {
//    try
//    {
//      csLOGAPP.log_SYSLOGU(DBConn, UID, SID, myFuncNameSpace + myFuncName, String.Format("err_G�ncelleme eski bilgilere eri�im hatas� : {0}", dtOLD.Rows[0][0].ToString().Replace("ws_ERR : ", "").Replace("�", "-")));
//      csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, myFuncNameSpace + myFuncName, String.Format("err_G�ncelleme eski bilgilere eri�im hatas� : {0}", dtOLD.Rows[0][0].ToString().Replace("ws_ERR : ", "").Replace("�", "-")));
//    }
//    catch (Exception exLOGA)
//    {
//      return String.Format("ws_ERR : G�ncelleme eski bilgilere eri�im hatas� {0} s�ras�nda Log i�lem hatas� -> {1}{2}({3})",
//        dtOLD.Rows[0][0].ToString().Replace("ws_ERR : ", "").Replace("�", "-"), exLOGA.Message, "�", myFuncName);
//    }

//    return String.Format("ws_ERR : {0}{1}({2})", dtOLD.Rows[0][0].ToString().Replace("ws_ERR : ", ""), "�", myFuncName);
//  }
//  if (dtOLD.Rows.Count == 0)
//  {
//    try
//    {
//      csLOGAPP.log_SYSLOGU(DBConn, UID, SID, myFuncNameSpace + myFuncName, String.Format("err_G�ncelleme eski bilgiler yok : {0}", dtOLD.Rows[0][0].ToString().Replace("ws_ERR : ", "").Replace("�", "-")));
//      csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, myFuncNameSpace + myFuncName, String.Format("err_G�ncelleme eski bilgiler yok : {0}", dtOLD.Rows[0][0].ToString().Replace("ws_ERR : ", "").Replace("�", "-")));
//    }
//    catch (Exception exLOGA)
//    {
//      return String.Format("ws_ERR : G�ncelleme eski bilgilere eri�im hatas� {0} s�ras�nda Log i�lem hatas� -> {1}{2}({3})",
//        dtOLD.Rows[0][0].ToString().Replace("ws_ERR : ", "").Replace("�", "-"), exLOGA.Message, "�", myFuncName);
//    }

//    return String.Format("ws_ERR : {0}{1}({2})", "G�ncelleme eski bilgiler yok", "�", myFuncName);
//  }
//  #endregion

//  #region D�zenleme onay�
//  if (!onay_DUZENLENEBILIRMI(Convert.ToInt32(dtOLD.Rows[0]["RS"].ToString())))
//  {
//    try
//    {
//      csLOGAPP.log_SYSLOGU(DBConn, UID, SID, myFuncNameSpace + myFuncName, String.Format("err_SQL : {0}", "Bu kayd� d�zenleyemezsiniz, kay�t d�zenlemeye kar�� kilitli"));
//    }
//    catch (Exception exLOGA)
//    {
//      return String.Format("ws_ERR : Kay�t d�zenleme hatas� {0} s�ras�nda Log i�lem hatas� -> {1}{2}({3})",
//        "Bu kayd� d�zenleyemezsiniz, kay�t d�zenlemeye kar�� kilitli", exLOGA.Message, "�", myFuncName);
//    }

//    return String.Format("ws_ERR : {0}{1}({2})", "Bu kayd� d�zenleyemezsiniz, kay�t d�zenlemeye kar�� kilitli", "�", myFuncName);
//  }
//  #endregion

//  DateTime timeNow = DateTime.Now;
//  try
//  {
//    using (SqlCommand cmd = new SqlCommand(@"
//            UPDATE SYSF.T021 SET
//              PRGHRID = @PRGHRID,
//              RS = @RS,
//              MU = @MU,
//              MD = @MD, 
//              KOD = @KOD,
//              TANIM = @TANIM,
//              ACIKLAMA = @ACIKLAMA
//            WHERE 
//              ID = @ID", DBConn))
//    {
//      cmd.Parameters.Add("@ID", SqlDbType.Int).Value = KID;

//      cmd.Parameters.Add("@PRGHRID", SqlDbType.Int).Value = PRGHRID;

//      cmd.Parameters.Add("@MU", SqlDbType.Int).Value = UID;
//      cmd.Parameters.Add("@MD", SqlDbType.DateTime).Value = timeNow;
//      cmd.Parameters.Add("@RS", SqlDbType.TinyInt).Value = RS;

//      cmd.Parameters.Add("@KOD", SqlDbType.VarChar).Value = KOD;
//      cmd.Parameters.Add("@TANIM", SqlDbType.VarChar).Value = TANIM;
//      if (ACIKLAMA == "")
//        cmd.Parameters.Add("@ACIKLAMA", SqlDbType.VarChar).Value = DBNull.Value;
//      else
//        cmd.Parameters.Add("@ACIKLAMA", SqlDbType.VarChar).Value = ACIKLAMA;

//      cmd.ExecuteNonQuery();
//    }
//  }
//  catch (Exception ex)
//  {
//    try
//    {
//      csLOGAPP.log_SYSLOGU(DBConn, UID, SID, myFuncNameSpace + myFuncName, String.Format("err_SQL : {0}", ex.Message));
//      csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, myFuncNameSpace + myFuncName, String.Format("err_SQL : {0}", ex.Message));
//    }
//    catch (Exception exLOGA)
//    {
//      return String.Format("ws_ERR : uLog i�leme hatas� {0} s�ras�nda Log i�lem hatas� -> {1}{2}({3})", ex.Message, exLOGA.Message, "�", myFuncName);
//    }

//    return String.Format("ws_ERR : Database i�lem hatas� -> {0}{1}({2})", ex.Message, "�", myFuncName);
//  }
//  #endregion

//  #region UserLOG (String)
//  try
//  {
//    string SQLprmSTR = String.Format("RS-{0}={1},MU-{2}={3},MD-{4}={5},PRGHRID-{6}={7},KOD-{8}={9},TANIM-{10}={11},ACIKLAMA-{12}={13} where ID={14}",
//      dtOLD.Rows[0]["RS"].ToString(), RS,
//      dtOLD.Rows[0]["MU"].ToString(), UID,
//      dtOLD.Rows[0]["MD"].ToString(), timeNow,
//      dtOLD.Rows[0]["PRGHRID"].ToString(), PRGHRID,
//      dtOLD.Rows[0]["KOD"].ToString(), KOD,
//      dtOLD.Rows[0]["TANIM"].ToString(), TANIM,
//      dtOLD.Rows[0]["ACIKLAMA"].ToString(), ACIKLAMA,
//      KID
//      );

//    string LOGcvp = csLOGAPP.log_SYSLOGU(DBConn, UID, SID, myFuncNameSpace + myFuncName, String.Format("SQLu({0})SYSF.T021", SQLprmSTR));
//    if (LOGcvp.Contains("ws_ERR"))
//    {
//      try
//      {
//        csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, myFuncNameSpace + myFuncName, String.Format("err_uLog i�leme hatas� : {0}", LOGcvp));
//      }
//      catch (Exception exLOGA)
//      {
//        return String.Format("ws_ERR : uLog i�leme hatas� {0} s�ras�nda aLog i�lem hatas� -> {1}{2}({3})", LOGcvp, exLOGA.Message, "�", myFuncName);
//      }
//    }
//  }
//  catch (Exception ex)
//  {
//    try
//    {
//      csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, myFuncNameSpace + myFuncName, String.Format("err_uLog ex : {0}", ex.Message));
//    }
//    catch (Exception exLOGA)
//    {
//      return String.Format("ws_ERR : uLog Fonksiyon hatas� {0} s�ras�nda aLog i�lem hatas� -> {1}{2}({3})", ex.Message, exLOGA.Message, "�", myFuncName);
//    }

//    return String.Format("ws_ERR : {0}{1}({2})", ex.Message, "�", myFuncName);
//  }
//  #endregion

//  return KID.ToString();
//}
//public string ROLES_delete_duzenlenecek(SqlConnection DBConn, string FPN, int SID, int UID, int KID)
//{
//  const string myFuncName = "csSYSAPP.PRGHRO_delete";

//  #region A��klamalar
//  // Tan�m
//  // -----
//  // PRGHRO_delete

//  // De�i�kenler
//  // -----------
//  // DBConn      : Database Connection (SqlConnection) [DataBaseConnection]
//  // FPN         : Fonksiyon / Sayfa ad� (String) [FunctionPageName]
//  // SID         : Oturum ID (Int) [SessionID] 
//  // UID         : Kullan�c� ID (Int) [UserID]
//  // KID         : Kay�t ID (Int)

//  // A��klamalar
//  // -----------
//  // PRGHRO_delete

//  // �li�ki
//  // ------
//  // Sistem ��lemleri / SYS / PRGHRO

//  // Versiyon
//  // --------
//  // V1.0 - CU:Fuat A�IK - CD:08.10.2015 - �lk Olu�turma
//  // V0.0 - MU:Fuat A�IK - MD:00.00.0000 - 
//  #endregion

//  #region Counters (String)
//  try
//  {
//    string counterCVP = csLOGAPP.count_SYSCNT(DBConn, UID, SID, myFuncNameSpace + myFuncName);
//    if (counterCVP.Contains("ws_ERR"))
//    {
//      try
//      {
//        csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, myFuncNameSpace + myFuncName, String.Format("Sistem saya� hatas� : {0}", counterCVP));
//      }
//      catch (Exception exLOGA)
//      {
//        return String.Format("ws_ERR : Sistem saya� hatas� ({0}) s�ras�nda aLog i�lem hatas� -> {1}{2}({3})", counterCVP, exLOGA.Message, "�", myFuncName);
//      }
//    }
//  }
//  catch (Exception ex)
//  {
//    try
//    {
//      csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, myFuncNameSpace + myFuncName, String.Format("err_Counter ex : {0}", ex.Message));
//    }
//    catch (Exception exLOGA)
//    {
//      return String.Format("ws_ERR : Sistem saya� ex hatas� ({0}) s�ras�nda aLog i�lem hatas� -> {1}{2}({3})", ex.Message, exLOGA.Message, "�", myFuncName);
//    }

//    return String.Format("ws_ERR : Sistem saya� ex hatas� -> {0}{1}({2})", ex.Message, "�", myFuncName);
//  }
//  #endregion

//  #region ��LEM
//  // eski datalar� al, log i�in
//  DataTable dtOLD = PRGHRO_select(DBConn, FPN, SID, UID, 0, KID);

//  if (dtOLD.Columns.Count == 1 && dtOLD.Columns[0].ColumnName == "ERROR")
//  {
//    try
//    {
//      csLOGAPP.log_SYSLOGU(DBConn, UID, SID, myFuncNameSpace + myFuncName, String.Format("err_Silme eski bilgilere eri�im hatas� : {0}", dtOLD.Rows[0][0].ToString().Replace("ws_ERR : ", "").Replace("�", "-")));
//      csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, myFuncNameSpace + myFuncName, String.Format("err_Silme eski bilgilere eri�im hatas� : {0}", dtOLD.Rows[0][0].ToString().Replace("ws_ERR : ", "").Replace("�", "-")));
//    }
//    catch (Exception exLOGA)
//    {
//      return String.Format("ws_ERR : Silme eski bilgilere eri�im hatas� {0} s�ras�nda Log i�lem hatas� -> {1}{2}({3})",
//        dtOLD.Rows[0][0].ToString().Replace("ws_ERR : ", "").Replace("�", "-"), exLOGA.Message, "�", myFuncName);
//    }

//    return String.Format("ws_ERR : {0}{1}({2})", dtOLD.Rows[0][0].ToString().Replace("ws_ERR : ", ""), "�", myFuncName);
//  }
//  if (dtOLD.Rows.Count == 0)
//  {
//    try
//    {
//      csLOGAPP.log_SYSLOGU(DBConn, UID, SID, myFuncNameSpace + myFuncName, String.Format("err_Silme eski bilgiler yok : {0}", dtOLD.Rows[0][0].ToString().Replace("ws_ERR : ", "").Replace("�", "-")));
//      csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, myFuncNameSpace + myFuncName, String.Format("err_Silme eski bilgiler yok : {0}", dtOLD.Rows[0][0].ToString().Replace("ws_ERR : ", "").Replace("�", "-")));
//    }
//    catch (Exception exLOGA)
//    {
//      return String.Format("ws_ERR : Silme eski bilgilere eri�im hatas� {0} s�ras�nda Log i�lem hatas� -> {1}{2}({3})",
//        dtOLD.Rows[0][0].ToString().Replace("ws_ERR : ", "").Replace("�", "-"), exLOGA.Message, "�", myFuncName);
//    }

//    return String.Format("ws_ERR : {0}{1}({2})", "Silme eski bilgiler yok", "�", myFuncName);
//  }


//  DateTime timeNow = DateTime.Now;
//  try
//  {
//    using (SqlCommand cmd = new SqlCommand(@"
//            UPDATE SYSF.T020 SET
//              BAGID = @BAGID,
//              RS = @RS,
//              MU = @MU,
//              MD = @MD, 
//              TIP = @TIP,
//              KOD = @KOD,
//              TANIM = @TANIM,
//              ACIKLAMA = @ACIKLAMA,
//              PLATFORMID = @PLATFORMID,
//              PROJEID = @PROJEID,
//              PROGRAMID = @PROGRAMID,
//              MODULID = @MODULID,
//              SAYFAID = @SAYFAID 
//            WHERE 
//              ID = @ID", DBConn))
//    {
//      cmd.Parameters.Add("@ID", SqlDbType.Int).Value = KID;

//      cmd.ExecuteNonQuery();
//    }
//  }
//  catch (Exception ex)
//  {
//    try
//    {
//      csLOGAPP.log_SYSLOGU(DBConn, UID, SID, myFuncNameSpace + myFuncName, String.Format("err_SQL : {0}", ex.Message));
//      csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, myFuncNameSpace + myFuncName, String.Format("err_SQL : {0}", ex.Message));
//    }
//    catch (Exception exLOGA)
//    {
//      return String.Format("ws_ERR : uLog i�leme hatas� {0} s�ras�nda Log i�lem hatas� -> {1}{2}({3})", ex.Message, exLOGA.Message, "�", myFuncName);
//    }

//    return String.Format("ws_ERR : Database i�lem hatas� -> {0}{1}({2})", ex.Message, "�", myFuncName);
//  }
//  #endregion

//  #region UserLOG (String)
//  try
//  {
//    string SQLprmSTR = String.Format("ID={0},RS={1},CU={2},CD={3},MU={4},MD={5},TIP={6},KOD={7},TANIM={8},ACIKLAMA={9},PLATFORMID={10},PROJEID={11},PROGRAMID={12},MODULID={13},SAYFAID={14}",
//      KID,
//      dtOLD.Rows[0]["RS"],
//      dtOLD.Rows[0]["CU"],
//      dtOLD.Rows[0]["CD"],
//      dtOLD.Rows[0]["MU"],
//      dtOLD.Rows[0]["MD"],
//      dtOLD.Rows[0]["TIP"],
//      dtOLD.Rows[0]["KOD"],
//      dtOLD.Rows[0]["TANIM"],
//      dtOLD.Rows[0]["ACIKLAMA"],
//      dtOLD.Rows[0]["PLATFORMID"],
//      dtOLD.Rows[0]["PROJEID"],
//      dtOLD.Rows[0]["PROGRAMID"],
//      dtOLD.Rows[0]["MODULID"],
//      dtOLD.Rows[0]["SAYFAID"]
//      );

//    string LOGcvp = csLOGAPP.log_SYSLOGU(DBConn, UID, SID, myFuncNameSpace + myFuncName, String.Format("SQLd({0})SYSF.T020", SQLprmSTR));
//    if (LOGcvp.Contains("ws_ERR"))
//    {
//      try
//      {
//        csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, myFuncNameSpace + myFuncName, String.Format("err_uLog i�leme hatas� : {0}", LOGcvp));
//      }
//      catch (Exception exLOGA)
//      {
//        return String.Format("ws_ERR : uLog i�leme hatas� {0} s�ras�nda aLog i�lem hatas� -> {1}{2}({3})", LOGcvp, exLOGA.Message, "�", myFuncName);
//      }
//    }
//  }
//  catch (Exception ex)
//  {
//    try
//    {
//      csLOGAPP.log_SYSLOGA(DBConn, UID, SID, FPN, myFuncNameSpace + myFuncName, String.Format("err_uLog ex : {0}", ex.Message));
//    }
//    catch (Exception exLOGA)
//    {
//      return String.Format("ws_ERR : uLog Fonksiyon hatas� {0} s�ras�nda aLog i�lem hatas� -> {1}{2}({3})", ex.Message, exLOGA.Message, "�", myFuncName);
//    }

//    return String.Format("ws_ERR : {0}{1}({2})", ex.Message, "�", myFuncName);
//  }
//  #endregion

//  return KID.ToString();
//}