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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Function.CreateConn();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
                public void check()
                {
                     if (!string.IsNullOrWhiteSpace(user.Text) && !string.IsNullOrWhiteSpace(password.Text))
                    {
                        string str = "SELECT username, password, role,section";
                        str = str + " FROM [ProjectHR-02].[dbo].[tbl_login]";
                        str = str + " WHERE username='" + user.Text.Trim() + "' AND password ='" + password.Text.Trim() + "' ";
                        DataSet ds = Function.GetDataSet(str);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            DataRow drs = ds.Tables[0].Rows[0];
                                if (drs["role"].ToString() == "A")     
                         {
                            FormSelectMenu cn = new FormSelectMenu();
                            //cn.stdname = user.Text;
                            //string uid = drs["username"].ToString();
                            //cn.txt_user = uid;
                            //Function.userid = uid.Trim();


                            //cn.pass = user.Text;
                            //cn.lblUser.Text = drs["userid"].ToString();
                            //cn.section = drs["AccessCtrl"].ToString();
                            //cn.lblUserType.Text = drs["AccessCtrl"].ToString();
                            //cn.pass = user.Text;
                            //update();
                            this.Hide();
                            cn.ShowDialog();
                            this.Close();
                    }
                    else
                    {
                        mainForm cn = new mainForm();
                        cn.stdname = user.Text;
                        string uid = drs["section"].ToString();
                        cn.lb_user.Text = uid;
                        Function.userid = uid.Trim();


                        //cn.pass = user.Text;
                        //cn.lblUser.Text = drs["userid"].ToString();
                        //cn.section = drs["AccessCtrl"].ToString();
                        //cn.lblUserType.Text = drs["AccessCtrl"].ToString();
                        //cn.pass = user.Text;
                        //update();
                        this.Hide();
                        cn.ShowDialog();
                        this.Close();
                    }
                           
                        }
                        else
                        {
                            user.Focus();
                            lb_wrong.Visible = true;
                            password.Text = string.Empty;
                            password.Focus();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Fill All First!");
                    }
                }

      
        private void btn_lg_Click(object sender, EventArgs e)
        {
            check();
        }

        private void pn_login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_rst_Click(object sender, EventArgs e)
        {
            user.Text = "";
            password.Text = "";
            user.Focus();
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_lg_Click(this, new EventArgs());
            }
        }

        private void user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_lg_Click(this, new EventArgs());
                user.Text = "";
            }
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
