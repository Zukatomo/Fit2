
namespace Fit2.Views
{
    partial class AdmissionLine
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
            this.dateL = new System.Windows.Forms.Label();
            this.ticketNameL = new System.Windows.Forms.Label();
            this.whoL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateL
            // 
            this.dateL.AutoSize = true;
            this.dateL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateL.Location = new System.Drawing.Point(4, 4);
            this.dateL.Name = "dateL";
            this.dateL.Size = new System.Drawing.Size(70, 25);
            this.dateL.TabIndex = 0;
            this.dateL.Text = "label1";
            // 
            // ticketNameL
            // 
            this.ticketNameL.AutoSize = true;
            this.ticketNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketNameL.Location = new System.Drawing.Point(344, 4);
            this.ticketNameL.Name = "ticketNameL";
            this.ticketNameL.Size = new System.Drawing.Size(70, 25);
            this.ticketNameL.TabIndex = 1;
            this.ticketNameL.Text = "label1";
            // 
            // whoL
            // 
            this.whoL.AutoSize = true;
            this.whoL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whoL.Location = new System.Drawing.Point(640, 4);
            this.whoL.Name = "whoL";
            this.whoL.Size = new System.Drawing.Size(70, 25);
            this.whoL.TabIndex = 2;
            this.whoL.Text = "label1";
            // 
            // AdmissionLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.whoL);
            this.Controls.Add(this.ticketNameL);
            this.Controls.Add(this.dateL);
            this.Name = "AdmissionLine";
            this.Size = new System.Drawing.Size(815, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateL;
        private System.Windows.Forms.Label ticketNameL;
        private System.Windows.Forms.Label whoL;
    }
}
