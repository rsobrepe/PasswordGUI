using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Handles the Second form for the program
 * */
namespace frmMain
{
    public partial class frmScnd : Form
    {
        Form1 form;
        thirdFrm thirdForm;
        public frmScnd(Form1 frm)
        {
            this.DoubleBuffered = true;
            form = frm;
            thirdForm = new thirdFrm(frm, this);
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void frmScnd_Load(object sender, EventArgs e)
        {

        }   

        private void label1_Click(object sender, EventArgs e)
        {
            form.lblOff();
            form.Visible = true;
            this.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            thirdForm.Show();
            this.Hide();
        }
    }
}
