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
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            if (!Form1.me.isAdmin)
                usersButton.Hide();
        }

        private void newClient_Click(object sender, EventArgs e)
        {
            //AwesomeFormControllMagicWizzard.nextPage(new NewClient());
            AwesomeFormControllMagicWizzard.AwesomeNextPageMagicFunction("NewClient");
        }

        private void newTicketType_Click(object sender, EventArgs e)
        {
            AwesomeFormControllMagicWizzard.AwesomeNextPageMagicFunction("Tickets");
            //AwesomeFormControllMagicWizzard.nextPage(new Tickets());

        }

        private void clients_Click(object sender, EventArgs e)
        {
            AwesomeFormControllMagicWizzard.AwesomeNextPageMagicFunction("ClientList");
            //AwesomeFormControllMagicWizzard.nextPage(new ClientList());
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            AwesomeFormControllMagicWizzard.AwesomeNextPageMagicFunction("Read");

        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            AwesomeFormControllMagicWizzard.AwesomeNextPageMagicFunction("Users");
        }
    }
}
