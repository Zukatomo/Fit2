using Fit2.Database;
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
    public partial class ClientTickets : UserControl
    {

        class ComboItem
        {
            public ObjectId ID { get; set; }
            public string Text { get; set; }
        }

        private List<TicketType> tkts;
        private Client client = null;
        public ClientTickets(Client client)
        {
            this.client = client;
            InitializeComponent();
            clientPanel.Controls.Add(new LittleUser(client, false));
            tkts = DBQ.Instance.GetAll<TicketType>();
            List<ComboItem> cil = new List<ComboItem>();
            foreach(TicketType tkt in tkts)
            {
                cil.Add(new ComboItem()
                {
                    ID = tkt.Id,
                    Text = tkt.name,
                });
            }
            ticketPicker.DataSource = cil;
            ticketPicker.SelectedIndex = 0;
            populateTicketPanel();
        }

        void populateTicketPanel()
        {
            ticketPanel.Controls.Clear();
            List<ClientTicket> ctks = DBQ.Instance.ClientTickets(client.Id);
            List<TicketLine> tkls = new List<TicketLine>();
            foreach(ClientTicket ctk in ctks)
            {
                tkls.Add(new TicketLine(ctk));
            }
            tkls = tkls.OrderBy(x => x.magic).ToList();
            foreach (TicketLine tkl in tkls)
            {
                tkl.EmitLoadEvent += Tkl_EmitLoadEvent;
                ticketPanel.Controls.Add(tkl);
            }
            
        }

        private void Tkl_EmitLoadEvent(object sender, EventArgs e)
        {
            populateTicketPanel();
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            ClientTicket ctk = new ClientTicket(client.Id, (ObjectId)ticketPicker.SelectedValue);
            ctk = DBQ.Instance.Insert<ClientTicket>(ctk);
            populateTicketPanel();
        }
    }
}
