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
    public partial class TicketLine : UserControl
    {
        ClientTicket clientTicket = null;
        TicketType ticketType = null;

        public int magic;

        public event EventHandler EmitLoadEvent;
        public TicketLine(ClientTicket ctk)
        {
            InitializeComponent();
            clientTicket = ctk;
            TicketType tkt = DBQ.Instance.GetById<TicketType>(ctk.ticketTypeId);
            ticketType = tkt;
            name.Text = "Name: "+tkt.name + (tkt.isDeleted?" DISABLED":"");
            double days = tkt.days- (int)(DateTime.Now - ctk.buyDate.AsDateTime).TotalDays;
            int maxOccasions = DBQ.Instance.AdmissionCount(ctk.Id);
            int occPerDay = DBQ.Instance.Admissions(ctk.Id).Count(x => x.date.AsDateTime.Date == DateTime.Today);
            string interval = tkt.startTime.ToString() + '-' + tkt.endTIme.ToString();
            rd.Text = "Remaining days: " +  days.ToString() + '/' + tkt.days;
            ro.Text = "Remaining occ.: " + (tkt.occasion - maxOccasions).ToString();
            rot.Text = "Remaining occ. today: " + (tkt.maxOccasionPerDay - occPerDay).ToString();
            inte.Text = "Interval: " + interval;
            rom.Text = "Room: " + tkt.roomId;
            int error = 0;
            if (days < 5)
            {
                rd.ForeColor = Color.Red;
                if (days <= 0) error++;
            }
            else
            {
                rd.ForeColor = Color.Black;
            }
            if(tkt.occasion - maxOccasions <= 1)
            {
                ro.ForeColor = Color.Red;
                if (tkt.occasion <= maxOccasions) error++;
            }
            else
            {
                ro.ForeColor = Color.Black;
            }
            if(tkt.maxOccasionPerDay - occPerDay <= 1)
            {
                rot.ForeColor = Color.Orange;
                if (tkt.maxOccasionPerDay <= occPerDay) error++;
            }
            else
            {
                rot.ForeColor = Color.Black;
            }
            if(tkt.startTime-1 <= DateTime.Now.Hour && tkt.endTIme >= DateTime.Now.Hour)
            {
                inte.ForeColor = Color.Black;
                
            }
            else
            {
                inte.ForeColor = Color.Red;
                error++;
            }
            if (tkt.isDeleted)
            {
                error+=50;
                this.BackColor = Color.DarkGray;
            }
            if(tkt.roomId != 3)
            {
                error++;
                rom.ForeColor = Color.Red;
            }
            else
            {
                rom.ForeColor = Color.Black;
            }
            if (error > 0)
            {
                enterButton.Enabled = false;
                this.BackColor = Color.Bisque;
            }
            else
            {
                enterButton.Enabled = true;
                this.BackColor = Color.Green;
            }
            this.magic = error;
            
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            Admission admission = new Admission(clientTicket.Id, Form1.me.Id);
            admission = DBQ.Instance.Insert<Admission>(admission);
            EmitLoadEvent.Invoke(this, e);
        }
    }
}
