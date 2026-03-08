namespace Student_Utility_System
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            disptxt = new TextBox();
            utxt = new TextBox();
            ptxt = new TextBox();
            loginbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // disptxt
            // 
            disptxt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            disptxt.Location = new Point(84, 36);
            disptxt.Name = "disptxt";
            disptxt.Size = new Size(637, 47);
            disptxt.TabIndex = 0;
            disptxt.Text = "Login ";
            disptxt.TextAlign = HorizontalAlignment.Center;
            // 
            // utxt
            // 
            utxt.Location = new Point(419, 124);
            utxt.Name = "utxt";
            utxt.Size = new Size(214, 27);
            utxt.TabIndex = 1;
            // 
            // ptxt
            // 
            ptxt.Location = new Point(419, 194);
            ptxt.Name = "ptxt";
            ptxt.Size = new Size(214, 27);
            ptxt.TabIndex = 2;
            // 
            // loginbtn
            // 
            loginbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            loginbtn.Location = new Point(371, 269);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(111, 41);
            loginbtn.TabIndex = 3;
            loginbtn.Text = "Log-In";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(312, 127);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(312, 201);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 344);
            label3.Name = "label3";
            label3.Size = new Size(168, 20);
            label3.TabIndex = 6;
            label3.Text = "Don't Have an Account?";
            label3.Click += label3_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(469, 344);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(89, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registration";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 178, 191);
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginbtn);
            Controls.Add(ptxt);
            Controls.Add(utxt);
            Controls.Add(disptxt);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox disptxt;
        private TextBox utxt;
        private TextBox ptxt;
        private Button loginbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}
