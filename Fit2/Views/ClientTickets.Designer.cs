
namespace Fit2.Views
{
    partial class ClientTickets
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clientPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ticketPicker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sellButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ticketPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // clientPanel
            // 
            this.clientPanel.Location = new System.Drawing.Point(243, 4);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(200, 204);
            this.clientPanel.TabIndex = 0;
            // 
            // ticketPicker
            // 
            this.ticketPicker.DisplayMember = "Text";
            this.ticketPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketPicker.FormattingEnabled = true;
            this.ticketPicker.Location = new System.Drawing.Point(9, 32);
            this.ticketPicker.Name = "ticketPicker";
            this.ticketPicker.Size = new System.Drawing.Size(121, 33);
            this.ticketPicker.TabIndex = 1;
            this.ticketPicker.ValueMember = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Ticket";
            // 
            // sellButton
            // 
            this.sellButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellButton.Location = new System.Drawing.Point(137, 32);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(91, 33);
            this.sellButton.TabIndex = 3;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tickets";
            // 
            // ticketPanel
            // 
            this.ticketPanel.AutoScroll = true;
            this.ticketPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ticketPanel.Location = new System.Drawing.Point(9, 214);
            this.ticketPanel.Name = "ticketPanel";
            this.ticketPanel.Size = new System.Drawing.Size(978, 317);
            this.ticketPanel.TabIndex = 5;
            this.ticketPanel.WrapContents = false;
            // 
            // ClientTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ticketPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ticketPicker);
            this.Controls.Add(this.clientPanel);
            this.Name = "ClientTickets";
            this.Size = new System.Drawing.Size(1000, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel clientPanel;
        private System.Windows.Forms.ComboBox ticketPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel ticketPanel;
    }
}
