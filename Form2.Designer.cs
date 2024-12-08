namespace WinFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(357, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 413);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(27, 220);
            panel3.Name = "panel3";
            panel3.Size = new Size(288, 31);
            panel3.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(27, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 31);
            panel2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(85, 198);
            label4.Name = "label4";
            label4.Size = new Size(178, 19);
            label4.TabIndex = 3;
            label4.Text = "CHOOSE USERNAME";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(102, 117);
            label3.Name = "label3";
            label3.Size = new Size(142, 19);
            label3.TabIndex = 2;
            label3.Text = "EMAIL ADDRESS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tempus Sans ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(121, 59);
            label2.Name = "label2";
            label2.Size = new Size(101, 30);
            label2.TabIndex = 1;
            label2.Text = "SIGNUP";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 15);
            label1.Name = "label1";
            label1.Size = new Size(253, 30);
            label1.TabIndex = 0;
            label1.Text = "TOGETHER CULTURE ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1032, 619);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(85, 283);
            label5.Name = "label5";
            label5.Size = new Size(165, 19);
            label5.TabIndex = 6;
            label5.Text = "ENTER PASSWORD ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(27, 305);
            panel4.Name = "panel4";
            panel4.Size = new Size(288, 31);
            panel4.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label6);
            panel5.Location = new Point(102, 356);
            panel5.Name = "panel5";
            panel5.Size = new Size(148, 37);
            panel5.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tempus Sans ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 5);
            label6.Name = "label6";
            label6.Size = new Size(101, 30);
            label6.TabIndex = 8;
            label6.Text = "SIGNUP";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 615);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label5;
        private Panel panel4;
        private Panel panel5;
        private Label label6;
    }
}