using Fit2.Database;
using Fit2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fit2.Controllers
{
    class LoginController
    {
        public void login(string username, string password)
        {
            Form1.me = DBQ.Instance.GetUserByNameAndPassword(username, password);
            if(Form1.me == null)
            {
                MessageBox.Show("Wrong name or password!");
            }
            else
            {
                AwesomeFormControllMagicWizzard.AwesomeNextPageMagicFunction("Home");
            }
        }
    }
}
