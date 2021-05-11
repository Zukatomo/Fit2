
namespace Fit2.Views
{
    partial class Home
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.newClient = new System.Windows.Forms.Button();
            this.clients = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.newTicketType = new System.Windows.Forms.Button();
            this.barcodePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.usersButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.newClient);
            this.flowLayoutPanel1.Controls.Add(this.clients);
            this.flowLayoutPanel1.Controls.Add(this.readButton);
            this.flowLayoutPanel1.Controls.Add(this.usersButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(161, 378);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // newClient
            // 
            this.newClient.Location = new System.Drawing.Point(3, 3);
            this.newClient.Name = "newClient";
            this.newClient.Size = new System.Drawing.Size(158, 58);
            this.newClient.TabIndex = 0;
            this.newClient.Text = "&New Client";
            this.newClient.UseVisualStyleBackColor = true;
            this.newClient.Click += new System.EventHandler(this.newClient_Click);
            // 
            // clients
            // 
            this.clients.Location = new System.Drawing.Point(3, 67);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(158, 58);
            this.clients.TabIndex = 1;
            this.clients.Text = "&Clients";
            this.clients.UseVisualStyleBackColor = true;
            this.clients.Click += new System.EventHandler(this.clients_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(3, 131);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(158, 58);
            this.readButton.TabIndex = 2;
            this.readButton.Text = "&Read Barcode";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.newTicketType);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(171, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(161, 378);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // newTicketType
            // 
            this.newTicketType.Location = new System.Drawing.Point(3, 3);
            this.newTicketType.Name = "newTicketType";
            this.newTicketType.Size = new System.Drawing.Size(158, 58);
            this.newTicketType.TabIndex = 0;
            this.newTicketType.Text = "&New ticketType";
            this.newTicketType.UseVisualStyleBackColor = true;
            this.newTicketType.Click += new System.EventHandler(this.newTicketType_Click);
            // 
            // barcodePanel
            // 
            this.barcodePanel.Location = new System.Drawing.Point(338, 7);
            this.barcodePanel.Name = "barcodePanel";
            this.barcodePanel.Size = new System.Drawing.Size(367, 187);
            this.barcodePanel.TabIndex = 2;
            // 
            // usersButton
            // 
            this.usersButton.Location = new System.Drawing.Point(3, 195);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(158, 58);
            this.usersButton.TabIndex = 3;
            this.usersButton.Text = "&Users";
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barcodePanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1000, 600);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button newClient;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button newTicketType;
        private System.Windows.Forms.Button clients;
        private System.Windows.Forms.FlowLayoutPanel barcodePanel;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button usersButton;
    }
}
