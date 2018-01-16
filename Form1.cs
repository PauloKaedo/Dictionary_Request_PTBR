using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                string signJson;
                string Url = ("http://dicionario-aberto.net/search-json/" + word.Text);
                signJson = wc.DownloadString(Url);
                dynamic definition = JsonConvert.DeserializeObject<dynamic>(signJson);

                sign.Text = strToUISO(""+definition.entry.sense[0].def);
            }
            catch (Exception ex)
            {
                sign.Text = "Palavra inválida ou não encontrada";
            }
        }

        private String strToUISO(string str)
        {
            var utf8 = Encoding.Default.GetBytes(str);
            var ascii = Encoding.UTF8.GetString(utf8);
            return ""+ascii;
        }
    }
}
