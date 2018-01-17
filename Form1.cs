using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.IO;
namespace Dictionary
{
    public partial class Main : Form
    {
        WebClient wc = new WebClient();
        public Main()
        {           
            InitializeComponent();
            
            search.Click+=delegate
            {
            try
            {
                string signJson;
                string Url = ($"http://dicionario-aberto.net/search-json/{word.Text});
                signJson = wc.DownloadString(Url);
                dynamic definition = JsonConvert.DeserializeObject<dynamic>(signJson);

                sign.Text = strToUISO(definition.entry.sense[0].def);
            }
            catch (Exception ex)
            {
                sign.Text = ex.ToString();
            }
            }
            
        }
        private String strToUISO(string str)
        {
            var utf8 = Encoding.Default.GetBytes(str);
            return utf8;
        }
    }
}
