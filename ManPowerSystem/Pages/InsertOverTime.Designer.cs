namespace ManPowerSystem.Pages
{
    partial class InsertOverTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertOverTime));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.total2 = new System.Windows.Forms.TextBox();
            this.txtgrup2 = new System.Windows.Forms.TextBox();
            this.txtsecname2 = new System.Windows.Forms.TextBox();
            this.txtsec2 = new System.Windows.Forms.TextBox();
            this.txt_id2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 51);
            this.panel1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Insert Overtime Budget Form";
            // 
            // dt2
            // 
            this.dt2.CustomFormat = "MMMM yyyy";
            this.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt2.Location = new System.Drawing.Point(108, 200);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(117, 20);
            this.dt2.TabIndex = 4;
            // 
            // total2
            // 
            this.total2.Location = new System.Drawing.Point(108, 230);
            this.total2.Name = "total2";
            this.total2.Size = new System.Drawing.Size(117, 20);
            this.total2.TabIndex = 5;
            this.total2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.total2_KeyDown);
            // 
            // txtgrup2
            // 
            this.txtgrup2.Enabled = false;
            this.txtgrup2.Location = new System.Drawing.Point(108, 169);
            this.txtgrup2.Name = "txtgrup2";
            this.txtgrup2.ReadOnly = true;
            this.txtgrup2.Size = new System.Drawing.Size(117, 20);
            this.txtgrup2.TabIndex = 3;
            // 
            // txtsecname2
            // 
            this.txtsecname2.Enabled = false;
            this.txtsecname2.Location = new System.Drawing.Point(108, 135);
            this.txtsecname2.Name = "txtsecname2";
            this.txtsecname2.ReadOnly = true;
            this.txtsecname2.Size = new System.Drawing.Size(117, 20);
            this.txtsecname2.TabIndex = 2;
            // 
            // txtsec2
            // 
            this.txtsec2.Enabled = false;
            this.txtsec2.Location = new System.Drawing.Point(108, 101);
            this.txtsec2.Name = "txtsec2";
            this.txtsec2.ReadOnly = true;
            this.txtsec2.Size = new System.Drawing.Size(117, 20);
            this.txtsec2.TabIndex = 1;
            // 
            // txt_id2
            // 
            this.txt_id2.Enabled = false;
            this.txt_id2.Location = new System.Drawing.Point(108, 69);
            this.txt_id2.Name = "txt_id2";
            this.txt_id2.ReadOnly = true;
            this.txt_id2.Size = new System.Drawing.Size(117, 20);
            this.txt_id2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Period";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Grup";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Section Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Section";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(208, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InsertOverTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dt2);
            this.Controls.Add(this.total2);
            this.Controls.Add(this.txtgrup2);
            this.Controls.Add(this.txtsecname2);
            this.Controls.Add(this.txtsec2);
            this.Controls.Add(this.txt_id2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsertOverTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Overtime";
            this.Load += new System.EventHandler(this.InsertOverTime_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dt2;
        private System.Windows.Forms.TextBox total2;
        private System.Windows.Forms.TextBox txtgrup2;
        private System.Windows.Forms.TextBox txtsecname2;
        private System.Windows.Forms.TextBox txtsec2;
        private System.Windows.Forms.TextBox txt_id2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}