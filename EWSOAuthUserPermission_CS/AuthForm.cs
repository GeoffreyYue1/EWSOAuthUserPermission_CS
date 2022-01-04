using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace EWSOAuthUserPermission_CS
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();

            authWeb.Url = new Uri(GlobalVar.uriStr);
            authWeb.ScriptErrorsSuppressed = true;

            authWeb.DocumentCompleted += AuthWeb_DocumentCompleted;

        }

        private void AuthWeb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           if( Regex.Match(((WebBrowser)sender).Url.AbsoluteUri, "error=[^&]*|code=[^&]*").Success)
            {
                var queryOutput = System.Web.HttpUtility.ParseQueryString(((WebBrowser)sender).Url.Query);
                GlobalVar.code=  queryOutput["Code"];

                HttpContent content = new StringContent(GlobalVar.body+ GlobalVar.code, Encoding.UTF8, "application/x-www-form-urlencoded");

                
                HttpClient httpClient = new HttpClient();
                
                var response =httpClient.PostAsync(GlobalVar.tokenAuthority,content).Result;

                var contents =  response.Content.ReadAsStringAsync().Result;

                TokenResult tokenResult = JsonConvert.DeserializeObject<TokenResult>(contents);

                GlobalVar.token = tokenResult.access_token;
                GlobalVar.refreshtoken = tokenResult.refresh_token;

                this.Close();
            }
        }

     



    }
}
