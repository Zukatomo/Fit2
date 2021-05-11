
namespace Fit2.Views
{
    partial class MenuHeader
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
            this.button1 = new System.Windows.Forms.Button();
            this.backInTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backInTime
            // 
            this.backInTime.Location = new System.Drawing.Point(84, 3);
            this.backInTime.Name = "backInTime";
            this.backInTime.Size = new System.Drawing.Size(75, 39);
            this.backInTime.TabIndex = 1;
            this.backInTime.Text = "Back";
            this.backInTime.UseVisualStyleBackColor = true;
            this.backInTime.Click += new System.EventHandler(this.backInTime_Click);
            // 
            // MenuHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backInTime);
            this.Controls.Add(this.button1);
            this.Name = "MenuHeader";
            this.Size = new System.Drawing.Size(907, 45);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button backInTime;
    }
}
