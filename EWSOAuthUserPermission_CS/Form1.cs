
using Microsoft.Exchange.WebServices.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EWSOAuthUserPermission_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Auth_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();

            

        }

        private void btn_GetCalendarEvents_Click(object sender, EventArgs e)
        {
            ExchangeService service = null;
            service = new ExchangeService(ExchangeVersion.Exchange2013_SP1);

            service.Credentials = new OAuthCredentials(GlobalVar.token);

            service.TraceEnabled = true;
            service.TraceFlags = TraceFlags.All;


            service.Url = new Uri("https://outlook.office365.com/ews/exchange.asmx");

            ServicePointManager.ServerCertificateValidationCallback = (sender1, certificate, chain, sslPolicyErrors) => true;

            DateTime StartDate = DateTime.Today.AddDays(-100);
            DateTime EndDate = DateTime.Today.AddMonths(2);
            CalendarView cv = new CalendarView(StartDate, EndDate);

            FolderId CalendarFolderId = new FolderId(WellKnownFolderName.Calendar);
            FindItemsResults<Appointment> fapts = service.FindAppointments(CalendarFolderId, cv);
            if (fapts.Items.Count > 0)
            {

            }
        }

        private void btn_RefreshToken_Click(object sender, EventArgs e)
        {

            HttpContent content = new StringContent(GlobalVar.refreshtokenbody + GlobalVar.refreshtoken, Encoding.UTF8, "application/x-www-form-urlencoded");
            HttpClient httpClient = new HttpClient();

            var response = httpClient.PostAsync(GlobalVar.tokenAuthority, content).Result;

            var contents = response.Content.ReadAsStringAsync().Result;

            TokenResult tokenResult = JsonConvert.DeserializeObject<TokenResult>(contents);

            GlobalVar.token = tokenResult.access_token;
            GlobalVar.refreshtoken = tokenResult.refresh_token;
        }
    }
}
