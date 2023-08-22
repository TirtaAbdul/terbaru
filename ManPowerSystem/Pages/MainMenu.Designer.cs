namespace ManPowerSystem.Pages
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_secname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtperiod = new System.Windows.Forms.DateTimePicker();
            this.total = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_select = new System.Windows.Forms.Label();
            this.txt_nosection = new System.Windows.Forms.TextBox();
            this.txt_grup = new System.Windows.Forms.TextBox();
            this.lbl_grup = new System.Windows.Forms.Label();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this._ProjectHR_02DataSet = new ManPowerSystem._ProjectHR_02DataSet();
            this.tblmpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_mpTableAdapter = new ManPowerSystem._ProjectHR_02DataSetTableAdapters.tbl_mpTableAdapter();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ProjectHR_02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv2
            // 
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2.BackgroundColor = System.Drawing.Color.White;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(12, 190);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersVisible = false;
            this.dgv2.Size = new System.Drawing.Size(740, 405);
            this.dgv2.TabIndex = 1;
            this.dgv2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellClick);
            this.dgv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "MANPOWER BUDGET FORM";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_id.Location = new System.Drawing.Point(12, 611);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(26, 20);
            this.lbl_id.TabIndex = 3;
            this.lbl_id.Text = "ID";
            this.lbl_id.Click += new System.EventHandler(this.lbl_id_Click);
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(126, 613);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(58, 20);
            this.txt_id.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 646);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Section";
            // 
            // txt_secname
            // 
            this.txt_secname.Enabled = false;
            this.txt_secname.Location = new System.Drawing.Point(126, 683);
            this.txt_secname.Name = "txt_secname";
            this.txt_secname.Size = new System.Drawing.Size(129, 20);
            this.txt_secname.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(11, 681);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Section Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(278, 650);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Period";
            // 
            // dtperiod
            // 
            this.dtperiod.AccessibleName = "MMMM-yyyy";
            this.dtperiod.CustomFormat = "MMMM-yyyy";
            this.dtperiod.Location = new System.Drawing.Point(355, 650);
            this.dtperiod.Name = "dtperiod";
            this.dtperiod.Size = new System.Drawing.Size(184, 20);
            this.dtperiod.TabIndex = 10;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.total.Location = new System.Drawing.Point(279, 683);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(44, 20);
            this.total.TabIndex = 11;
            this.total.Text = "Total";
            this.total.Click += new System.EventHandler(this.total_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(276, 611);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Category";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(355, 685);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(97, 20);
            this.txt_total.TabIndex = 14;
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.LightGreen;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_add.Location = new System.Drawing.Point(758, 489);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(213, 50);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Insert";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.LightCoral;
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Location = new System.Drawing.Point(759, 545);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(213, 50);
            this.btn_del.TabIndex = 16;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 88);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dt2);
            this.panel2.Controls.Add(this.dt1);
            this.panel2.Controls.Add(this.lbl_select);
            this.panel2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Location = new System.Drawing.Point(3, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 77);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_search.Location = new System.Drawing.Point(507, 42);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 28;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(266, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "To";
            // 
            // dt2
            // 
            this.dt2.CustomFormat = "MMMM-yyyy";
            this.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt2.Location = new System.Drawing.Point(301, 43);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(200, 20);
            this.dt2.TabIndex = 25;
            // 
            // dt1
            // 
            this.dt1.CustomFormat = "MMMM-yyyy";
            this.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt1.Location = new System.Drawing.Point(58, 42);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(200, 20);
            this.dt1.TabIndex = 24;
            // 
            // lbl_select
            // 
            this.lbl_select.AutoSize = true;
            this.lbl_select.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_select.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_select.Location = new System.Drawing.Point(5, 16);
            this.lbl_select.Name = "lbl_select";
            this.lbl_select.Size = new System.Drawing.Size(68, 20);
            this.lbl_select.TabIndex = 23;
            this.lbl_select.Text = "Search: ";
            // 
            // txt_nosection
            // 
            this.txt_nosection.Enabled = false;
            this.txt_nosection.Location = new System.Drawing.Point(126, 648);
            this.txt_nosection.Name = "txt_nosection";
            this.txt_nosection.ReadOnly = true;
            this.txt_nosection.Size = new System.Drawing.Size(58, 20);
            this.txt_nosection.TabIndex = 22;
            // 
            // txt_grup
            // 
            this.txt_grup.Enabled = false;
            this.txt_grup.Location = new System.Drawing.Point(126, 709);
            this.txt_grup.Name = "txt_grup";
            this.txt_grup.ReadOnly = true;
            this.txt_grup.Size = new System.Drawing.Size(67, 20);
            this.txt_grup.TabIndex = 21;
            this.txt_grup.TextChanged += new System.EventHandler(this.txt_grup_TextChanged);
            // 
            // lbl_grup
            // 
            this.lbl_grup.AutoSize = true;
            this.lbl_grup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_grup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_grup.Location = new System.Drawing.Point(14, 705);
            this.lbl_grup.Name = "lbl_grup";
            this.lbl_grup.Size = new System.Drawing.Size(54, 20);
            this.lbl_grup.TabIndex = 20;
            this.lbl_grup.Text = "Group";
            this.lbl_grup.Click += new System.EventHandler(this.lbl_grup_Click);
            // 
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Items.AddRange(new object[] {
            "Employee",
            "Students Production",
            "Students Non Production",
            "Intern Polytechnic",
            "Apprentice\t"});
            this.cmb_category.Location = new System.Drawing.Point(355, 613);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(167, 21);
            this.cmb_category.TabIndex = 18;
            // 
            // _ProjectHR_02DataSet
            // 
            this._ProjectHR_02DataSet.DataSetName = "_ProjectHR_02DataSet";
            this._ProjectHR_02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmpBindingSource
            // 
            this.tblmpBindingSource.DataMember = "tbl_mp";
            this.tblmpBindingSource.DataSource = this._ProjectHR_02DataSet;
            // 
            // tbl_mpTableAdapter
            // 
            this.tbl_mpTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = global::ManPowerSystem.Properties.Resources.social_media_removebg_preview;
            this.pictureBox4.Location = new System.Drawing.Point(914, 555);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::ManPowerSystem.Properties.Resources.add_user;
            this.pictureBox3.Location = new System.Drawing.Point(915, 497);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.DoubleClick += new System.EventHandler(this.pictureBox3_DoubleClick);
            // 
            // mainForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(988, 739);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_nosection);
            this.Controls.Add(this.txt_grup);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.lbl_grup);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.total);
            this.Controls.Add(this.dtperiod);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_secname);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ProjectHR_02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_secname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtperiod;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.TextBox txt_grup;
        private System.Windows.Forms.Label lbl_grup;
        private System.Windows.Forms.TextBox txt_nosection;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private _ProjectHR_02DataSet _ProjectHR_02DataSet;
        private System.Windows.Forms.BindingSource tblmpBindingSource;
        private _ProjectHR_02DataSetTableAdapters.tbl_mpTableAdapter tbl_mpTableAdapter;
        private System.Windows.Forms.Label lbl_select;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt2;
        private System.Windows.Forms.DateTimePicker dt1;
        private System.Windows.Forms.Button btn_search;
    }
}