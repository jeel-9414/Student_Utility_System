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
            gendergb = new GroupBox();
            savebtn = new Button();
            dispbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            profpicbtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)profpic).BeginInit();
            gendergb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // disptxt
            // 
            disptxt.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            disptxt.Location = new Point(356, 23);
            disptxt.Name = "disptxt";
            disptxt.Size = new Size(537, 47);
            disptxt.TabIndex = 0;
            disptxt.Text = "Student Dashboard";
            disptxt.TextAlign = HorizontalAlignment.Center;
            // 
            // nametxt
            // 
            nametxt.Location = new Point(356, 125);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(250, 27);
            nametxt.TabIndex = 1;
            // 
            // emailtxt
            // 
            emailtxt.Location = new Point(356, 183);
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
            dob.Location = new Point(356, 252);
            dob.Name = "dob";
            dob.Size = new Size(250, 27);
            dob.TabIndex = 5;
            // 
            // city
            // 
            city.FormattingEnabled = true;
            city.Items.AddRange(new object[] { "Ahmedabad", "Anand", "Amreli", "Bhavnagar", "Bhruch", "Gandhinagar", "Surat", "Surendranagar", "Navsari", "Tapi", "Valsad" });
            city.Location = new Point(356, 309);
            city.Name = "city";
            city.Size = new Size(250, 28);
            city.TabIndex = 6;
            // 
            // phonenotxt
            // 
            phonenotxt.Location = new Point(886, 270);
            phonenotxt.Name = "phonenotxt";
            phonenotxt.Size = new Size(168, 27);
            phonenotxt.TabIndex = 7;
            // 
            // profpic
            // 
            profpic.Location = new Point(886, 95);
            profpic.Name = "profpic";
            profpic.Size = new Size(168, 143);
            profpic.TabIndex = 8;
            profpic.TabStop = false;
            // 
            // gendergb
            // 
            gendergb.Controls.Add(malerb);
            gendergb.Controls.Add(femalerb);
            gendergb.Location = new Point(266, 363);
            gendergb.Name = "gendergb";
            gendergb.Size = new Size(340, 68);
            gendergb.TabIndex = 10;
            gendergb.TabStop = false;
            gendergb.Text = "Gender";
            // 
            // savebtn
            // 
            savebtn.Location = new Point(717, 376);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(118, 37);
            savebtn.TabIndex = 11;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // dispbtn
            // 
            dispbtn.Location = new Point(1041, 376);
            dispbtn.Name = "dispbtn";
            dispbtn.Size = new Size(112, 37);
            dispbtn.TabIndex = 12;
            dispbtn.Text = "Display";
            dispbtn.UseVisualStyleBackColor = true;
            dispbtn.Click += dispbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(266, 129);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 13;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 186);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 14;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 252);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 15;
            label3.Text = "DOB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(266, 317);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 16;
            label4.Text = "City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(779, 124);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 17;
            label5.Text = "Profile Pic";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(779, 273);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 18;
            label6.Text = "Phone No.";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 562);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1216, 110);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // profpicbtn
            // 
            profpicbtn.Location = new Point(886, 376);
            profpicbtn.Name = "profpicbtn";
            profpicbtn.Size = new Size(118, 37);
            profpicbtn.TabIndex = 21;
            profpicbtn.Text = "Upload Photo";
            profpicbtn.UseVisualStyleBackColor = true;
            profpicbtn.Click += profpicbtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 672);
            Controls.Add(profpicbtn);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dispbtn);
            Controls.Add(savebtn);
            Controls.Add(gendergb);
            Controls.Add(profpic);
            Controls.Add(phonenotxt);
            Controls.Add(city);
            Controls.Add(dob);
            Controls.Add(emailtxt);
            Controls.Add(nametxt);
            Controls.Add(disptxt);
            Name = "Student";
            Text = "Student";
            Load += Student_Load_1;
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
        private GroupBox gendergb;
        private Button savebtn;
        private Button dispbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private Button profpicbtn;
        private OpenFileDialog openFileDialog1;
    }
}