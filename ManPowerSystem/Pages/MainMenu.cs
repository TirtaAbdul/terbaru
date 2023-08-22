using ManPowerSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ManPowerSystem.Pages;
using System.Data.SqlClient;

namespace ManPowerSystem.Pages
{
    public partial class mainForm : Form
    {
        public string userid { get; set; }
        public string stdname { get; set; }
        public string stdpassword { get; set; }
        public string stdar { get; set; }
        public string txt_user { get; set; }
        public string HeaderText { get; set; }

        public string CellType { get; set; }

        public mainForm()
        {
            InitializeComponent();
            Function.CreateConn();
            //cmb2.DataSource = Function.GetDataTable("select code  FROM [ProjectHR-02].[dbo].[tbl_section]");
            //cmb2.DisplayMember = "code";
            //cmb2.ValueMember = "code";
            
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        
        private void mainForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_ProjectHR_02DataSet.tbl_mp' table. You can move, or remove it, as needed.
            this.tbl_mpTableAdapter.Fill(this._ProjectHR_02DataSet.tbl_mp);
            //ShowData berfungsi untuk menampilkan data masing-masing manpower
            ShowData();
            ShowID2();
            ShowID();
            ShowSectionName();
            ShowNoSection();
            ShowGroup();
        }
       DataTable dt = new DataTable();
        int index;
        //Memasukkan dan mengeluarkan nilai dari nama section pada form sesuai dengan inputan login
        public void ShowSectionName()
        {
            string qr = "SELECT section FROM [ProjectHR-02].[dbo].[tbl_login] WHERE username = '" + stdname + "'";
            txt_secname.Text = Function.EXEScalar(qr);
        }
        //Memasukkan dan mengeluarkan nilai dari grup pada form sesuai dengan inputan login
        public void ShowGroup()
        {
            string qr = "SELECT grup FROM [ProjectHR-02].[dbo].[tbl_login] WHERE username = '" + stdname + "'";
            txt_grup.Text = Function.EXEScalar(qr);
        }
        //Memasukkan dan mengeluarkan nilai dari nomor section pada form sesuai dengan inputan login
        public void ShowNoSection()
        {
            string qr = "SELECT no_section FROM [ProjectHR-02].[dbo].[tbl_login] WHERE username = '" + stdname + "'";
            txt_nosection.Text = Function.EXEScalar(qr);
        }
        //Memasukkan dan mengeluarkan nilai dari ID pada form sesuai dengan inputan login
        public void ShowID()
        {
            string qr = "SELECT user_id FROM [ProjectHR-02].[dbo].[tbl_login] WHERE username = '" + stdname + "'";
            txt_id.Text = Function.EXEScalar(qr);
        }
        public void ShowID2()
        {
            string qr = "SELECT id_mp FROM [ProjectHR-02].[dbo].[tbl_mp] WHERE username = '" + stdname + "'";
            //tbid.Text = Function.EXEScalar(qr);
        }
        public void ShowData()
        {
            //string qr = "select [useridmp],[code_section],[code_name],[grup_name],[period],[name_category],[mp_total] FROM [ProjectHR-02].[dbo].[tbl_mp] WHERE useridmp ='" + txt_id.Text + "' ";
            string qr = "select [name_category],[mp_total],[period] FROM [ProjectHR-02].[dbo].[tbl_mp] WHERE useridmp ='"+txt_id.Text+"' ";
            dt = Function.GetDataTable(qr);
            dgv2.AutoGenerateColumns = true;
            dgv2.DataSource = dt;
            dgv2.Columns[0].HeaderText = "Category";
            dgv2.Columns[1].HeaderText = "Total";
            dgv2.Columns[2].HeaderText = "Periode";
           
        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //index = e.RowIndex;
            //DataGridViewRow row = dgv2.Rows[index];
            //txt_secname.Text = dgv2.SelectedRows[0].Cells[0].Value.ToString();
            //txt_grup.Text = dgv2.SelectedRows[0].Cells[1].Value.ToString();
            //cmb_category.Text = dgv2.SelectedRows[0].Cells[2].Value.ToString();
            //txt_total.Text = dgv2.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmb2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "" || txt_nosection.Text == "" || txt_secname.Text == "" || txt_grup.Text == "" || cmb_category.Text == "" || txt_total.Text == "")
            {
                MessageBox.Show("DATA MASIH KOSONG!");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO [ProjectHR-02].[dbo].[tbl_mp] (useridmp,code_section,code_name,period,grup_name,mp_total,name_category) " +
                        "VALUES ('" + txt_id.Text + "','" + txt_nosection.Text + "','" + txt_secname.Text + "','" + dtperiod.Value + "','" + txt_grup.Text + "','" + txt_total.Text + "','" + cmb_category.Text + "')";

                    Function.EXEcuteQuery(query);
                    MessageBox.Show("Data berhasil ditambahkan");
                    cmb_category.Text = "";
                    txt_total.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void dgv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv2.Rows.Count)
            {
                index = e.RowIndex;
                DataGridViewRow row = dgv2.Rows[index];
                cmb_category.Text = row.Cells[0].Value.ToString();
                total.Text = row.Cells[1].Value.ToString();
                dtperiod.Text = row.Cells[2].Value.ToString();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            if (txt_id.Text == "" || txt_nosection.Text == "" || txt_secname.Text == "" || txt_grup.Text == "" || cmb_category.Text == "" || txt_total.Text == "")
            {
                MessageBox.Show("DATA MASIH KOSONG!");
            }
            else
            {
                try
                {
                    //string datef = dtperiod.Value.ToString("MMMM");
                    //DateTime frm = Convert.ToDateTime(datef);
                    string query = "INSERT INTO [ProjectHR-02].[dbo].[tbl_mp] (useridmp,code_section,code_name,period,grup_name,mp_total,name_category) " +
                        "VALUES ('" + txt_id.Text + "','" + txt_nosection.Text + "','" + txt_secname.Text + "','" + dtperiod.Value.Date + "','" + txt_grup.Text + "','" + txt_total.Text + "','" + cmb_category.Text + "')";
                    //SqlCommand cmd = new SqlCommand(query);
                    /*cmd.Parameters.AddWithValue("@code_section", cmbgrup.DataBindings.Add)*/
                    //cmd.Parameters.AddWithValue("@id_mp", txt_id.Text);
                    //cmd.Parameters.AddWithValue("@code_section", txt_nosection.Text);
                    //cmd.Parameters.AddWithValue("@period", dtperiod.Text);
                    //cmd.Parameters.AddWithValue("@mp_total", cmb_category.Text);
                    //cmd.Parameters.AddWithValue("@id_mp", txt_total.Text);
                    //cmd.ExecuteNonQuery();
                    Function.EXEcuteQuery(query);
                    MessageBox.Show("Data berhasil ditambahkan");
                    cmb_category.Text = "";
                    txt_total.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_grup_Click(object sender, EventArgs e)
        {

        }

        private void txt_grup_TextChanged(object sender, EventArgs e)
        {

        }

        private void total_Click(object sender, EventArgs e)
        {

        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = "select [name_category],[mp_total],[period] FROM [ProjectHR-02].[dbo].[tbl_mp] where period BETWEEN '" + dt1.Value.Date + "' AND '" + dt2.Value + "'";
            Function.EXEcuteQuery(query);
            dt = Function.GetDataTable(query);
            dgv2.AutoGenerateColumns = true;
            dgv2.DataSource = dt;
            dgv2.Columns[0].HeaderText = "Category";
            dgv2.Columns[1].HeaderText = "Total";
            dgv2.Columns[2].HeaderText = "Period";
            dgv2.Columns[2].DefaultCellStyle.Format = "MMMM-yyyy";

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            //string qr = "delete  [ProjectHR-02].[dbo].[tbl_mp] where id = 
            index = dgv2.CurrentCell.RowIndex;
            dgv2.Rows.RemoveAt(index);
        }
    }
}

