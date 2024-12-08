namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button_Login = new Button();
            panel3 = new Panel();
            textBoxPassword = new TextBox();
            panel2 = new Panel();
            textBoxUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1032, 644);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(button_Login);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(338, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 413);
            panel1.TabIndex = 1;
            // 
            // button_Login
            // 
            button_Login.Font = new Font("Tempus Sans ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Login.Location = new Point(121, 319);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(107, 49);
            button_Login.TabIndex = 7;
            button_Login.Text = "LOGIN";
            button_Login.UseVisualStyleBackColor = true;
            button_Login.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(textBoxPassword);
            panel3.Location = new Point(27, 265);
            panel3.Name = "panel3";
            panel3.Size = new Size(288, 31);
            panel3.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(0, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(285, 27);
            textBoxPassword.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(textBoxUsername);
            panel2.Location = new Point(27, 160);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 31);
            panel2.TabIndex = 4;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(0, 4);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(285, 27);
            textBoxUsername.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(121, 232);
            label4.Name = "label4";
            label4.Size = new Size(101, 19);
            label4.TabIndex = 3;
            label4.Text = "PASSWORD";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(121, 128);
            label3.Name = "label3";
            label3.Size = new Size(107, 19);
            label3.TabIndex = 2;
            label3.Text = "USERNAME ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tempus Sans ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(121, 59);
            label2.Name = "label2";
            label2.Size = new Size(96, 30);
            label2.TabIndex = 1;
            label2.Text = "LOGIN ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 19);
            label1.Name = "label1";
            label1.Size = new Size(253, 30);
            label1.TabIndex = 0;
            label1.Text = "TOGETHER CULTURE ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 7);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 644);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Panel panel3;
        private Panel panel2;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Button button_Login;
        private DataGridView dataGridView1;
    }
}
