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
    public partial class Users : UserControl
    {
        public Users()
        {
            InitializeComponent();
            populate();
        }

        private void populate()
        {
            List<User> users = DBQ.Instance.GetAll<User>();
            flowLayoutPanel1.Controls.Clear();
            foreach(User user in users)
            {
                flowLayoutPanel1.Controls.Add(new UserLine(user));
            }
        }

        private void saveBT_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.name = nameTB.Text.Trim();
            user.password = passwordTB.Text.Trim();
            user.isAdmin = isAdmin.Checked;
            DBQ.Instance.Insert<User>(user);
            populate();
        }
    }
}
