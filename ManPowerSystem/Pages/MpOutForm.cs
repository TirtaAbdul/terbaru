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
    public partial class MpOutForm : Form
    {
        public MpOutForm()
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
                    string query = "INSERT INTO [ProjectHR-02].[dbo].[tbl_out] (userid_out,code_section,code_name,period,grup_name,mp_out,name_category) " +
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
    }
}
