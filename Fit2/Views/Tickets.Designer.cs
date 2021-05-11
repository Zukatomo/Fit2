
namespace Fit2.Views
{
    partial class Tickets
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
            this.components = new System.ComponentModel.Container();
            this.LV = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.newTicketNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newTicketPriceTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.occPerDayNUD = new System.Windows.Forms.NumericUpDown();
            this.occNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.daysNUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.roomIdNUD = new System.Windows.Forms.NumericUpDown();
            this.endTimeNUD = new System.Windows.Forms.NumericUpDown();
            this.startTimeNUD = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.isDeleted = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.newButton = new System.Windows.Forms.Button();
            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.priceErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.numericUpDownErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.occPerDayNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.occNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNUD)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomIdNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endTimeNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startTimeNUD)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // LV
            // 
            this.LV.FullRowSelect = true;
            this.LV.HideSelection = false;
            this.LV.Location = new System.Drawing.Point(4, 4);
            this.LV.MultiSelect = false;
            this.LV.Name = "LV";
            this.LV.Size = new System.Drawing.Size(743, 360);
            this.LV.TabIndex = 0;
            this.LV.UseCompatibleStateImageBehavior = false;
            this.LV.SelectedIndexChanged += new System.EventHandler(this.LV_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // newTicketNameTextBox
            // 
            this.newTicketNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTicketNameTextBox.Location = new System.Drawing.Point(117, 3);
            this.newTicketNameTextBox.Name = "newTicketNameTextBox";
            this.newTicketNameTextBox.Size = new System.Drawing.Size(136, 31);
            this.newTicketNameTextBox.TabIndex = 1;
            this.newTicketNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.newTicketNameTextBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price:  ";
            // 
            // newTicketPriceTextBox
            // 
            this.newTicketPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTicketPriceTextBox.Location = new System.Drawing.Point(117, 37);
            this.newTicketPriceTextBox.Name = "newTicketPriceTextBox";
            this.newTicketPriceTextBox.Size = new System.Drawing.Size(136, 31);
            this.newTicketPriceTextBox.TabIndex = 3;
            this.newTicketPriceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.newTicketPriceTextBox_Validating);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.occPerDayNUD, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.occNUD, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.newTicketPriceTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.newTicketNameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.daysNUD, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 370);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(276, 177);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // occPerDayNUD
            // 
            this.occPerDayNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occPerDayNUD.Location = new System.Drawing.Point(117, 139);
            this.occPerDayNUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.occPerDayNUD.Name = "occPerDayNUD";
            this.occPerDayNUD.Size = new System.Drawing.Size(136, 31);
            this.occPerDayNUD.TabIndex = 11;
            this.occPerDayNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.occPerDayNUD.Validating += new System.ComponentModel.CancelEventHandler(this.occPerDayNUD_Validating);
            // 
            // occNUD
            // 
            this.occNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occNUD.Location = new System.Drawing.Point(117, 105);
            this.occNUD.Name = "occNUD";
            this.occNUD.Size = new System.Drawing.Size(136, 31);
            this.occNUD.TabIndex = 10;
            this.occNUD.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.occNUD.Validating += new System.ComponentModel.CancelEventHandler(this.occNUD_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Days:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Occasion:";
            // 
            // daysNUD
            // 
            this.daysNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysNUD.Location = new System.Drawing.Point(117, 71);
            this.daysNUD.Name = "daysNUD";
            this.daysNUD.Size = new System.Drawing.Size(136, 31);
            this.daysNUD.TabIndex = 9;
            this.daysNUD.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.daysNUD.Validating += new System.ComponentModel.CancelEventHandler(this.daysNUD_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Occ./Day:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.roomIdNUD, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.endTimeNUD, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.startTimeNUD, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.isDeleted, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(286, 370);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(276, 177);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // roomIdNUD
            // 
            this.roomIdNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomIdNUD.Location = new System.Drawing.Point(125, 71);
            this.roomIdNUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.roomIdNUD.Name = "roomIdNUD";
            this.roomIdNUD.Size = new System.Drawing.Size(136, 31);
            this.roomIdNUD.TabIndex = 12;
            this.roomIdNUD.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.roomIdNUD.Validating += new System.ComponentModel.CancelEventHandler(this.roomIdNUD_Validating);
            // 
            // endTimeNUD
            // 
            this.endTimeNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimeNUD.Location = new System.Drawing.Point(125, 37);
            this.endTimeNUD.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.endTimeNUD.Name = "endTimeNUD";
            this.endTimeNUD.Size = new System.Drawing.Size(136, 31);
            this.endTimeNUD.TabIndex = 11;
            this.endTimeNUD.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.endTimeNUD.Validating += new System.ComponentModel.CancelEventHandler(this.endTimeNUD_Validating);
            // 
            // startTimeNUD
            // 
            this.startTimeNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeNUD.Location = new System.Drawing.Point(125, 3);
            this.startTimeNUD.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.startTimeNUD.Name = "startTimeNUD";
            this.startTimeNUD.Size = new System.Drawing.Size(136, 31);
            this.startTimeNUD.TabIndex = 10;
            this.startTimeNUD.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.startTimeNUD.Validating += new System.ComponentModel.CancelEventHandler(this.startTimeNUD_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Room Id:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "End Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Start Time:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Inactive:";
            // 
            // isDeleted
            // 
            this.isDeleted.AutoSize = true;
            this.isDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isDeleted.Location = new System.Drawing.Point(125, 105);
            this.isDeleted.Name = "isDeleted";
            this.isDeleted.Size = new System.Drawing.Size(15, 14);
            this.isDeleted.TabIndex = 8;
            this.isDeleted.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(3, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(175, 31);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.saveButton);
            this.flowLayoutPanel1.Controls.Add(this.newButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(569, 370);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(178, 161);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(3, 40);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(175, 31);
            this.newButton.TabIndex = 7;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // nameErrorProvider
            // 
            this.nameErrorProvider.ContainerControl = this;
            // 
            // priceErrorProvider
            // 
            this.priceErrorProvider.ContainerControl = this;
            // 
            // numericUpDownErrorProvider
            // 
            this.numericUpDownErrorProvider.ContainerControl = this;
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.LV);
            this.Name = "Tickets";
            this.Size = new System.Drawing.Size(1000, 600);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.occPerDayNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.occNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNUD)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomIdNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endTimeNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startTimeNUD)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newTicketNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newTicketPriceTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox isDeleted;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.ErrorProvider nameErrorProvider;
        private System.Windows.Forms.ErrorProvider priceErrorProvider;
        private System.Windows.Forms.NumericUpDown occPerDayNUD;
        private System.Windows.Forms.NumericUpDown occNUD;
        private System.Windows.Forms.NumericUpDown daysNUD;
        private System.Windows.Forms.NumericUpDown roomIdNUD;
        private System.Windows.Forms.NumericUpDown endTimeNUD;
        private System.Windows.Forms.NumericUpDown startTimeNUD;
        private System.Windows.Forms.ErrorProvider numericUpDownErrorProvider;
    }
}
