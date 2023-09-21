namespace ManPowerSystem.Pages
{
    partial class InsertAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dtm = new System.Windows.Forms.DateTimePicker();
            this.txtcatm = new System.Windows.Forms.ComboBox();
            this.totalm = new System.Windows.Forms.TextBox();
            this.txtgrupm = new System.Windows.Forms.TextBox();
            this.txtsecnamem = new System.Windows.Forms.TextBox();
            this.txtsecm = new System.Windows.Forms.TextBox();
            this.txt_idm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_admin = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 51);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // dtm
            // 
            this.dtm.CustomFormat = "MMMM yyyy";
            this.dtm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtm.Location = new System.Drawing.Point(133, 192);
            this.dtm.Name = "dtm";
            this.dtm.Size = new System.Drawing.Size(117, 20);
            this.dtm.TabIndex = 32;
            this.dtm.ValueChanged += new System.EventHandler(this.dtm_ValueChanged);
            // 
            // txtcatm
            // 
            this.txtcatm.FormattingEnabled = true;
            this.txtcatm.Items.AddRange(new object[] {
            "Employee",
            "Intern Production",
            "Intern Non Production",
            "Intern Polytechnic",
            "Apprentice\t"});
            this.txtcatm.Location = new System.Drawing.Point(133, 218);
            this.txtcatm.Name = "txtcatm";
            this.txtcatm.Size = new System.Drawing.Size(117, 21);
            this.txtcatm.TabIndex = 31;
            this.txtcatm.SelectedIndexChanged += new System.EventHandler(this.txtcatm_SelectedIndexChanged);
            // 
            // totalm
            // 
            this.totalm.Location = new System.Drawing.Point(133, 245);
            this.totalm.Name = "totalm";
            this.totalm.Size = new System.Drawing.Size(117, 20);
            this.totalm.TabIndex = 30;
            this.totalm.TextChanged += new System.EventHandler(this.totalm_TextChanged);
            // 
            // txtgrupm
            // 
            this.txtgrupm.Location = new System.Drawing.Point(133, 161);
            this.txtgrupm.Name = "txtgrupm";
            this.txtgrupm.Size = new System.Drawing.Size(117, 20);
            this.txtgrupm.TabIndex = 29;
            this.txtgrupm.TextChanged += new System.EventHandler(this.txtgrupm_TextChanged);
            // 
            // txtsecnamem
            // 
            this.txtsecnamem.Location = new System.Drawing.Point(133, 127);
            this.txtsecnamem.Name = "txtsecnamem";
            this.txtsecnamem.Size = new System.Drawing.Size(117, 20);
            this.txtsecnamem.TabIndex = 28;
            this.txtsecnamem.TextChanged += new System.EventHandler(this.txtsecnamem_TextChanged);
            // 
            // txtsecm
            // 
            this.txtsecm.Location = new System.Drawing.Point(133, 93);
            this.txtsecm.Name = "txtsecm";
            this.txtsecm.Size = new System.Drawing.Size(117, 20);
            this.txtsecm.TabIndex = 27;
            this.txtsecm.TextChanged += new System.EventHandler(this.txtsecm_TextChanged);
            // 
            // txt_idm
            // 
            this.txt_idm.Location = new System.Drawing.Point(133, 61);
            this.txt_idm.Name = "txt_idm";
            this.txt_idm.Size = new System.Drawing.Size(117, 20);
            this.txt_idm.TabIndex = 26;
            this.txt_idm.TextChanged += new System.EventHandler(this.txt_idm_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Total";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Category";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Period";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Grup";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Section Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Section";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin.Location = new System.Drawing.Point(239, 291);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(75, 23);
            this.btn_admin.TabIndex = 18;
            this.btn_admin.Text = "Add";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(10, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 26);
            this.label9.TabIndex = 19;
            this.label9.Text = "*Pastikan benar dalam mengisi ID, Nomor \r\nSection, dan Nama Section\r\n";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.listBox2);
            this.panel5.Location = new System.Drawing.Point(2, 325);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(323, 190);
            this.panel5.TabIndex = 37;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.Color.Red;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Items.AddRange(new object[] {
            "1. Masukkan data sesuai dengan kolom yang telah ",
            "disediakan",
            "2. Pastikan data sudah sesuai ",
            "3. Klik tombol insert untuk memasukkan data",
            "4. Akan muncul pemberitahuan apabila data ",
            "berhasil dimasukkan",
            "4. Jika ingin memunculkan data ",
            "yang telah dimasukkan, tekan kembali tombol ",
            "search dengan rentang waktu yang diinginkan"});
            this.listBox2.Location = new System.Drawing.Point(8, 5);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(308, 180);
            this.listBox2.TabIndex = 0;
            // 
            // InsertAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 525);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtm);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.txtcatm);
            this.Controls.Add(this.totalm);
            this.Controls.Add(this.txtgrupm);
            this.Controls.Add(this.txtsecnamem);
            this.Controls.Add(this.txtsecm);
            this.Controls.Add(this.txt_idm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsertAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Manpower Budget";
            this.Load += new System.EventHandler(this.InsertAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtm;
        private System.Windows.Forms.ComboBox txtcatm;
        private System.Windows.Forms.TextBox totalm;
        private System.Windows.Forms.TextBox txtgrupm;
        private System.Windows.Forms.TextBox txtsecnamem;
        private System.Windows.Forms.TextBox txtsecm;
        private System.Windows.Forms.TextBox txt_idm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox listBox2;
    }
}