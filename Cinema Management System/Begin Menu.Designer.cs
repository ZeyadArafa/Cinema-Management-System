namespace Cinema_Management_System
{
    partial class Begin_Menu
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
            Actor = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // Actor
            // 
            Actor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Actor.Location = new Point(174, 40);
            Actor.Name = "Actor";
            Actor.Size = new Size(421, 56);
            Actor.TabIndex = 0;
            Actor.Text = "Actors and Directors Management";
            Actor.UseVisualStyleBackColor = true;
            Actor.Click += button1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(174, 102);
            button1.Name = "button1";
            button1.Size = new Size(421, 56);
            button1.TabIndex = 1;
            button1.Text = "Movies and Genres Management";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(174, 164);
            button2.Name = "button2";
            button2.Size = new Size(421, 56);
            button2.TabIndex = 2;
            button2.Text = "Staff Management";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(174, 226);
            button3.Name = "button3";
            button3.Size = new Size(421, 56);
            button3.TabIndex = 3;
            button3.Text = "Customers and Tickets Management";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(174, 288);
            button4.Name = "button4";
            button4.Size = new Size(421, 56);
            button4.TabIndex = 4;
            button4.Text = "Rooms and Concessions Management";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(174, 350);
            button5.Name = "button5";
            button5.Size = new Size(421, 56);
            button5.TabIndex = 5;
            button5.Text = "Payments Management\n";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Begin_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Actor);
            Name = "Begin_Menu";
            Text = "Begin_Menu";
            Load += Begin_Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Actor;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}