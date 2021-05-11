
namespace Fit2.Views
{
    partial class TicketLine
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
            this.name = new System.Windows.Forms.Label();
            this.rd = new System.Windows.Forms.Label();
            this.ro = new System.Windows.Forms.Label();
            this.rot = new System.Windows.Forms.Label();
            this.inte = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.rom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(3, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(74, 25);
            this.name.TabIndex = 0;
            this.name.Text = "Name:";
            // 
            // rd
            // 
            this.rd.AutoSize = true;
            this.rd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd.Location = new System.Drawing.Point(3, 25);
            this.rd.Name = "rd";
            this.rd.Size = new System.Drawing.Size(172, 25);
            this.rd.TabIndex = 1;
            this.rd.Text = "Remaining days:";
            // 
            // ro
            // 
            this.ro.AutoSize = true;
            this.ro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ro.Location = new System.Drawing.Point(3, 50);
            this.ro.Name = "ro";
            this.ro.Size = new System.Drawing.Size(250, 25);
            this.ro.TabIndex = 2;
            this.ro.Text = "Remaining occ.: 101/120";
            // 
            // rot
            // 
            this.rot.AutoSize = true;
            this.rot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rot.Location = new System.Drawing.Point(437, 25);
            this.rot.Name = "rot";
            this.rot.Size = new System.Drawing.Size(309, 25);
            this.rot.TabIndex = 3;
            this.rot.Text = "Remaining occ. today: 101/120";
            // 
            // inte
            // 
            this.inte.AutoSize = true;
            this.inte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inte.Location = new System.Drawing.Point(437, 0);
            this.inte.Name = "inte";
            this.inte.Size = new System.Drawing.Size(88, 25);
            this.inte.TabIndex = 4;
            this.inte.Text = "Interval:";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(860, 2);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // enterButton
            // 
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.Location = new System.Drawing.Point(734, 4);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(136, 66);
            this.enterButton.TabIndex = 5;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // rom
            // 
            this.rom.AutoSize = true;
            this.rom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rom.Location = new System.Drawing.Point(437, 48);
            this.rom.Name = "rom";
            this.rom.Size = new System.Drawing.Size(88, 25);
            this.rom.TabIndex = 6;
            this.rom.Text = "Interval:";
            // 
            // TicketLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rom);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inte);
            this.Controls.Add(this.rot);
            this.Controls.Add(this.ro);
            this.Controls.Add(this.rd);
            this.Controls.Add(this.name);
            this.Name = "TicketLine";
            this.Size = new System.Drawing.Size(870, 79);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label rd;
        private System.Windows.Forms.Label ro;
        private System.Windows.Forms.Label rot;
        private System.Windows.Forms.Label inte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label rom;
    }
}
