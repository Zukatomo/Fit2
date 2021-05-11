using Fit2.Database;
using Fit2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fit2.Views
{
    public partial class ClientList : UserControl
    {
        private List<Client> clients;
        public ClientList()
        {
            InitializeComponent();
            clients = new List<Client>();
            searchByName("");
        }

        private void searchByName(string name)
        {
            clients =  DBQ.Instance.GetByName<Client>(name);
            clientsPanel.Controls.Clear();
            foreach(Client c in clients)
            //for(int i=0;i<50;i++)
            {
                clientsPanel.Controls.Add(new LittleUser(c));
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchByName(nameTextBox.Text.Trim().ToUpper());
        }
    }
}
