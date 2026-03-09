namespace Medical_Store_System
{
    partial class Registration
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
            textBox1 = new TextBox();
            utxt = new TextBox();
            ptxt = new TextBox();
            cptxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            regbtn = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(191, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(438, 47);
            textBox1.TabIndex = 0;
            textBox1.Text = "Registration";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // utxt
            // 
            utxt.Location = new Point(428, 113);
            utxt.Name = "utxt";
            utxt.Size = new Size(201, 27);
            utxt.TabIndex = 1;
            utxt.TextChanged += textBox2_TextChanged;
            // 
            // ptxt
            // 
            ptxt.Location = new Point(428, 184);
            ptxt.Name = "ptxt";
            ptxt.Size = new Size(201, 27);
            ptxt.TabIndex = 2;
            // 
            // cptxt
            // 
            cptxt.Location = new Point(428, 254);
            cptxt.Name = "cptxt";
            cptxt.Size = new Size(201, 27);
            cptxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 113);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 191);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 261);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 6;
            label3.Text = "Confirm Password";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(449, 379);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(46, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 379);
            label4.Name = "label4";
            label4.Size = new Size(183, 20);
            label4.TabIndex = 8;
            label4.Text = "Already Have an Account?";
            label4.Click += label4_Click;
            // 
            // regbtn
            // 
            regbtn.Location = new Point(327, 317);
            regbtn.Name = "regbtn";
            regbtn.Size = new Size(104, 39);
            regbtn.TabIndex = 9;
            regbtn.Text = "Register";
            regbtn.UseVisualStyleBackColor = true;
            regbtn.Click += regbtn_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(regbtn);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cptxt);
            Controls.Add(ptxt);
            Controls.Add(utxt);
            Controls.Add(textBox1);
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
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
        private LinkLabel linkLabel1;
        private Label label4;
        private Button regbtn;
    }
}
