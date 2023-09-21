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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ManPowerSystem.Pages
{
    public partial class Insert_Form : Form
    {
        public string userid { get; set; }
        public string stdname { get; set; }
        public string stdpassword { get; set; }
        public string stdar { get; set; }
        public string txt_user { get; set; }
        public string HeaderText { get; set; }

        public string Stdid { get; set; }
        public string Stdsec { get; set; }
        public string Stdsecname { get; set; }
        public string Stdgrup { get; set; }
        public Insert_Form()
        {
            InitializeComponent();
            Function.CreateConn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_id2.Text == "" || txtsec2.Text == "" || txtsecname2.Text == "" || txtgrup2.Text == "" || txtcat2.Text == "" || total2.Text == "")
            {
                MessageBox.Show("DATA MASIH KOSONG!");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO [ProjectHR-02].[dbo].[tbl_mp] (useridmp,code_section,code_name,period,grup_name,mp_total,name_category) " +
                        "VALUES ('" + txt_id2.Text + "','" + txtsec2.Text + "','" + txtsecname2.Text + "','" + dt2.Value.Date + "','" + txtgrup2.Text + "','" + total2.Text + "','" + txtcat2.Text + "')";

                    Function.EXEcuteQuery(query);
                    MessageBox.Show("Data berhasil ditambahkan");
                    //txtcat2.Text = "";
                    total2.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Insert_Form_Load(object sender, EventArgs e)
        {
            ShowID();
            ShowSectionName();
            ShowNoSection();
            ShowGroup();
            txt_id2.Text = Stdid;
            txtsec2.Text = Stdsec;
            txtsecname2.Text = Stdsecname;
            txtgrup2.Text = Stdgrup;
        }

        public void ShowSectionName()
        {
            string qr = "SELECT section FROM [ProjectHR-02].[dbo].[tbl_login] WHERE username = '" + stdname + "'";
            txtsecname2.Text = Function.EXEScalar(qr);
        }
        //Memasukkan dan mengeluarkan nilai dari grup pada form sesuai dengan inputan login
        public void ShowGroup()
        {
            string qr = "SELECT grup FROM [ProjectHR-02].[dbo].[tbl_login] WHERE username = '" + stdname + "'";
            txtgrup2.Text = Function.EXEScalar(qr);
        }
        //Memasukkan dan mengeluarkan nilai dari nomor section pada form sesuai dengan inputan login
        public void ShowNoSection()
        {
            string qr = "SELECT no_section FROM [ProjectHR-02].[dbo].[tbl_login] WHERE username = '" + stdname + "'";
            txtsec2.Text = Function.EXEScalar(qr);
        }
        //Memasukkan dan mengeluarkan nilai dari ID pada form sesuai dengan inputan login
        public void ShowID()
        {
            string qr = "SELECT user_id FROM [ProjectHR-02].[dbo].[tbl_login] WHERE username = '" + stdname + "'";
            txt_id2.Text = Function.EXEScalar(qr);
        }

        private void label9_Click(object sender, EventArgs e)
        {

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
