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
    public partial class MenuHeader : UserControl
    {
        public MenuHeader()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.me != null)
            {
                //AwesomeFormControllMagicWizzard.nextPage(new Home());
                AwesomeFormControllMagicWizzard.AwesomeNextPageMagicFunction("Home");
            }
        }

        private void backInTime_Click(object sender, EventArgs e)
        {
            AwesomeFormControllMagicWizzard.AvadaKedavra();
        }
    }
}
