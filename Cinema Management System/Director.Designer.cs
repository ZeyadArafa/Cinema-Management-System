namespace Cinema_Management_System
{
    partial class Director
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            Insert = new Button();
            Update = new Button();
            Delete = new Button();
            Select = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 251);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(345, 532);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(674, 213);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "View";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Insert
            // 
            Insert.Location = new Point(674, 11);
            Insert.Name = "Insert";
            Insert.Size = new Size(94, 29);
            Insert.TabIndex = 14;
            Insert.Text = "Insert";
            Insert.UseVisualStyleBackColor = true;
            Insert.Click += Insert_Click;
            // 
            // Update
            // 
            Update.Location = new Point(674, 61);
            Update.Name = "Update";
            Update.Size = new Size(94, 29);
            Update.TabIndex = 13;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(674, 108);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 12;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Select
            // 
            Select.Location = new Point(674, 161);
            Select.Name = "Select";
            Select.Size = new Size(94, 29);
            Select.TabIndex = 11;
            Select.Text = "Select";
            Select.UseVisualStyleBackColor = true;
            Select.Click += Select_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Sharif", "Malek", "Massoud", "Badreya", "Zaki", "El Sakka", "Hassan", "El-Abd", "El-Sherif", "Abdelghany", "Lutfi", "Shiha", "Hosny", "Zaki", "Yassin" });
            comboBox2.Location = new Point(239, 134);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 18;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Omar", "Rami", "Mena", "Sayed", "Ahmed", "Basma", "Yasmina", "Nour", "Kareem", "Nadia", "Hala", "Tamer", "Mona", "Asser" });
            comboBox1.Location = new Point(239, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(38, 134);
            label2.Name = "label2";
            label2.Size = new Size(179, 28);
            label2.TabIndex = 16;
            label2.Text = "Director Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(38, 58);
            label1.Name = "label1";
            label1.Size = new Size(182, 28);
            label1.TabIndex = 15;
            label1.Text = "Director First Name";
            // 
            // Director
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 656);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Insert);
            Controls.Add(Update);
            Controls.Add(Delete);
            Controls.Add(Select);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Director";
            Text = "Director";
            Load += Director_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button button1;
        private Button Insert;
        private Button Update;
        private Button Delete;
        private Button Select;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
    }
}