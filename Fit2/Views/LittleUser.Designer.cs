
namespace Fit2.Views
{
    partial class LittleUser
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.cnp = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.ticketButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(3, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(200, 150);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(3, 156);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(70, 25);
            this.name.TabIndex = 1;
            this.name.Text = "label1";
            // 
            // cnp
            // 
            this.cnp.AutoSize = true;
            this.cnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnp.Location = new System.Drawing.Point(3, 181);
            this.cnp.Name = "cnp";
            this.cnp.Size = new System.Drawing.Size(70, 25);
            this.cnp.TabIndex = 2;
            this.cnp.Text = "label1";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(3, 209);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(95, 23);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // ticketButton
            // 
            this.ticketButton.Location = new System.Drawing.Point(104, 209);
            this.ticketButton.Name = "ticketButton";
            this.ticketButton.Size = new System.Drawing.Size(95, 23);
            this.ticketButton.TabIndex = 4;
            this.ticketButton.Text = "Tickets";
            this.ticketButton.UseVisualStyleBackColor = true;
            this.ticketButton.Click += new System.EventHandler(this.ticketButton_Click);
            // 
            // LittleUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ticketButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.cnp);
            this.Controls.Add(this.name);
            this.Controls.Add(this.picture);
            this.Name = "LittleUser";
            this.Size = new System.Drawing.Size(206, 236);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label cnp;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button ticketButton;
    }
}
