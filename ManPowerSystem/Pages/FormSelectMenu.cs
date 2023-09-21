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
    public partial class FormSelectMenu : Form
    {
        public FormSelectMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminFormKW cn = new AdminFormKW();
            cn.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OverTime cn = new OverTime();
            cn.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
