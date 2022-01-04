using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace EWSOAuthUserPermission_CS
{
    static class GlobalVar
    {
        public static string adTenant = "geoffrey1.onmicrosoft.com";
        public static string clientId = "d22ed73d-dfd4-40b5-8974-dd133c81931d";
        public static string secret = "JftHr28QV8Da3rBvjktYmsEss]QLf_:@";
        public static string secret_encoded = HttpUtility.UrlEncode(secret);

        public static string redirectUri = "https://localhost/";

        public static string resource = "https://outlook.office365.com/";


        public static string authority = "https://login.microsoftonline.com/" + adTenant + "/oauth2/v2.0/authorize?";

        
        public static string uriStr = authority + "client_id=" + clientId + "&response_type=code" + "&redirect_uri=" + redirectUri + "&response_mode=query" + "&scope=offline_access https://outlook.office365.com/EWS.AccessAsUser.All" + "&Prompt=select_account";


        public static string tokenAuthority = "https://login.microsoftonline.com/" + adTenant + "/oauth2/v2.0/token";

         public static string body = "scope=" + "offline_access https://outlook.office365.com/EWS.AccessAsUser.All" + "&client_id=" + clientId + "&client_secret=" + secret_encoded + "&redirect_uri=" + redirectUri + "&grant_type=authorization_code" + "&code=";
       
        
        public static string refreshtokenbody= "scope=" + "offline_access https://outlook.office365.com/EWS.AccessAsUser.All" + "&client_id=" + clientId + "&client_secret=" + secret_encoded + "&redirect_uri=" + redirectUri + "&grant_type=refresh_token" + "&refresh_token=";

        public static string code = string.Empty;
        public static string token = string.Empty;
        public static string refreshtoken = string.Empty;
    }


    public class TokenResult
    {
        public string token_type;
        public string scope;
        public string expires_in;
        public string ext_expires_in;
        public string expires_on;
        public string not_before;
        public string resource;
        public string access_token;
        public string refresh_token;
        public string id_token;


    }
    static class Program
    {

       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
