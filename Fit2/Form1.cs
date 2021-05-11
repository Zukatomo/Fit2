using Fit2.Database;
using Fit2.Models;
using Fit2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fit2
{
    public partial class Form1 : Form
    {

        public static User me;

        public Form1()
        {
            InitializeComponent();
            me = null;
            AwesomeFormControllMagicWizzard.Init(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AwesomeFormControllMagicWizzard.AwesomeNextPageMagicFunction("LoginView");
        }
        private void Control_Removed(object sender, System.Windows.Forms.ControlEventArgs e)
        {
            MessageBox.Show("The control named " + e.Control.Name + " has been removed from the form.");
        }
    }
}
