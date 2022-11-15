using Kursach.DBModel;
using Kursach.Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class NewPoint : Form
    {
        TCPClient tCPClient;
        Country ct;
        public NewPoint()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                tCPClient = new TCPClient();
                tCPClient.Tcpclient("SaveDataCountry" + "`" + JsonSerializer.Serialize(ct = new Country()
                {
                    CountryCity = Country_box.Text,

                    City = City_box.Text,

                    Distance = int.Parse(Distance_box.Text)
                }));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           

           
        }

        private void Out_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
