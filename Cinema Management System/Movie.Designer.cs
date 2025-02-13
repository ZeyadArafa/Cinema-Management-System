namespace Cinema_Management_System
{
    partial class Movie
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(942, 219);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "View";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 298);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1053, 355);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 28);
            label1.TabIndex = 2;
            label1.Text = "Movie Name";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "A Nightmare on Elm Street", "Anchorman: The Legend of Ron Burgundy", "Avatar", "Blade Runner", "Finding Nemo", "Forrest Gump", "Frozen", "Gone Girl", "Goodfellas", "Groundhog Day", "Halloween", "Harry Potter and the Sorcerer's Stone", "Inception", "Interstellar", "Joker", "La La Land", "Mad Max: Fury Road", "Pan's Labyrinth", "Pride & Prejudice", "Pulp Fiction", "Scarface", "Se7en", "Shawshank Redemption", "Shrek", "Star Wars: A New Hope", "Superbad", "The Avengers", "The Conjuring", "The Dark Knight", "The Departed", "The Exorcist", "The Godfather", "The Incredibles", "The Lion King", "The Lord of the Rings: The Fellowship of the Ring", "The Matrix", "The Notebook", "The Shining", "Titanic", "Toy Story" });
            comboBox1.Location = new Point(182, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(124, 28);
            label2.TabIndex = 4;
            label2.Text = "Movie Genre";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Action", "Adventure", "Comedy", "Drama", "Fantasy", "Horror", "Science Fiction (Sci-Fi)", "Romance", "Thriller", "Mystery", "Documentary", "Musical", "Historical", "Biography", "Animation", "Western", "Crime", "War", "Family", "Sports" });
            comboBox2.Location = new Point(182, 53);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(149, 28);
            label3.TabIndex = 6;
            label3.Text = "Movie Duration";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(182, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(543, 27);
            textBox2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 174);
            label4.Name = "label4";
            label4.Size = new Size(164, 28);
            label4.TabIndex = 8;
            label4.Text = "Movie Trailer Link";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(182, 219);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 27);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 215);
            label5.Name = "label5";
            label5.Size = new Size(167, 28);
            label5.TabIndex = 10;
            label5.Text = "Movie Director ID";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(182, 258);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(151, 27);
            textBox4.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 254);
            label6.Name = "label6";
            label6.Size = new Size(158, 28);
            label6.TabIndex = 12;
            label6.Text = "Movie Genera ID";
            // 
            // button2
            // 
            button2.Location = new Point(942, 39);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 14;
            button2.Text = "Insert";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(942, 98);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 15;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(942, 160);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 16;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(12, 132);
            label7.Name = "label7";
            label7.Size = new Size(172, 28);
            label7.TabIndex = 17;
            label7.Text = "Movie Description";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(182, 136);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(543, 27);
            textBox5.TabIndex = 18;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // Movie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 665);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Movie";
            Text = "Movie";
            Load += Movie_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label7;
        private TextBox textBox5;
    }
}