using Kursach.DBModel;
using Kursach.Method;
using Kursach.Model;
using Kursach.Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{

    public partial class FirstMenu : Form
    {
        string json;

        TCPClient tCPClient;
        IDGET idg;
        Doc doc;
        public FirstMenu() => InitializeComponent();

        private void NewPoint_Click(object sender, EventArgs e)
        {
            NewPoint button = new NewPoint();
            button.Show();

        }

        private void New_Cargo_Click(object sender, EventArgs e)
        {
            NewCargo button = new NewCargo();
            button.Show();
        }

        private void Processing_Click(object sender, EventArgs e)
        {
            try
            {
                doc = JsonSerializer.Deserialize<Doc>(tCPClient.Tcpclient(json = "Processing" + "`" + JsonSerializer.Serialize<IDGET>(
                    idg = new IDGET() 
                    {
                        IDFrom = From_box.Text, 
                        IDTo = To_Box.Text,
                        Cargo=Cargo_box.Text
                    })));

                GetPrice.Text = doc.Sum.ToString() + " BYN";
                Save_file.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Введите все параметры!!");
            }
           
        }

        private void Save_file_Click(object sender, EventArgs e)
        {
            try
            {
                SaveinFile file = new SaveinFile();
                json = tCPClient.Tcpclient(json = "Processing" + "`" + JsonSerializer.Serialize<IDGET>(idg = new IDGET() { IDFrom = From_box.Text, IDTo = To_Box.Text, Cargo = Cargo_box.Text }));
                MessageBox.Show("Файл сохранен по пути: " + file.Wrtite(json));
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void FirstMenu_Load(object sender, EventArgs e)
        {
            LouderData();
            Save_file.Enabled = false;
        }
        public void LouderData()
        {
            try
            {

                tCPClient = new TCPClient();

                var getdata = JsonSerializer.Deserialize<Country[]>(tCPClient.Tcpclient("GetData"));
                foreach (var i in getdata)
                {
                    From_box.Items.Add(i.City);
                    To_Box.Items.Add(i.City);
                }
                var getdatas = JsonSerializer.Deserialize<Cargo[]>(tCPClient.Tcpclient("GetDataC"));
                foreach (var i in getdatas)
                {
                    Cargo_box.Items.Add(i.Name);
                }

            }
            catch (Exception)
            {

                
            }


        }
    

        private void Refresh_Click(object sender, EventArgs e)
        {
            From_box.Items.Clear();
            To_Box.Items.Clear();
            Cargo_box.Items.Clear();
            LouderData();
        

        }
    }
}
