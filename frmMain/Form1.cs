using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;

/**
 * Class that handles User input as well as result output
 * */
namespace frmMain
{
    public partial class Form1 : Form
    {
        //Set Variables
        private String pass = "race";   
        private frmScnd second;
        private Form4 bg;      
        private string input = "";                  

        public Form1()
        {
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            second = new frmScnd(this);                       
            bg = new Form4();

            
           
            lblFirstRes.Visible = false;
            lblSecondRes.Visible = false;
            lblThirdRes.Visible = false;
        }
     


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //After Enter Button is Clicked
        private void btnEnter_Click(object sender, EventArgs e)
        {

                lblOff();
                btnEnter.Enabled = false;
                input = txtInput.Text.ToLower();
                guess(input);            

                //Sets text for corresponding guess result
                lblFirstRes.Text = firstLine(input);
                lblSecondRes.Text = scndLine(input);
                lblThirdRes.Text = thirdLine(input);
                lblFirstRes.Visible = true;
                lblSecondRes.Visible = true;
                lblThirdRes.Visible = true;
                txtInput.Text = "";


        }

        
        // Guess method that takes user input and outputs 3 hints for user to see                   
        private void guess(String input)
        {
            //Admin password to exit program  
            if (input == "peg2admin//")
                Application.Exit();

            if (pass.Equals(input))
            {                          
                bg.Visible = true;
                second.Visible = true;
                this.Visible = false;
                lblFirstRes.Visible = false;
                lblSecondRes.Visible = false;
                lblThirdRes.Visible = false;
            }

            else
            {              
                btnEnter.Enabled = false;
                pnlDenied.Show();               
            }           
        }

        //Handles the output for the first line, if guess is too long or too short
        private String firstLine(String input)
        {
            if (input.Length > pass.Length)
                return "Incorrect, password entered is too long";
            else if (input.Length < pass.Length)
                return "Incorrect, password entered is too short";
            else
                return "Incorrect";
        }

        //handles the  output for second line, how many letters are in the correct place
        private String scndLine(String input)
        {
            int crrct = 0;

            if (input.Length > pass.Length)
            {
                for (int i = 0; i < pass.Length; i++)
                {
                    if (pass[i] == input[i])
                        crrct++;
                }
            }

            if(pass.Length >= input.Length)
            {

                for(int i = 0; i< input.Length; i++)
                {
                    if (pass[i] == input[i])
                        crrct++; 
                }
            }

            if (crrct == 1)
                return "You have " + crrct + " letter in the right place";
            else if (crrct == 0)
                return "You have no letters in the right place";
            else
                return "You have " + crrct + " letters in the right place";
                             
        }

        //handles the output for the third line, how many letters are correct
        private String thirdLine(String input)
        {
            input = input.ToLower();
            int crrct = 0;

            for(int i = 0; i < pass.Length; i++)
            {
                if (input.Contains(pass[i]))
                    crrct++;
            }

            if (crrct == 0)
                return "You have no letters correct";
            else if(crrct == 1)
                return "You have "+crrct+" letter correct";
            else
                return "You have " + crrct + " letters correct";

        }

        //Method for setting all text labels and hiding them
        public void lblOff()
        {
            lblFirstRes.Visible = false;
            lblSecondRes.Visible = false;
            lblThirdRes.Visible = false;

        }

        private void showPanel(object sender, KeyEventArgs e)
        {

            pnlDenied.Show();
            if(e.KeyCode == Keys.Enter)
            {
                pnlDenied.Hide();
            }
        }
      

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            btnEnter.Enabled = true;
            
        }

        private void btnPanel_Click(object sender, EventArgs e)
        {
            pnlDenied.Hide();            
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
         
            pnlDenied.Hide();
            txtInput.Select();
            btnEnter.Enabled = true;
        }
    }
}
    