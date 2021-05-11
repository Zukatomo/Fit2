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
    public partial class ClientHistory : UserControl
    {
        public ClientHistory(Client client)
        {
            InitializeComponent();
            List<ClientTicket> clientTickets = DBQ.Instance.ClientTickets(client.Id);
            List<Admission> admissions = new List<Admission>();
            foreach(ClientTicket clientTicket in clientTickets)
            {
                admissions.AddRange(DBQ.Instance.Admissions(clientTicket.Id));
            }
            admissions = admissions.OrderByDescending(x => x.date).ToList();
            foreach(Admission admission in admissions)
            {
                flowLayoutPanel1.Controls.Add(new AdmissionLine(admission));
            }
        }
    }
}
