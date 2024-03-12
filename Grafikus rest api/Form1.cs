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

        private async void Form1_Load(object sender, EventArgs e)
        {
            await dolgozok();
        }
        private async Task dolgozok()
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
            foreach (var api in nyil)
            {
                listbox_adatok.Items.Add(api.ApiName);
            }
        }

        private async void Create_button_Click(object sender, EventArgs e)
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
            nyil.Add(new Api() {ApiName = textBox_Name.Text, ApiPosition=textBox_Position.Text, ApiSalary=int.Parse(textBox_Salary.Text)});
        }

        private async void Delete_button_Click(object sender, EventArgs e)
        {
            List<Api> nyil = new List<Api>();
            string url = $"https://retoolapi.dev/Kc6xuH/data{listbox_adatok.SelectedIndex}";
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Delete, url);
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                nyil = Api.FromJson(jsonString).ToList();
            }
        }

        private void listbox_adatok_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
