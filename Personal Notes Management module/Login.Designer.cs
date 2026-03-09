namespace Personal_Notes_Management_module
{
    partial class Login
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
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            loginbtn = new Button();
            label2 = new Label();
            label1 = new Label();
            ptxt = new TextBox();
            utxt = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(142, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(801, 47);
            textBox1.TabIndex = 0;
            textBox1.Text = "Login";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(587, 395);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(89, 20);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registration";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(398, 395);
            label3.Name = "label3";
            label3.Size = new Size(168, 20);
            label3.TabIndex = 15;
            label3.Text = "Don't Have an Account?";
            // 
            // loginbtn
            // 
            loginbtn.Location = new Point(493, 316);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(117, 43);
            loginbtn.TabIndex = 14;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 236);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 13;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(371, 150);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 12;
            label1.Text = "Username";
            // 
            // ptxt
            // 
            ptxt.Location = new Point(480, 229);
            ptxt.Name = "ptxt";
            ptxt.Size = new Size(232, 27);
            ptxt.TabIndex = 11;
            // 
            // utxt
            // 
            utxt.Location = new Point(480, 150);
            utxt.Name = "utxt";
            utxt.Size = new Size(232, 27);
            utxt.TabIndex = 10;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 532);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(loginbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ptxt);
            Controls.Add(utxt);
            Controls.Add(textBox1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private LinkLabel linkLabel1;
        private Label label3;
        private Button loginbtn;
        private Label label2;
        private Label label1;
        private TextBox ptxt;
        private TextBox utxt;
    }
}