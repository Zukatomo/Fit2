using Fit2.Database;
using Fit2.Helpers;
using Fit2.Models;
using MongoDB.Bson;
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
    public partial class LittleUser : UserControl
    {
        Client client;
        public LittleUser(Client client, bool showAll = true)
        {
            InitializeComponent();
            name.Text = client.name;
            cnp.Text = client.cnp;
            picture.Image = PictureManipulation.ResizeImage(PictureManipulation.ByteToImage(client.image),200,150);
            this.client = client;
            if (!showAll)
            {
                editButton.Hide();
                ticketButton.Hide();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //AwesomeFormControllMagicWizzard.nextPage(new NewClient(client));
            AwesomeFormControllMagicWizzard.AwesomeNextPageMagicFunction("NewClient", client);
        }

        private void ticketButton_Click(object sender, EventArgs e)
        {
            //AwesomeFormControllMagicWizzard.nextPage(new ClientTickets(client));
            AwesomeFormControllMagicWizzard.AwesomeNextPageMagicFunction("ClientTickets", client);

        }
    }
}
