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
    public partial class UserLine : UserControl
    {
        private User user;
        public UserLine(User user)
        {
            this.user = user;
            InitializeComponent();
            nameTB.Text = user.name;
            passwordTB.Text = user.password;
            isAdmin.Checked = user.isAdmin;
        }

        private void saveBT_Click(object sender, EventArgs e)
        {
            user.name = nameTB.Text.Trim();
            user.password = passwordTB.Text.Trim();
            user.isAdmin = isAdmin.Checked;
            DBQ.Instance.Update<User>(user, user.Id);
        }
    }
}
