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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManPowerSystem.Pages
{
    public partial class OverTime : Form
    {
        public OverTime()
        {
            InitializeComponent();
            Function.CreateConn();
        }

        private void src_Click(object sender, EventArgs e)
        {
            ExecuteSearchQuery3();

        }

        DataTable dt = new DataTable();
        private void ExecuteSearchQuery3()
        {
            string query = "EXEC [dbo].[userovertime_ResultManPowerAll] @startDate = N'" + dt1.Value + "', @endDate = N'" + dt2.Value + "'";
            dt = Function.GetDataTable(query);
            dgvot.AutoGenerateColumns = true;
            dgvot.DataSource = dt;
            dgvot.Columns[0].HeaderText = "Grup";
            dgvot.Columns[1].HeaderText = "Grup";
            dgvot.Columns[2].HeaderText = "Nama Section";
            dgvot.Columns[3].HeaderText = "Total Overtime";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void OverTime_Load(object sender, EventArgs e)
        {

        }

        private void dgvot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvot.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dgvot.Columns.Count)
            {
                DataGridViewCell cell = dgvot.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string cellValue = cell.Value != null ? cell.Value.ToString() : "";
                total.Text = cellValue;


                //string qr = "SELECT code_name FROM tbl_overtime WHERE mp_overtime = '" + cellValue.ToString() + "'";
                string qrr = "SELECT id_overtime FROM tbl_overtime WHERE mp_overtime = '" + cellValue.ToString() + "'";

                id.Text = Function.EXEScalar(qrr);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(id.Text) && dgvot.SelectedCells.Count == 1) // Memastikan hanya satu sel yang dipilih
            {
                try
                {


                    DataGridViewCell selectedCell = dgvot.SelectedCells[0];
                    int rowIndex = selectedCell.RowIndex;
                    int columnIndex = selectedCell.ColumnIndex;
                    string newValue = id.Text;
                    dgvot.Rows[rowIndex].Cells[columnIndex].Value = newValue;

                    string qr = "UPDATE tbl_overtime SET mp_overtime = '" + newValue.ToString() + "' WHERE id_overtime = '" + total.Text + "'";
                    Function.EXEScalar(qr);
                    MessageBox.Show("Data berhasil diperbaharui");
                    dgvot.Refresh();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(total.Text) && dgvot.SelectedCells.Count == 1) // Memastikan hanya satu sel yang dipilih
            {
                try
                {


                    DataGridViewCell selectedCell = dgvot.SelectedCells[0];
                    int rowIndex = selectedCell.RowIndex;
                    int columnIndex = selectedCell.ColumnIndex;
                    string newValue = total.Text;
                    dgvot.Rows[rowIndex].Cells[columnIndex].Value = newValue;

                    string qr = "UPDATE tbl_overtime SET mp_overtime = '" + newValue.ToString() + "' WHERE id_overtime = '" + id.Text + "'";
                    Function.EXEScalar(qr);
                    MessageBox.Show("Data berhasil diperbaharui");
                    dgvot.Refresh();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(total.Text) && dgvot.SelectedCells.Count == 1) // Memastikan hanya satu sel yang dipilih
            {
                if (total.Text == "")
                {
                    MessageBox.Show("DATA MASIH KOSONG!");
                }
                {
                    try
                    {


                        DataGridViewCell selectedCell = dgvot.SelectedCells[0];
                        int rowIndex = selectedCell.RowIndex;
                        int columnIndex = selectedCell.ColumnIndex;
                        string newValue = total.Text;
                        dgvot.Rows[rowIndex].Cells[columnIndex].Value = newValue;

                        string qr = "DELETE FROM tbl_overtime where mp_overtime = '" + newValue.ToString() + "' AND id_overtime = '" + id.Text + "'";
                        Function.EXEScalar(qr);
                        MessageBox.Show("Data berhasil dihapus");
                        dgvot.Refresh();
                    }

                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }

                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InsertOvertimeAdmin cn = new InsertOvertimeAdmin();
            cn.ShowDialog();
        }

        //public void ShowNoSection()
        //{
        //    string qr = "SELECT code_section FROM [ProjectHR-02].[dbo].[tbl_mp] WHERE mp_overtime = '" + totalot.Text + "'";
        //    txtsec.Text = Function.EXEScalar(qr);
        //}
    }
}
