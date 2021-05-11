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
    public partial class Read : UserControl
    {
        public Read()
        {
            InitializeComponent();

            flowLayoutPanel1.Controls.Add(new ReadBarcode());
        }
    }
}
