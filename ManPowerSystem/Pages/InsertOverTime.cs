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
    public partial class InsertOverTime : Form
    {
        public string stdot { get; set; }
        public string stdot1 { get; set; }
        public string stdot2 { get; set; }
        public string stdot3 { get; set; }
        public string stdot4 { get; set; }
        public InsertOverTime()
        {
            InitializeComponent();
        }

        private void InsertOverTime_Load(object sender, EventArgs e)
        {
            txt_id2.Text = stdot;
            txtsec2.Text = stdot1;
            txtsecname2.Text = stdot2;
            txtgrup2.Text = stdot3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_id2.Text == "" || txtsec2.Text == "" || txtsecname2.Text == "" || txtgrup2.Text == "" || total2.Text == "")
            {
                MessageBox.Show("DATA MASIH KOSONG!");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO [ProjectHR-02].[dbo].[tbl_overtime] (userid_overtime,code_section,code_name,period,grup_name,mp_overtime) " +
                        "VALUES ('" + txt_id2.Text + "','" + txtsec2.Text + "','" + txtsecname2.Text + "','" + dt2.Value + "','" + txtgrup2.Text + "','" + total2.Text + "')";

                    Function.EXEcuteQuery(query);
                    MessageBox.Show("Data berhasil ditambahkan");
                    total2.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void total2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
    }
}
