using ManPowerSystem.Classes;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ManPowerSystem.Pages
{
    public partial class AdminFormKW : Form
    {
        public string userid { get; set; }
        public string stdname { get; set; }
        public string stdpassword { get; set; }
        public string stdar { get; set; }
        public string txt_user { get; set; }
        public string HeaderText { get; set; }

        public string CellType { get; set; }
        public AdminFormKW()
        {
            InitializeComponent();
            Function.CreateConn();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ShowID()
        {
            //string qr = "SELECT user_id FROM [ProjectHR-02].[dbo].[tbl_login] WHERE username = '" + stdname + "'";
            //txtid1.Text = Function.EXEScalar(qr);
        }
 
        public void ShowGroup()
        {
            //string qr = "SELECT grup FROM [ProjectHR-02].[dbo].[tbl_login] WHERE username = '" + stdname + "'";
            //txtgrup.Text = Function.EXEScalar(qr);
        }
        public void ShowNoSection()
        {
            //string qr = "SELECT no_section FROM [ProjectHR-02].[dbo].[tbl_login] WHERE username = '" + stdname + "'";
            //txtsec1.Text = Function.EXEScalar(qr);
        }
        public void ShowSectionName()
        {
            //string qr = "SELECT section FROM [ProjectHR-02].[dbo].[tbl_login] WHERE username = '" + stdname + "'";
            //txtsecname.Text = Function.EXEScalar(qr);
        }
        public void ShowID2()
        {
            //string qr = "SELECT id_mp FROM [ProjectHR-02].[dbo].[tbl_mp] WHERE username = '" + stdname + "'";
            ////tbid.Text = Function.EXEScalar(qr);
        }
      
        private void AdminForm_Load(object sender, EventArgs e)
        {
            
            
            ShowSectionName();
            ShowNoSection();
            ShowGroup();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        DataTable dt = new DataTable();
        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (cmb.Text == "All")
                ExecuteSearchQuery2();
            else if (cmb.Text == "ADM")
                ExecuteSearchQuery();
            else if (cmb.Text == "ICC")
                ExecuteSearchQuery();
            else if (cmb.Text == "DCC")
                ExecuteSearchQuery();
            else if (cmb.Text == "")
                ExecuteSearchQuery2();

        }

  

        private void ExecuteSearchQuery2()
        {
            string query = "EXEC [dbo].[hrd_ResultManPowerAll] @startDate = N'" + dtp1.Value + "', @endDate = N'" + dtp2.Value + "'";
            dt = Function.GetDataTable(query);
            dgv1.AutoGenerateColumns = true;
            dgv1.DataSource = dt;
            cmb.Text = "";
            dgv1.Columns[0].HeaderText = "Section";
            dgv1.Columns[1].HeaderText = "Grup";
            dgv1.Columns[2].HeaderText = "Kategori";
            dgv1.Columns[3].HeaderText = "Subtotal";

        }
        private void ExecuteSearchQuery()
        {
            string query = "EXEC [dbo].[hrd_ResultManPower] @startDate = N'" + dtp1.Value + "', @endDate = N'" + dtp2.Value + "', @select = N'" + cmb.Text + "'";
            dt = Function.GetDataTable(query);
            dgv1.AutoGenerateColumns = true;
            dgv1.DataSource = dt;
            cmb.Text = "";
            dgv1.Columns[0].HeaderText = "Section";
            dgv1.Columns[1].HeaderText = "Grup";
            dgv1.Columns[2].HeaderText = "Kategori";
            dgv1.Columns[3].HeaderText = "Subtotal";
        }
        int Index;

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv1.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dgv1.Columns.Count)
            {
                try
                {

                
                DataGridViewCell cell = dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string cellValue = cell.Value != null ? cell.Value.ToString() : "";
                total.Text = cellValue;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Pilih yang benar!"+Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Loop through selected cells in the DataGridView
            foreach (DataGridViewCell cell in dgv1.SelectedCells)
            {
                if (dgv1.DataSource is DataTable dataTable)
                {
                    int rowIndex = cell.RowIndex;
                    int columnIndex = cell.ColumnIndex;
                    dataTable.Rows[rowIndex][columnIndex] = string.Empty; // Set the value to null or empty, depending on the data type
                    string deleteQuery = $"DELETE FROM tbl_mp WHERE id_mp = @";
                    Function.EXEcuteQuery(deleteQuery);
                    dgv1.Refresh();
                }
            }
        }


        private void btnadm_Click(object sender, EventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dtp1.Value = DateTime.Now;
            dtp2.Value = DateTime.Now;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //dgv1.DataSource = Clear;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(total.Text) && dgv1.SelectedCells.Count == 1) // Memastikan hanya satu sel yang dipilih
            {
                try
                {


                    DataGridViewCell selectedCell = dgv1.SelectedCells[0];
                    int rowIndex = selectedCell.RowIndex;
                    int columnIndex = selectedCell.ColumnIndex;
                    string newValue = total.Text;
                    dgv1.Rows[rowIndex].Cells[columnIndex].Value = newValue;

                    string qr = "UPDATE tbl_mp SET mp_total = '" + newValue.ToString() + "' WHERE id_mp = '" + id.Text + "'";
                    Function.EXEScalar(qr);
                    MessageBox.Show("Data berhasil diperbaharui");
                    dgv1.Refresh();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void dgv1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv1.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dgv1.Columns.Count)
            {
                DataGridViewCell cell = dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string cellValue = cell.Value != null ? cell.Value.ToString() : "";
                total.Text = cellValue;

                string qr = "SELECT id_mp FROM tbl_mp WHERE mp_total = '" + cellValue.ToString() + "'";
                id.Text = Function.EXEScalar(qr);

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void total_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            InsertAdmin cn = new InsertAdmin();
            
            cn.ShowDialog();
      
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(total.Text) && dgv1.SelectedCells.Count == 1) // Memastikan hanya satu sel yang dipilih
            {
                if (total.Text == "")
                {
                    MessageBox.Show("DATA MASIH KOSONG!");
                }
                {
                    try
                    {


                        DataGridViewCell selectedCell = dgv1.SelectedCells[0];
                        int rowIndex = selectedCell.RowIndex;
                        int columnIndex = selectedCell.ColumnIndex;
                        string newValue = total.Text;
                        dgv1.Rows[rowIndex].Cells[columnIndex].Value = newValue;

                        string qr = "DELETE FROM tbl_mp where mp_total = '" + newValue.ToString() + "' AND id_mp = '" + id.Text + "'";
                        Function.EXEScalar(qr);
                        MessageBox.Show("Data berhasil dihapus");
                        dgv1.Refresh();
                    }

                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }

                }

            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {

            string query = "EXEC [dbo].[hrd_ResultManPowerAll] @startDate = N'" + dtp1.Value + "', @endDate = N'" + dtp2.Value + "'";
            DataTable dt = Function.GetDataTable(query);

            // Create a new Excel package
            using (var package = new ExcelPackage())
            {
                // Add a worksheet to the package
                var worksheet = package.Workbook.Worksheets.Add("DataSheet");
                worksheet.Cells["A17"].LoadFromDataTable(dt, false);



                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = "Save Excel sheet";
                saveFileDialog1.Filter = "Excel files|*.xlsx|All files|*.*";
                saveFileDialog1.FileName = "Inspection_Result_by_Line Printed " + DateTime.Now.ToString("dd-MMMM-yyyy") + ".xlsx";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileInfo fi = new FileInfo(saveFileDialog1.FileName);
                        package.SaveAs(fi);
                        var proc = new Process();
                        proc.StartInfo = new ProcessStartInfo(saveFileDialog1.FileName);
                        proc.Start();
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            dtp1.Value = DateTime.Now;
            dtp2.Value = DateTime.Now;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MpOutForm cn = new MpOutForm();

            cn.ShowDialog();
        }
    }
}
