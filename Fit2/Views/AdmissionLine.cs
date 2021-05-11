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
    public partial class AdmissionLine : UserControl
    {
        public AdmissionLine(Admission admission)
        {
            InitializeComponent();
            ClientTicket ctk = DBQ.Instance.GetById<ClientTicket>(admission.clientTicketId);
            TicketType tkt = DBQ.Instance.GetById<TicketType>(ctk.ticketTypeId);
            User user = DBQ.Instance.GetById<User>(admission.userId);
            dateL.Text = admission.date.AsDateTime.ToString("yyyy/MM/dd hh:mm ddd");
            ticketNameL.Text = tkt.name.ToUpper();
            whoL.Text = user.name.ToUpper();
        }
    }
}
