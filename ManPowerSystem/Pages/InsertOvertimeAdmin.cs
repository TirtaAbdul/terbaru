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
    public partial class InsertOvertimeAdmin : Form
    {
        public InsertOvertimeAdmin()
        {
            InitializeComponent();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            if (txt_idm.Text == "" || txtsecm.Text == "" || txtsecnamem.Text == "" || txtgrupm.Text == "" || totalm.Text == "")
            {
                MessageBox.Show("DATA MASIH KOSONG!");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO [ProjectHR-02].[dbo].[tbl_overtime] (userid_overtime,code_section,code_name,period,grup_name,mp_overtime " +
                        "VALUES ('" + txt_idm.Text + "','" + txtsecm.Text + "','" + txtsecnamem.Text + "','" + dtm.Value.Date + "','" + txtgrupm.Text + "','" + totalm.Text + "',')";

                    Function.EXEcuteQuery(query);
                    MessageBox.Show("Data berhasil ditambahkan");
                    
                    totalm.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void InsertOvertimeAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void totalm_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalm_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
            {
                btn_admin_Click(this, new EventArgs());
            }
        }
    }
}
