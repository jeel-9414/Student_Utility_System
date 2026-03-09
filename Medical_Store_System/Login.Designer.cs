namespace Medical_Store_System
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
            utxt = new TextBox();
            ptxt = new TextBox();
            logbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(171, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(526, 47);
            textBox1.TabIndex = 0;
            textBox1.Text = "Login";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // utxt
            // 
            utxt.Location = new Point(421, 116);
            utxt.Name = "utxt";
            utxt.Size = new Size(229, 27);
            utxt.TabIndex = 1;
            // 
            // ptxt
            // 
            ptxt.Location = new Point(421, 199);
            ptxt.Name = "ptxt";
            ptxt.Size = new Size(229, 27);
            ptxt.TabIndex = 2;
            // 
            // logbtn
            // 
            logbtn.Location = new Point(332, 269);
            logbtn.Name = "logbtn";
            logbtn.Size = new Size(107, 35);
            logbtn.TabIndex = 3;
            logbtn.Text = "Login";
            logbtn.UseVisualStyleBackColor = true;
            logbtn.Click += logbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(271, 119);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 202);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 339);
            label3.Name = "label3";
            label3.Size = new Size(168, 20);
            label3.TabIndex = 6;
            label3.Text = "Don't Have an Account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(445, 339);
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
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(logbtn);
            Controls.Add(ptxt);
            Controls.Add(utxt);
            Controls.Add(textBox1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox utxt;
        private TextBox ptxt;
        private Button logbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}