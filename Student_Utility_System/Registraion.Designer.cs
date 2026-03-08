namespace Student_Utility_System
{
    partial class Registraion
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
            textBox1 = new TextBox();
            utxt = new TextBox();
            ptxt = new TextBox();
            cptxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            regbtn = new Button();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(314, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(481, 47);
            textBox1.TabIndex = 0;
            textBox1.Text = "Registration";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // utxt
            // 
            utxt.Location = new Point(563, 154);
            utxt.Name = "utxt";
            utxt.Size = new Size(200, 27);
            utxt.TabIndex = 1;
            // 
            // ptxt
            // 
            ptxt.Location = new Point(563, 231);
            ptxt.Name = "ptxt";
            ptxt.Size = new Size(200, 27);
            ptxt.TabIndex = 2;
            // 
            // cptxt
            // 
            cptxt.Location = new Point(563, 306);
            cptxt.Name = "cptxt";
            cptxt.Size = new Size(200, 27);
            cptxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(413, 153);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 234);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 313);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 6;
            label3.Text = "Confirm Password";
            // 
            // regbtn
            // 
            regbtn.Location = new Point(473, 381);
            regbtn.Name = "regbtn";
            regbtn.Size = new Size(118, 46);
            regbtn.TabIndex = 7;
            regbtn.Text = "Registration";
            regbtn.UseVisualStyleBackColor = true;
            regbtn.Click += regbtn_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(602, 446);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(46, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(413, 446);
            label4.Name = "label4";
            label4.Size = new Size(183, 20);
            label4.TabIndex = 9;
            label4.Text = "Already Have an Account?";
            // 
            // Registraion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 643);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(regbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cptxt);
            Controls.Add(ptxt);
            Controls.Add(utxt);
            Controls.Add(textBox1);
            Name = "Registraion";
            Text = "Registraion";
            Load += Registraion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox utxt;
        private TextBox ptxt;
        private TextBox cptxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button regbtn;
        private LinkLabel linkLabel1;
        private Label label4;
    }
}