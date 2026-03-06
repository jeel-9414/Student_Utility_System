namespace Student_Utility_System
{
    partial class Student
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
            disptxt = new TextBox();
            nametxt = new TextBox();
            emailtxt = new TextBox();
            malerb = new RadioButton();
            femalerb = new RadioButton();
            dob = new DateTimePicker();
            city = new ComboBox();
            phonenotxt = new TextBox();
            profpic = new PictureBox();
            agetxt = new TextBox();
            gendergb = new GroupBox();
            savebtn = new Button();
            dispbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)profpic).BeginInit();
            gendergb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // disptxt
            // 
            disptxt.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            disptxt.Location = new Point(214, 29);
            disptxt.Name = "disptxt";
            disptxt.Size = new Size(537, 47);
            disptxt.TabIndex = 0;
            disptxt.Text = "Student Dashboard";
            disptxt.TextAlign = HorizontalAlignment.Center;
            // 
            // nametxt
            // 
            nametxt.Location = new Point(214, 131);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(250, 27);
            nametxt.TabIndex = 1;
            // 
            // emailtxt
            // 
            emailtxt.Location = new Point(214, 189);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(250, 27);
            emailtxt.TabIndex = 2;
            // 
            // malerb
            // 
            malerb.AutoSize = true;
            malerb.Location = new Point(90, 26);
            malerb.Name = "malerb";
            malerb.Size = new Size(63, 24);
            malerb.TabIndex = 3;
            malerb.TabStop = true;
            malerb.Text = "Male";
            malerb.UseVisualStyleBackColor = true;
            // 
            // femalerb
            // 
            femalerb.AutoSize = true;
            femalerb.Location = new Point(209, 26);
            femalerb.Name = "femalerb";
            femalerb.Size = new Size(78, 24);
            femalerb.TabIndex = 4;
            femalerb.TabStop = true;
            femalerb.Text = "Female";
            femalerb.UseVisualStyleBackColor = true;
            // 
            // dob
            // 
            dob.Location = new Point(214, 258);
            dob.Name = "dob";
            dob.Size = new Size(250, 27);
            dob.TabIndex = 5;
            // 
            // city
            // 
            city.FormattingEnabled = true;
            city.Location = new Point(214, 315);
            city.Name = "city";
            city.Size = new Size(250, 28);
            city.TabIndex = 6;
            // 
            // phonenotxt
            // 
            phonenotxt.Location = new Point(659, 280);
            phonenotxt.Name = "phonenotxt";
            phonenotxt.Size = new Size(168, 27);
            phonenotxt.TabIndex = 7;
            // 
            // profpic
            // 
            profpic.Location = new Point(659, 105);
            profpic.Name = "profpic";
            profpic.Size = new Size(168, 143);
            profpic.TabIndex = 8;
            profpic.TabStop = false;
            // 
            // agetxt
            // 
            agetxt.Location = new Point(659, 337);
            agetxt.Name = "agetxt";
            agetxt.Size = new Size(168, 27);
            agetxt.TabIndex = 9;
            // 
            // gendergb
            // 
            gendergb.Controls.Add(malerb);
            gendergb.Controls.Add(femalerb);
            gendergb.Location = new Point(124, 369);
            gendergb.Name = "gendergb";
            gendergb.Size = new Size(340, 68);
            gendergb.TabIndex = 10;
            gendergb.TabStop = false;
            gendergb.Text = "Gender";
            // 
            // savebtn
            // 
            savebtn.Location = new Point(577, 400);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(118, 37);
            savebtn.TabIndex = 11;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            // 
            // dispbtn
            // 
            dispbtn.Location = new Point(781, 400);
            dispbtn.Name = "dispbtn";
            dispbtn.Size = new Size(112, 37);
            dispbtn.TabIndex = 12;
            dispbtn.Text = "Display";
            dispbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 135);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 13;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 192);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 14;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 258);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 15;
            label3.Text = "DOB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 323);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 16;
            label4.Text = "City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(552, 134);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 17;
            label5.Text = "Profile Pic";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(552, 283);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 18;
            label6.Text = "Phone No.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(552, 337);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 19;
            label7.Text = "Age";
            label7.Click += label7_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 484);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(941, 188);
            dataGridView1.TabIndex = 20;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 672);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dispbtn);
            Controls.Add(savebtn);
            Controls.Add(gendergb);
            Controls.Add(agetxt);
            Controls.Add(profpic);
            Controls.Add(phonenotxt);
            Controls.Add(city);
            Controls.Add(dob);
            Controls.Add(emailtxt);
            Controls.Add(nametxt);
            Controls.Add(disptxt);
            Name = "Student";
            Text = "Student";
            ((System.ComponentModel.ISupportInitialize)profpic).EndInit();
            gendergb.ResumeLayout(false);
            gendergb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox disptxt;
        private TextBox nametxt;
        private TextBox emailtxt;
        private RadioButton malerb;
        private RadioButton femalerb;
        private DateTimePicker dob;
        private ComboBox city;
        private TextBox phonenotxt;
        private PictureBox profpic;
        private TextBox agetxt;
        private GroupBox gendergb;
        private Button savebtn;
        private Button dispbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView1;
    }
}