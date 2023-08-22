using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManPowerSystem.Classes;
namespace ManPowerSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Function.CreateConn();


        }
        DataTable dt = new DataTable();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowData();
        }
        public void ShowData()
        {
            string qr = "select * FROM [ProjectHR-02].[dbo].[tbl_section]";
            dt = Function.GetDataTable(qr);
            dgv1.AutoGenerateColumns = true;
            dgv1.DataSource = dt;
        }
    }
}
