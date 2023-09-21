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
using System.Linq;



namespace ManPowerSystem.Pages
{
    public partial class mainForm : Form
    {
        public string stdname { get; set; }
        public string stdot { get; set; }
        public string stdot1 { get; set; }
        public string stdot2 { get; set; }
        public string stdot3 { get; set; }
        public string stdot4 { get; set; }
        public string userid { get; set; }





        public string CellType { get; set; }

        public mainForm()
        {
            InitializeComponent();
            Function.CreateConn();
 
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
            //string qr = "select [name_category],[mp_total],[period] FROM [ProjectHR-02].[dbo].[tbl_mp] WHERE useridmp ='"+txt_id.Text+"' ";
            //dt = Function.GetDataTable(qr);
            //dgv2.AutoGenerateColumns = true;
            //dgv2.DataSource = dt;
            //dgv2.Columns[0].HeaderText = "Category";
            //dgv2.Columns[1].HeaderText = "Total";

            //dgv2.EnableHeadersVisualStyles = false;
            //dgv2.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            //dgv2.Columns[0].HeaderCell.Style.BackColor = Color.Magenta;
            //dgv2.Columns[1].HeaderCell.Style.BackColor = Color.Yellow;


        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            //if (txt_id.Text == "" || txt_nosection.Text == "" || txt_secname.Text == "" || txt_grup.Text == "" || cmb_category.Text == "" || txt_total.Text == "")
            //{
            //    MessageBox.Show("DATA MASIH KOSONG!");
            //}
            //else
            //{
            //    try
            //    {
            //        string query = "INSERT INTO [ProjectHR-02].[dbo].[tbl_mp] (useridmp,code_section,code_name,period,grup_name,mp_total,name_category) " +
            //            "VALUES ('" + txt_id.Text + "','" + txt_nosection.Text + "','" + txt_secname.Text + "','" + dtperiod.Value + "','" + txt_grup.Text + "','" + txt_total.Text + "','" + cmb_category.Text + "')";

            //        Function.EXEcuteQuery(query);
            //        MessageBox.Show("Data berhasil ditambahkan");
            //        cmb_category.Text = "";
            //        txt_total.Text = "";
            //    }
            //    catch (Exception Ex)
            //    {
            //        MessageBox.Show(Ex.Message);
            //    }
            //}
            Insert_Form cn = new Insert_Form();
            cn.Stdid = txt_id.Text;
            cn.Stdsec = txt_nosection.Text;
            cn.Stdsecname = txt_secname.Text;
            cn.Stdgrup = txt_grup.Text;
            cn.ShowDialog();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void dgv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv2.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dgv2.Columns.Count)
            {
                try
                {
                    DataGridViewCell cell = dgv2.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    string cellValue = cell.Value != null ? cell.Value.ToString() : "";
                    txt_total.Text = cellValue;

                    string qr = "SELECT id_mp FROM tbl_mp WHERE mp_total = '" + cellValue.ToString() + "'";
                    string qrr = "SELECT name_category FROM tbl_mp WHERE mp_total = '" + cellValue.ToString() + "'";
                    cmb_category.Text = Function.EXEScalar(qrr);
                    id.Text = Function.EXEScalar(qr);

                }
                catch (Exception ex)
                {
                    // Tangani exception umum
                    Console.WriteLine("Jangan kesini!!!" + ex.Message);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
           
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
            ExecuteSearchQuery();
        }
        private void ExecuteSearchQuery()
        {
            string query = "EXEC [dbo].[user_ResultManPower] @startDate = N'" + dt1.Value + "', @endDate = N'" + dt2.Value + "', @user = '" + txt_id.Text + "'";
            dt = Function.GetDataTable(query);
            dgv2.AutoGenerateColumns = true;
            dgv2.DataSource = dt;
            dgv2.Columns[0].HeaderText = "Grup";
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        
        private void button1_Click_2(object sender, EventArgs e)
        {
            OverTimeForm cn = new OverTimeForm();
            cn.stdtxtid = txt_id.Text;
            cn.stdsecid = txt_nosection.Text;
            cn.stdsec   = txt_secname.Text;
            cn.stdgrup  = txt_grup.Text;
            
            cn.ShowDialog();
    
        }

        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_total.Text) && dgv2.SelectedCells.Count == 1) // Memastikan hanya satu sel yang dipilih
            {
                if (cmb_category.Text == "" || txt_total.Text == "")
                {
                    MessageBox.Show("DATA MASIH KOSONG!");
                }
                {
                    try
                    {


                        DataGridViewCell selectedCell = dgv2.SelectedCells[0];
                        int rowIndex = selectedCell.RowIndex;
                        int columnIndex = selectedCell.ColumnIndex;
                        string newValue = txt_total.Text;
                        dgv2.Rows[rowIndex].Cells[columnIndex].Value = newValue;

                        string qr = "UPDATE tbl_mp SET mp_total = '" + newValue.ToString() + "' WHERE id_mp = '" + id.Text + "'";
                        Function.EXEScalar(qr);
                        MessageBox.Show("Data berhasil diperbaharui");
                        dgv2.Refresh();
                    }

                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }

                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dt1.Value = DateTime.Now;
            dt2.Value = DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgv2.DataSource = Clear;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dtperiod_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_total.Text) && dgv2.SelectedCells.Count == 1) // Memastikan hanya satu sel yang dipilih
            {
                if (cmb_category.Text == "" || txt_total.Text == "")
                {
                    MessageBox.Show("DATA MASIH KOSONG!");
                }
                {
                    try
                    {


                        DataGridViewCell selectedCell = dgv2.SelectedCells[0];
                        int rowIndex = selectedCell.RowIndex;
                        int columnIndex = selectedCell.ColumnIndex;
                        string newValue = txt_total.Text;
                        dgv2.Rows[rowIndex].Cells[columnIndex].Value = newValue;

                        string qr = "DELETE FROM tbl_mp where mp_total = '" + newValue.ToString() + "' AND id_mp = '" + id.Text + "'";
                        Function.EXEScalar(qr);
                        MessageBox.Show("Data berhasil dihapus");
                        dgv2.Refresh();
                    }

                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }

                }

            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


