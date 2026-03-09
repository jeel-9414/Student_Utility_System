namespace Personal_Notes_Management_module
{
    partial class Notes
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
            titletxt = new TextBox();
            contenttxt = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            savebtn = new Button();
            dataGridView1 = new DataGridView();
            Display = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(148, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(603, 47);
            textBox1.TabIndex = 0;
            textBox1.Text = "Notes";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // titletxt
            // 
            titletxt.Location = new Point(466, 131);
            titletxt.Name = "titletxt";
            titletxt.Size = new Size(374, 27);
            titletxt.TabIndex = 1;
            // 
            // contenttxt
            // 
            contenttxt.Location = new Point(466, 213);
            contenttxt.Name = "contenttxt";
            contenttxt.Size = new Size(374, 120);
            contenttxt.TabIndex = 2;
            contenttxt.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(306, 128);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 3;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 216);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 4;
            label2.Text = "Content";
            // 
            // savebtn
            // 
            savebtn.Location = new Point(345, 413);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(101, 42);
            savebtn.TabIndex = 5;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 501);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(898, 246);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Display
            // 
            Display.Location = new Point(596, 413);
            Display.Name = "Display";
            Display.Size = new Size(101, 42);
            Display.TabIndex = 7;
            Display.Text = "Display";
            Display.UseVisualStyleBackColor = true;
            Display.Click += Display_Click;
            // 
            // Notes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 747);
            Controls.Add(Display);
            Controls.Add(dataGridView1);
            Controls.Add(savebtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(contenttxt);
            Controls.Add(titletxt);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Notes";
            Text = "Notes";
            Load += Notes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox titletxt;
        private RichTextBox contenttxt;
        private Label label1;
        private Label label2;
        private Button savebtn;
        private DataGridView dataGridView1;
        private Button Display;
    }
}