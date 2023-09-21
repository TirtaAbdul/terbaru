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
    public partial class InsertAdmin : Form
    {
        public InsertAdmin()
        {
            InitializeComponent();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            if (txt_idm.Text == "" || txtsecm.Text == "" || txtsecnamem.Text == "" || txtgrupm.Text == "" || txtcatm.Text == "" || totalm.Text == "")
            {
                MessageBox.Show("DATA MASIH KOSONG!");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO [ProjectHR-02].[dbo].[tbl_mp] (useridmp,code_section,code_name,period,grup_name,mp_total,name_category) " +
                        "VALUES ('" + txt_idm.Text + "','" + txtsecm.Text + "','" + txtsecnamem.Text + "','" + dtm.Value.Date + "','" + txtgrupm.Text + "','" + totalm.Text + "','" + txtcatm.Text + "')";

                    Function.EXEcuteQuery(query);
                    MessageBox.Show("Data berhasil ditambahkan");
                    //txtcatm.Text = "";
                    totalm.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dtm_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtcatm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void totalm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgrupm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsecnamem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsecm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_idm_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InsertAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
