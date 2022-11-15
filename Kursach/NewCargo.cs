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
    public partial class NewCargo : Form
    {
        Cargo ct;
        TCPClient tCPClient;
        public NewCargo()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameCargo.Text != "")
                {
                    tCPClient = new TCPClient();
                    tCPClient.Tcpclient("SaveDataCargo" + "`" + JsonSerializer.Serialize(ct = new Cargo() { Name = NameCargo.Text, Price =Convert.ToDouble(Price.Text )}));
                }
                else
                {
                    MessageBox.Show("Введите сообщение!");
                }

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
