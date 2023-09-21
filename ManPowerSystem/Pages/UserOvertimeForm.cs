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
using static System.Net.WebRequestMethods;

namespace ManPowerSystem.Pages
{
    public partial class OverTimeForm : Form
    {
        public string stdname { get; set; }

        public string stdtxtid { get; set; }
        public string stdsecid { get; set; }
        public string stdsec { get; set; }
        public string stdgrup { get; set; }
        public string stdot { get; set; }
        public string stdot1 { get; set; }
        public string stdot2 { get; set; }
        public string stdot3 { get; set; }
        public string stdot4 { get; set; }


        public OverTimeForm()
        {
            InitializeComponent();
            Function.CreateConn();
        }
        public void ShowID()
        {
            string qr = "SELECT user_id FROM [ProjectHR-02].[dbo].[tbl_login] WHERE username = '" + stdname + "'";
            id_ot.Text = Function.EXEScalar(qr);
        }

        public void ShowGroup()
        {
            string qr = "SELECT grup FROM [ProjectHR-02].[dbo].[tbl_login] WHERE username = '" + stdname + "'";
            group_ot.Text = Function.EXEScalar(qr);
        }
        public void ShowNoSection()
        {
            string qr = "SELECT no_section FROM [ProjectHR-02].[dbo].[tbl_login] WHERE username = '" + stdname + "'";
            sec_ot.Text = Function.EXEScalar(qr);
        }
        public void ShowSectionName()
        {
            string qr = "SELECT section FROM [ProjectHR-02].[dbo].[tbl_login] WHERE username = '" + stdname + "'";
            secname_ot.Text = Function.EXEScalar(qr);
        }
        public void ShowID2()
        {
            string qr = "SELECT id_overtime FROM [ProjectHR-02].[dbo].[tbl_mp] WHERE username = '" + stdname + "'";
            //tbid.Text = Function.EXEScalar(qr);
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                //ShowID();
            //ShowGroup();
            //ShowNoSection();
            //ShowSectionName();
            id_ot.Text = stdtxtid;
            sec_ot.Text = stdsecid;
            secname_ot.Text = stdsec;
            group_ot.Text = stdgrup;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertOverTime cn = new InsertOverTime();
            cn.stdot = id_ot.Text;
            cn.stdot1 = sec_ot.Text;
            cn.stdot2 = secname_ot.Text;
            cn.stdot3 = group_ot.Text;

            cn.ShowDialog();

            //if (id_ot.Text == "" || sec_ot.Text == "" || secname_ot.Text == "" || group_ot.Text == "" || total_ot.Text == "")
            //{
            //    MessageBox.Show("DATA MASIH KOSONG!");
            //}
            //else
            //{
            //    try
            //    {
            //        string query = "INSERT INTO [ProjectHR-02].[dbo].[tbl_mp] (useridmp,code_section,code_name,period,grup_name,mp_overtime) " +
            //            "VALUES ('" + id_ot.Text + "','" + sec_ot.Text + "','" + secname_ot.Text + "','" + dt_ot.Value + "','" + group_ot.Text + "','" + total_ot.Text + "')";

            //        Function.EXEcuteQuery(query);
            //        MessageBox.Show("Data berhasil ditambahkan");
            //        total_ot.Text = "";
            //    }
            //    catch (Exception Ex)
            //    {
            //        MessageBox.Show(Ex.Message);
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExecuteSearchQuery();
            dgv3.Columns[0].HeaderText = "Nama Grup";
            dgv3.Columns[1].HeaderText = "Nama Grup";
            dgv3.Columns[2].HeaderText = "Nama Code";
            dgv3.Columns[3].HeaderText = "Subtotal overtime";
        }

        DataTable dt = new DataTable();

        private void ExecuteSearchQuery()
        {
            string query = "EXEC [dbo].[userovertime_ResultManPower] @startDate = N'" + dtp1.Value + "', @endDate = N'" + dtp2.Value + "', @select = N'" + group_ot.Text + "',@code = N'"+secname_ot.Text+"'";
            dt = Function.GetDataTable(query);
            dgv3.AutoGenerateColumns = true;
            dgv3.DataSource = dt;
            //dgv3.Columns[0].HeaderText = "Grup";
            //dgv3.Columns[1].HeaderText = "Nama Section";
            //dgv3.Columns[2].HeaderText = "Kategori";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(total_ot.Text) && dgv3.SelectedCells.Count == 1) // Memastikan hanya satu sel yang dipilih
            {
                if (txt_secname.Text == "" || total_ot.Text == "")
                {
                    MessageBox.Show("DATA MASIH KOSONG!");
                }
                {
                    try
                    {


                        DataGridViewCell selectedCell = dgv3.SelectedCells[0];
                        int rowIndex = selectedCell.RowIndex;
                        int columnIndex = selectedCell.ColumnIndex;
                        string newValue = total_ot.Text;
                        dgv3.Rows[rowIndex].Cells[columnIndex].Value = newValue;

                        string qr = "DELETE FROM tbl_overtime where mp_overtime = '" + newValue.ToString() + "' AND id_overtime = '" + textBox1.Text + "'";
                        Function.EXEScalar(qr);
                        MessageBox.Show("Data berhasil dihapus");
                        dgv3.Refresh();
                    }

                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }

                }

            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            dgv3.DataSource = Clear;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dtp1.Value = DateTime.Now;
            dtp2.Value = DateTime.Now;
        }


        private void update_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(total_ot.Text) && dgv3.SelectedCells.Count == 1) // Memastikan hanya satu sel yang dipilih
            {
                try
                {


                    DataGridViewCell selectedCell = dgv3.SelectedCells[0];
                    int rowIndex = selectedCell.RowIndex;
                    int columnIndex = selectedCell.ColumnIndex;
                    string newValue = total_ot.Text;
                    dgv3.Rows[rowIndex].Cells[columnIndex].Value = newValue;

                    string qr = "UPDATE tbl_overtime SET mp_overtime = '" + newValue.ToString() + "' WHERE id_overtime = '"+textBox1.Text+"'";
                    Function.EXEScalar(qr);
                    MessageBox.Show("Data berhasil diperbaharui");
                    dgv3.Refresh();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void dgv3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv3.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dgv3.Columns.Count)
            {
                DataGridViewCell cell = dgv3.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string cellValue = cell.Value != null ? cell.Value.ToString() : "";
                total_ot.Text = cellValue;

               string qr = "SELECT code_name FROM tbl_overtime WHERE mp_overtime = '" + cellValue.ToString() + "'";
               string qrr = "SELECT id_overtime FROM tbl_overtime WHERE mp_overtime = '" + cellValue.ToString() + "'";

               txt_secname.Text = Function.EXEScalar(qr);
               textBox1.Text = Function.EXEScalar(qrr);

            }
        }
    }
    }

        
    
    

