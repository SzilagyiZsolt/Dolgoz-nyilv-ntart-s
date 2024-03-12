using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grafikus_rest_api;

namespace Grafikus_rest_api
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            await dolgozok();
            adatok();
        }
        private static async Task<List<Api>> dolgozok()
        {
            List<Api> nyil = new List<Api>();
            string url = $"https://retoolapi.dev/Kc6xuH/data";
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                nyil = Api.FromJson(jsonString).ToList();
            }
            return nyil;
        }

        private void adatok_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void adatok()
        {
            List<Api> nyil = new List<Api>();
            foreach (Api api in nyil)
            {
                listbox_adatok.Items.Add(api.ApiName);
            }
        }
    }
}
