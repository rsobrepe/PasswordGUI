namespace frmMain
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFirstRes = new System.Windows.Forms.Label();
            this.lblSecondRes = new System.Windows.Forms.Label();
            this.lblThirdRes = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.timerGuess = new System.Windows.Forms.Timer(this.components);
            this.pnlDenied = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.timerLbl = new System.Windows.Forms.Timer(this.components);
            this.pnlDenied.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.White;
            this.txtInput.Font = new System.Drawing.Font("Space Age", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(691, 285);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 18);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Space Age", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(686, 236);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(412, 28);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Enter Password";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFirstRes
            // 
            this.lblFirstRes.AutoSize = true;
            this.lblFirstRes.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstRes.Font = new System.Drawing.Font("Space Age", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFirstRes.Location = new System.Drawing.Point(674, 327);
            this.lblFirstRes.Name = "lblFirstRes";
            this.lblFirstRes.Size = new System.Drawing.Size(87, 14);
            this.lblFirstRes.TabIndex = 2;
            this.lblFirstRes.Text = "label1";
            // 
            // lblSecondRes
            // 
            this.lblSecondRes.AutoSize = true;
            this.lblSecondRes.BackColor = System.Drawing.Color.Transparent;
            this.lblSecondRes.Font = new System.Drawing.Font("Space Age", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSecondRes.Location = new System.Drawing.Point(674, 371);
            this.lblSecondRes.Name = "lblSecondRes";
            this.lblSecondRes.Size = new System.Drawing.Size(96, 14);
            this.lblSecondRes.TabIndex = 3;
            this.lblSecondRes.Text = "label2";
            // 
            // lblThirdRes
            // 
            this.lblThirdRes.AutoSize = true;
            this.lblThirdRes.BackColor = System.Drawing.Color.Transparent;
            this.lblThirdRes.Font = new System.Drawing.Font("Space Age", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblThirdRes.Location = new System.Drawing.Point(674, 408);
            this.lblThirdRes.Name = "lblThirdRes";
            this.lblThirdRes.Size = new System.Drawing.Size(96, 14);
            this.lblThirdRes.TabIndex = 4;
            this.lblThirdRes.Text = "label3";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Space Age", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(805, 282);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // timerGuess
            // 
            this.timerGuess.Interval = 1500;
            //this.timerGuess.Tick += new System.EventHandler(this.timerGuess_Tick);
            // 
            // pnlDenied
            // 
            this.pnlDenied.BackColor = System.Drawing.Color.Transparent;
            this.pnlDenied.BackgroundImage = global::frmMain.Properties.Resources.AccessDeniedMsg;
            this.pnlDenied.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlDenied.Controls.Add(this.btnClose);
            this.pnlDenied.Location = new System.Drawing.Point(569, 135);
            this.pnlDenied.Name = "pnlDenied";
            this.pnlDenied.Size = new System.Drawing.Size(359, 370);
            this.pnlDenied.TabIndex = 6;
            this.pnlDenied.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::frmMain.Properties.Resources.icons8_close_window_24;
            this.btnClose.Location = new System.Drawing.Point(12, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timerLbl
            // 
            this.timerLbl.Interval = 7000;
      //      this.timerLbl.Tick += new System.EventHandler(this.timerLbl_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frmMain.Properties.Resources.PasswordBkgrnd1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 609);
            this.Controls.Add(this.pnlDenied);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblThirdRes);
            this.Controls.Add(this.lblSecondRes);
            this.Controls.Add(this.lblFirstRes);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtInput);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlDenied.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFirstRes;
        private System.Windows.Forms.Label lblSecondRes;
        private System.Windows.Forms.Label lblThirdRes;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Timer timerGuess;
        private System.Windows.Forms.Panel pnlDenied;
        private System.Windows.Forms.Timer timerLbl;
        private System.Windows.Forms.PictureBox btnClose;
    }
}

