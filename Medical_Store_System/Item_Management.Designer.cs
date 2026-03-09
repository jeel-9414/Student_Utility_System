namespace Medical_Store_System
{
    partial class Item_Management
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
            nametxt = new TextBox();
            ccb = new ComboBox();
            quantity = new NumericUpDown();
            pricetxt = new TextBox();
            expdate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            savebtn = new Button();
            dataGridView1 = new DataGridView();
            searchbtn = new Button();
            dispbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(171, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(743, 47);
            textBox1.TabIndex = 0;
            textBox1.Text = "Item Management";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // nametxt
            // 
            nametxt.Anchor = AnchorStyles.None;
            nametxt.Location = new Point(519, 132);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(250, 27);
            nametxt.TabIndex = 1;
            // 
            // ccb
            // 
            ccb.Anchor = AnchorStyles.None;
            ccb.FormattingEnabled = true;
            ccb.Items.AddRange(new object[] { "Tablet", "Syrup", "Injection", "Capsule", "Cream", "Drops", "Powder" });
            ccb.Location = new Point(519, 199);
            ccb.Name = "ccb";
            ccb.Size = new Size(250, 28);
            ccb.TabIndex = 2;
            // 
            // quantity
            // 
            quantity.Anchor = AnchorStyles.None;
            quantity.Location = new Point(519, 256);
            quantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            quantity.Name = "quantity";
            quantity.Size = new Size(250, 27);
            quantity.TabIndex = 3;
            // 
            // pricetxt
            // 
            pricetxt.Anchor = AnchorStyles.None;
            pricetxt.Location = new Point(519, 309);
            pricetxt.Name = "pricetxt";
            pricetxt.Size = new Size(250, 27);
            pricetxt.TabIndex = 4;
            // 
            // expdate
            // 
            expdate.Anchor = AnchorStyles.None;
            expdate.Location = new Point(519, 370);
            expdate.Name = "expdate";
            expdate.Size = new Size(250, 27);
            expdate.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(396, 139);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(396, 207);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 7;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(396, 263);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 8;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(396, 316);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 9;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(396, 377);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 10;
            label5.Text = "Expiry Date";
            // 
            // savebtn
            // 
            savebtn.Anchor = AnchorStyles.None;
            savebtn.Location = new Point(341, 425);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(109, 41);
            savebtn.TabIndex = 11;
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
            dataGridView1.Location = new Point(0, 494);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1051, 162);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // searchbtn
            // 
            searchbtn.Anchor = AnchorStyles.None;
            searchbtn.Location = new Point(519, 425);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(109, 41);
            searchbtn.TabIndex = 13;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // dispbtn
            // 
            dispbtn.Anchor = AnchorStyles.None;
            dispbtn.Location = new Point(693, 425);
            dispbtn.Name = "dispbtn";
            dispbtn.Size = new Size(109, 41);
            dispbtn.TabIndex = 14;
            dispbtn.Text = "Display";
            dispbtn.UseVisualStyleBackColor = true;
            dispbtn.Click += dispbtn_Click;
            // 
            // Item_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 656);
            Controls.Add(dispbtn);
            Controls.Add(searchbtn);
            Controls.Add(dataGridView1);
            Controls.Add(savebtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(expdate);
            Controls.Add(pricetxt);
            Controls.Add(quantity);
            Controls.Add(ccb);
            Controls.Add(nametxt);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Item_Management";
            Text = "Item_Management";
            Load += Item_Management_Load;
            ((System.ComponentModel.ISupportInitialize)quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox nametxt;
        private ComboBox ccb;
        private NumericUpDown quantity;
        private TextBox pricetxt;
        private DateTimePicker expdate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button savebtn;
        private DataGridView dataGridView1;
        private Button searchbtn;
        private Button dispbtn;
    }
}