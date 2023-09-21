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
            this.total = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_select = new System.Windows.Forms.Label();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.TextBox();
            this.id_mp = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nosection = new System.Windows.Forms.TextBox();
            this.txt_secname = new System.Windows.Forms.TextBox();
            this.txt_grup = new System.Windows.Forms.TextBox();
            this._ProjectHR_02DataSet = new ManPowerSystem._ProjectHR_02DataSet();
            this.tblmpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_mpTableAdapter = new ManPowerSystem._ProjectHR_02DataSetTableAdapters.tbl_mpTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ProjectHR_02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmpBindingSource)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv2
            // 
            this.dgv2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2.BackgroundColor = System.Drawing.Color.White;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(3, 190);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersVisible = false;
            this.dgv2.Size = new System.Drawing.Size(1252, 405);
            this.dgv2.TabIndex = 1;
            this.dgv2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellClick);
            this.dgv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "MANPOWER BUDGET FORM";
            // 
            // total
            // 
            this.total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.total.AutoSize = true;
            this.total.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.total.Location = new System.Drawing.Point(11, 63);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(148, 20);
            this.total.TabIndex = 11;
            this.total.Text = "Update Manpower :";
            this.total.Click += new System.EventHandler(this.total_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(12, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Category :";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_total
            // 
            this.txt_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_total.Location = new System.Drawing.Point(157, 65);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 14;
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_add.Location = new System.Drawing.Point(1263, 597);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(266, 50);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Insert MP Budget";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1528, 77);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = global::ManPowerSystem.Properties.Resources.social_care;
            this.pictureBox1.Location = new System.Drawing.Point(480, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dt2);
            this.panel2.Controls.Add(this.dt1);
            this.panel2.Controls.Add(this.lbl_select);
            this.panel2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Location = new System.Drawing.Point(3, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 76);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_search.Location = new System.Drawing.Point(438, 42);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(80, 28);
            this.btn_search.TabIndex = 28;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(5, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(234, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "To";
            // 
            // dt2
            // 
            this.dt2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt2.CustomFormat = "MMMM yyyy";
            this.dt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt2.Location = new System.Drawing.Point(267, 47);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(156, 20);
            this.dt2.TabIndex = 25;
            // 
            // dt1
            // 
            this.dt1.CustomFormat = "MMMM yyyy";
            this.dt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt1.Location = new System.Drawing.Point(68, 47);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(160, 20);
            this.dt1.TabIndex = 24;
            // 
            // lbl_select
            // 
            this.lbl_select.AutoSize = true;
            this.lbl_select.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_select.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_select.Location = new System.Drawing.Point(5, 16);
            this.lbl_select.Name = "lbl_select";
            this.lbl_select.Size = new System.Drawing.Size(68, 20);
            this.lbl_select.TabIndex = 23;
            this.lbl_select.Text = "Search: ";
            // 
            // cmb_category
            // 
            this.cmb_category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_category.Enabled = false;
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Items.AddRange(new object[] {
            "Employee",
            "Intern Production",
            "Intern Non Production",
            "Intern Polytechnic",
            "Apprentice"});
            this.cmb_category.Location = new System.Drawing.Point(157, 85);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(101, 21);
            this.cmb_category.TabIndex = 18;
            this.cmb_category.Visible = false;
            this.cmb_category.SelectedIndexChanged += new System.EventHandler(this.cmb_category_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(1263, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 50);
            this.button1.TabIndex = 23;
            this.button1.Text = "Overtime Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(17, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 36);
            this.button2.TabIndex = 26;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear.Location = new System.Drawing.Point(1450, 164);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 27;
            this.Clear.Text = "Clear Sheets";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(1363, 164);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "Refresh Date";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Controls.Add(this.id);
            this.panel4.Controls.Add(this.id_mp);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.txt_total);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.total);
            this.panel4.Controls.Add(this.cmb_category);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(1261, 190);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(266, 346);
            this.panel4.TabIndex = 30;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // id
            // 
            this.id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.id.Location = new System.Drawing.Point(143, 65);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 30;
            this.id.Visible = false;
            // 
            // id_mp
            // 
            this.id_mp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.id_mp.AutoSize = true;
            this.id_mp.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.id_mp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_mp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.id_mp.Location = new System.Drawing.Point(12, 63);
            this.id_mp.Name = "id_mp";
            this.id_mp.Size = new System.Drawing.Size(52, 20);
            this.id_mp.TabIndex = 29;
            this.id_mp.Text = "id_mp";
            this.id_mp.Visible = false;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(138, 112);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 36);
            this.button5.TabIndex = 28;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Location = new System.Drawing.Point(15, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 178);
            this.panel3.TabIndex = 27;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Red;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "1. Klik sel yang ingin diubah",
            "2. Masukkan jumlah terbaru pada ",
            "textbox Update Manpower",
            "3. Klik tombol update",
            "4. Selesai"});
            this.listBox1.Location = new System.Drawing.Point(3, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 166);
            this.listBox1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Info;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(262, 49);
            this.panel5.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "UPDATE DATA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 597);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Welcome,";
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.Location = new System.Drawing.Point(96, 598);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(61, 24);
            this.lb_user.TabIndex = 32;
            this.lb_user.Text = "USER";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(161, 601);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 33;
            this.txt_id.Visible = false;
            // 
            // txt_nosection
            // 
            this.txt_nosection.Location = new System.Drawing.Point(161, 601);
            this.txt_nosection.Name = "txt_nosection";
            this.txt_nosection.ReadOnly = true;
            this.txt_nosection.Size = new System.Drawing.Size(100, 20);
            this.txt_nosection.TabIndex = 34;
            this.txt_nosection.Visible = false;
            // 
            // txt_secname
            // 
            this.txt_secname.Location = new System.Drawing.Point(161, 601);
            this.txt_secname.Name = "txt_secname";
            this.txt_secname.ReadOnly = true;
            this.txt_secname.Size = new System.Drawing.Size(100, 20);
            this.txt_secname.TabIndex = 35;
            this.txt_secname.Visible = false;
            // 
            // txt_grup
            // 
            this.txt_grup.Location = new System.Drawing.Point(163, 601);
            this.txt_grup.Name = "txt_grup";
            this.txt_grup.ReadOnly = true;
            this.txt_grup.Size = new System.Drawing.Size(100, 20);
            this.txt_grup.TabIndex = 36;
            this.txt_grup.Visible = false;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-1, 673);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1117, 240);
            this.label8.TabIndex = 37;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(0, 638);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 24);
            this.label9.TabIndex = 38;
            this.label9.Text = "Tata Cara Penggunaan :";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PaleGreen;
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(351, 751);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(124, 22);
            this.panel6.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Insert MP Budget";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Yellow;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(721, 751);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(51, 22);
            this.panel7.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Update";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Red;
            this.panel8.Controls.Add(this.label11);
            this.panel8.Location = new System.Drawing.Point(875, 751);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(46, 22);
            this.panel8.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(3, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Delete";
            // 
            // mainForm
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1531, 1061);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_grup);
            this.Controls.Add(this.txt_secname);
            this.Controls.Add(this.txt_nosection);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manpower Budget Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ProjectHR_02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmpBindingSource)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb_category;
        private _ProjectHR_02DataSet _ProjectHR_02DataSet;
        private System.Windows.Forms.BindingSource tblmpBindingSource;
        private _ProjectHR_02DataSetTableAdapters.tbl_mpTableAdapter tbl_mpTableAdapter;
        private System.Windows.Forms.Label lbl_select;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt2;
        private System.Windows.Forms.DateTimePicker dt1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nosection;
        private System.Windows.Forms.TextBox txt_secname;
        private System.Windows.Forms.TextBox txt_grup;
        public System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label id_mp;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
    }
}