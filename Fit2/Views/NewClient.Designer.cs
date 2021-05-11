
namespace Fit2.Views
{
    partial class NewClient
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
            if (videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
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
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.clientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clientPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clientEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clientCnp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clientAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clientNotes = new System.Windows.Forms.RichTextBox();
            this.clientPicture = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.takePic = new System.Windows.Forms.Button();
            this.retakePic = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.errors = new System.Windows.Forms.Label();
            this.qrBox = new System.Windows.Forms.PictureBox();
            this.historyButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientPicture)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrBox)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.clientNameLabel);
            this.flowLayoutPanel1.Controls.Add(this.clientName);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.clientPhone);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.clientEmail);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.clientCnp);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.clientAddress);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.clientNotes);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(276, 594);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNameLabel.Location = new System.Drawing.Point(3, 0);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(74, 25);
            this.clientNameLabel.TabIndex = 0;
            this.clientNameLabel.Text = "Name:";
            // 
            // clientName
            // 
            this.clientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientName.Location = new System.Drawing.Point(3, 28);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(270, 31);
            this.clientName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phone:";
            // 
            // clientPhone
            // 
            this.clientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientPhone.Location = new System.Drawing.Point(3, 90);
            this.clientPhone.Name = "clientPhone";
            this.clientPhone.Size = new System.Drawing.Size(270, 31);
            this.clientPhone.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email:";
            // 
            // clientEmail
            // 
            this.clientEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientEmail.Location = new System.Drawing.Point(3, 152);
            this.clientEmail.Name = "clientEmail";
            this.clientEmail.Size = new System.Drawing.Size(270, 31);
            this.clientEmail.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "CNP:";
            // 
            // clientCnp
            // 
            this.clientCnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientCnp.Location = new System.Drawing.Point(3, 214);
            this.clientCnp.Name = "clientCnp";
            this.clientCnp.Size = new System.Drawing.Size(270, 31);
            this.clientCnp.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Address:";
            // 
            // clientAddress
            // 
            this.clientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientAddress.Location = new System.Drawing.Point(3, 276);
            this.clientAddress.Name = "clientAddress";
            this.clientAddress.Size = new System.Drawing.Size(270, 31);
            this.clientAddress.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Notes:";
            // 
            // clientNotes
            // 
            this.clientNotes.Location = new System.Drawing.Point(3, 338);
            this.clientNotes.Name = "clientNotes";
            this.clientNotes.Size = new System.Drawing.Size(270, 223);
            this.clientNotes.TabIndex = 11;
            this.clientNotes.Text = "";
            // 
            // clientPicture
            // 
            this.clientPicture.Location = new System.Drawing.Point(282, 12);
            this.clientPicture.Name = "clientPicture";
            this.clientPicture.Size = new System.Drawing.Size(400, 300);
            this.clientPicture.TabIndex = 1;
            this.clientPicture.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.takePic);
            this.flowLayoutPanel2.Controls.Add(this.retakePic);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(688, 12);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(179, 100);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // takePic
            // 
            this.takePic.Location = new System.Drawing.Point(3, 3);
            this.takePic.Name = "takePic";
            this.takePic.Size = new System.Drawing.Size(176, 75);
            this.takePic.TabIndex = 0;
            this.takePic.Text = "Take Picture";
            this.takePic.UseVisualStyleBackColor = true;
            this.takePic.Click += new System.EventHandler(this.takePic_Click);
            // 
            // retakePic
            // 
            this.retakePic.Location = new System.Drawing.Point(3, 84);
            this.retakePic.Name = "retakePic";
            this.retakePic.Size = new System.Drawing.Size(176, 75);
            this.retakePic.TabIndex = 1;
            this.retakePic.Text = "Retake Picture";
            this.retakePic.UseVisualStyleBackColor = true;
            this.retakePic.Click += new System.EventHandler(this.retakePic_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(285, 318);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(400, 171);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // errors
            // 
            this.errors.AutoSize = true;
            this.errors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errors.ForeColor = System.Drawing.Color.Red;
            this.errors.Location = new System.Drawing.Point(688, 125);
            this.errors.Name = "errors";
            this.errors.Size = new System.Drawing.Size(66, 16);
            this.errors.TabIndex = 4;
            this.errors.Text = "ERRORS";
            // 
            // qrBox
            // 
            this.qrBox.Location = new System.Drawing.Point(691, 251);
            this.qrBox.Name = "qrBox";
            this.qrBox.Size = new System.Drawing.Size(285, 313);
            this.qrBox.TabIndex = 5;
            this.qrBox.TabStop = false;
            // 
            // historyButton
            // 
            this.historyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyButton.Location = new System.Drawing.Point(285, 495);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(400, 77);
            this.historyButton.TabIndex = 6;
            this.historyButton.Text = "History";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // NewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.qrBox);
            this.Controls.Add(this.errors);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.clientPicture);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "NewClient";
            this.Size = new System.Drawing.Size(1000, 600);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientPicture)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qrBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clientEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clientCnp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox clientNotes;
        private System.Windows.Forms.PictureBox clientPicture;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button takePic;
        private System.Windows.Forms.Button retakePic;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox clientAddress;
        private System.Windows.Forms.Label errors;
        private System.Windows.Forms.PictureBox qrBox;
        private System.Windows.Forms.Button historyButton;
    }
}
