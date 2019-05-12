using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * Handles the third form of Software
 * */
namespace frmMain
{
    public partial class thirdFrm : Form
    {
        Form1 form;
        frmScnd second; 
        public thirdFrm(Form1 frm, frmScnd scnd)
        {
            this.DoubleBuffered = true;
            form = frm;
            second = scnd;
            this.Visible = false; 
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void thirdFrm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            second.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            form.lblOff();
            this.Visible = false;
            second.Visible = false;
            form.Visible = true;
        }
    }
}
