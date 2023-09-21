namespace ManPowerSystem.Pages
{
    partial class Insert_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insert_Form));
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtcat2 = new System.Windows.Forms.ComboBox();
            this.total2 = new System.Windows.Forms.TextBox();
            this.txtgrup2 = new System.Windows.Forms.TextBox();
            this.txtsecname2 = new System.Windows.Forms.TextBox();
            this.txtsec2 = new System.Windows.Forms.TextBox();
            this.txt_id2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(265, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Insert Manpower Budget Form";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 51);
            this.panel1.TabIndex = 17;
            // 
            // txtcat2
            // 
            this.txtcat2.FormattingEnabled = true;
            this.txtcat2.Items.AddRange(new object[] {
            "Employee",
            "Intern Production",
            "Intern Non Production",
            "Intern Polytechnic",
            "Apprentice\t"});
            this.txtcat2.Location = new System.Drawing.Point(131, 226);
            this.txtcat2.Name = "txtcat2";
            this.txtcat2.Size = new System.Drawing.Size(117, 21);
            this.txtcat2.TabIndex = 5;
            // 
            // total2
            // 
            this.total2.Location = new System.Drawing.Point(131, 253);
            this.total2.Name = "total2";
            this.total2.Size = new System.Drawing.Size(117, 20);
            this.total2.TabIndex = 6;
            this.total2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.total2_KeyDown);
            // 
            // txtgrup2
            // 
            this.txtgrup2.Enabled = false;
            this.txtgrup2.Location = new System.Drawing.Point(131, 169);
            this.txtgrup2.Name = "txtgrup2";
            this.txtgrup2.ReadOnly = true;
            this.txtgrup2.Size = new System.Drawing.Size(117, 20);
            this.txtgrup2.TabIndex = 3;
            // 
            // txtsecname2
            // 
            this.txtsecname2.Enabled = false;
            this.txtsecname2.Location = new System.Drawing.Point(131, 135);
            this.txtsecname2.Name = "txtsecname2";
            this.txtsecname2.ReadOnly = true;
            this.txtsecname2.Size = new System.Drawing.Size(117, 20);
            this.txtsecname2.TabIndex = 2;
            // 
            // txtsec2
            // 
            this.txtsec2.Enabled = false;
            this.txtsec2.Location = new System.Drawing.Point(131, 101);
            this.txtsec2.Name = "txtsec2";
            this.txtsec2.ReadOnly = true;
            this.txtsec2.Size = new System.Drawing.Size(117, 20);
            this.txtsec2.TabIndex = 1;
            // 
            // txt_id2
            // 
            this.txt_id2.Enabled = false;
            this.txt_id2.Location = new System.Drawing.Point(131, 69);
            this.txt_id2.Name = "txt_id2";
            this.txt_id2.ReadOnly = true;
            this.txt_id2.Size = new System.Drawing.Size(117, 20);
            this.txt_id2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Period";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grup";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Section Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Section";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // dt2
            // 
            this.dt2.CustomFormat = "MMMM yyyy";
            this.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt2.Location = new System.Drawing.Point(131, 200);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(117, 20);
            this.dt2.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(12, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "*Pastikan benar dalam memilih bulan";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(241, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Insert_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 332);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dt2);
            this.Controls.Add(this.txtcat2);
            this.Controls.Add(this.total2);
            this.Controls.Add(this.txtgrup2);
            this.Controls.Add(this.txtsecname2);
            this.Controls.Add(this.txtsec2);
            this.Controls.Add(this.txt_id2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Insert_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert_Form";
            this.Load += new System.EventHandler(this.Insert_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txtcat2;
        private System.Windows.Forms.TextBox total2;
        private System.Windows.Forms.TextBox txtgrup2;
        private System.Windows.Forms.TextBox txtsecname2;
        private System.Windows.Forms.TextBox txtsec2;
        private System.Windows.Forms.TextBox txt_id2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}