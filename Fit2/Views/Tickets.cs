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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fit2.Views
{
    public partial class Tickets : UserControl
    {
        public Tickets()
        {
            InitializeComponent();
            LV.View = View.Details;
            LV.Columns.Add("Name");
            LV.Columns.Add("Price");
            LV.Columns.Add("Days");
            LV.Columns.Add("Occasions");
            LV.Columns.Add("Occ./Days");
            LV.Columns.Add("Start Time");
            LV.Columns.Add("End Time");
            LV.Columns.Add("Room Id");
            LV.Columns.Add("Inactive");
            getTickets();
            LV.GridLines = true;
            if (!Form1.me.isAdmin)
                flowLayoutPanel1.Hide();

        }

        private List<TicketType> tkts;
        private TicketType selectedTicketType = null;

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void getTickets()
        {
            tkts = DBQ.Instance.GetAll<TicketType>();
            LV.Items.Clear();
            foreach(TicketType tkt in tkts)
            {
                LV.Items.Add(new ListViewItem(new string[] { tkt.name, tkt.price.ToString(), tkt.days.ToString(),tkt.occasion.ToString(), tkt.maxOccasionPerDay.ToString(),
                tkt.startTime.ToString(),tkt.endTIme.ToString(), tkt.roomId.ToString(), tkt.isDeleted?"Inactive":"Active"}));
            }
        }

        

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                TicketType tkt = new TicketType(
                    newTicketNameTextBox.Text.Trim(),
                    Convert.ToDouble(newTicketPriceTextBox.Text.Trim()),
                    Convert.ToInt32(daysNUD.Value),
                    Convert.ToInt32(occNUD.Value),
                    isDeleted.Checked,
                    Convert.ToInt32(roomIdNUD.Value),
                    Convert.ToInt32(startTimeNUD.Value),
                    Convert.ToInt32(endTimeNUD.Value),
                    Convert.ToInt32(occPerDayNUD.Value)
                    );
                if(selectedTicketType != null)
                {
                    tkt.Id = selectedTicketType.Id;
                    DBQ.Instance.Update<TicketType>(tkt, tkt.Id);
                }
                else
                {
                    DBQ.Instance.Insert<TicketType>(tkt);
                }
                resetSelectedItem();
                getTickets();
            }
        }
        private void newTicketNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            validating(!string.IsNullOrWhiteSpace(newTicketNameTextBox.Text), newTicketNameTextBox, nameErrorProvider, "Name should not be left blank!", e);
        }

        private void newTicketPriceTextBox_Validating(object sender, CancelEventArgs e)
        {
            var regex = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
            validating(newTicketPriceTextBox.TextLength > 0 && regex.IsMatch(newTicketPriceTextBox.Text.Trim()),
                newTicketPriceTextBox, priceErrorProvider, "Price should be a positive number!", e);

        }

        private void validating(bool isGood, TextBox tb, ErrorProvider ep, string error, CancelEventArgs e)
        {
            if (isGood)
            {
                e.Cancel = false;
                ep.SetError(tb, "");
            }
            else
            {
                e.Cancel = true;
                tb.Focus();
                ep.SetError(tb, error);
            }
        }

        private void validatingNUD(NumericUpDown nud, ErrorProvider ep, string error, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nud.Text))
            {
                e.Cancel = false;
                ep.SetError(nud, "");
            }
            else
            {
                e.Cancel = true;
                nud.Focus();
                ep.SetError(nud, error);
            }
        }

        private void daysNUD_Validating(object sender, CancelEventArgs e)
        {
            validatingNUD(daysNUD, numericUpDownErrorProvider, "Value should not be left blank!", e);
        }

        private void occNUD_Validating(object sender, CancelEventArgs e)
        {
            validatingNUD(occNUD, numericUpDownErrorProvider, "Value should not be left blank!", e);
        }

        private void occPerDayNUD_Validating(object sender, CancelEventArgs e)
        {
            validatingNUD(occPerDayNUD, numericUpDownErrorProvider, "Value should not be left blank!", e);
        }

        private void startTimeNUD_Validating(object sender, CancelEventArgs e)
        {
            validatingNUD(startTimeNUD, numericUpDownErrorProvider, "Value should not be left blank!", e);
        }

        private void endTimeNUD_Validating(object sender, CancelEventArgs e)
        {
            validatingNUD(endTimeNUD, numericUpDownErrorProvider, "Value should not be left blank!", e);
        }

        private void roomIdNUD_Validating(object sender, CancelEventArgs e)
        {
            validatingNUD(roomIdNUD, numericUpDownErrorProvider, "Value should not be left blank!", e);
        }

        private void LV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LV.SelectedIndices.Count > 0)
            {
                itemSelected(LV.SelectedIndices[0]);
            }
            else
            {
                resetSelectedItem();
            }
            
        }

        private void itemSelected(int index)
        {
            selectedTicketType = tkts[index];
            newTicketNameTextBox.Text = selectedTicketType.name;
            newTicketPriceTextBox.Text = selectedTicketType.price.ToString();
            daysNUD.Value = selectedTicketType.days;
            occNUD.Value = selectedTicketType.occasion;
            occPerDayNUD.Value = selectedTicketType.maxOccasionPerDay;
            startTimeNUD.Value = selectedTicketType.startTime;
            endTimeNUD.Value = selectedTicketType.endTIme;
            roomIdNUD.Value = selectedTicketType.roomId;
            isDeleted.Checked = selectedTicketType.isDeleted;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            resetSelectedItem();
        }

        private void resetSelectedItem()
        {
            selectedTicketType = null;
            newTicketNameTextBox.Text = null;
            newTicketPriceTextBox.Text = null;
            daysNUD.Value = 30;
            occNUD.Value = 30;
            occPerDayNUD.Value = 1;
            startTimeNUD.Value = 8;
            endTimeNUD.Value = 22;
            roomIdNUD.Value = 3;
            isDeleted.Checked = false;
        }
    }
}
