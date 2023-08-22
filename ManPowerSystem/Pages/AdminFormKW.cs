using ManPowerSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManPowerSystem.Pages
{
    public partial class AdminFormKW : Form
    {
        public string userid { get; set; }
        public string stdname { get; set; }
        public string stdpassword { get; set; }
        public string stdar { get; set; }
        public string txt_user { get; set; }
        public string HeaderText { get; set; }

        public string CellType { get; set; }
        public AdminFormKW()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        DataTable dt = new DataTable();
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string query = "select * FROM [ProjectHR-02].[dbo].[tbl_mp] where period BETWEEN '" + dtp1.Value.Date + "' AND '" + dtp2.Value.Date + "'";
            Function.EXEcuteQuery(query);
            dt = Function.GetDataTable(query);
            dgv1.AutoGenerateColumns = true;
            dgv1.DataSource = dt;
            dgv1.Columns[0].HeaderText = "Section Name";
            dgv1.Columns[1].HeaderText = "Grup";
            dgv1.Columns[2].HeaderText = "Category";
            dgv1.Columns[3].HeaderText = "Total";
            dgv1.Columns[4].HeaderText = "Period";
        }
    }
}
