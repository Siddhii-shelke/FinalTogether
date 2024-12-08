namespace WinFormsApp1
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            panel1 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            panel3 = new Panel();
            buttonhome = new Button();
            buttonmembership = new Button();
            buttonshop = new Button();
            buttonevents = new Button();
            buttonconnect = new Button();
            buttoncontactus = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(buttoncontactus);
            panel1.Controls.Add(buttonconnect);
            panel1.Controls.Add(buttonevents);
            panel1.Controls.Add(buttonshop);
            panel1.Controls.Add(buttonmembership);
            panel1.Controls.Add(buttonhome);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 94);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(780, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 27);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 3);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 1;
            label3.Text = "search";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(160, 40);
            label2.Name = "label2";
            label2.Size = new Size(0, 17);
            label2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(142, 60);
            label1.TabIndex = 1;
            label1.Text = "TOGETHER \r\n CULTURE ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tempus Sans ITC", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(374, 262);
            label9.Name = "label9";
            label9.Size = new Size(225, 45);
            label9.TabIndex = 14;
            label9.Text = "PLACE HIRE ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(126, 320);
            label4.Name = "label4";
            label4.Size = new Size(746, 170);
            label4.TabIndex = 15;
            label4.Text = resources.GetString("label4.Text");
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(967, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tempus Sans ITC", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(11, 7);
            label5.Name = "label5";
            label5.Size = new Size(157, 37);
            label5.TabIndex = 17;
            label5.Text = "ENQUIRES";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(label5);
            panel3.Location = new Point(394, 493);
            panel3.Name = "panel3";
            panel3.Size = new Size(179, 47);
            panel3.TabIndex = 18;
            // 
            // buttonhome
            // 
            buttonhome.BackColor = Color.Black;
            buttonhome.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonhome.ForeColor = SystemColors.ButtonHighlight;
            buttonhome.Location = new Point(160, 32);
            buttonhome.Name = "buttonhome";
            buttonhome.Size = new Size(73, 32);
            buttonhome.TabIndex = 19;
            buttonhome.Text = "HOME";
            buttonhome.UseVisualStyleBackColor = false;
            // 
            // buttonmembership
            // 
            buttonmembership.BackColor = Color.Black;
            buttonmembership.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonmembership.ForeColor = SystemColors.ButtonHighlight;
            buttonmembership.Location = new Point(239, 32);
            buttonmembership.Name = "buttonmembership";
            buttonmembership.Size = new Size(128, 32);
            buttonmembership.TabIndex = 19;
            buttonmembership.Text = "MEMBERSHIP ";
            buttonmembership.UseVisualStyleBackColor = false;
            // 
            // buttonshop
            // 
            buttonshop.BackColor = Color.Black;
            buttonshop.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonshop.ForeColor = SystemColors.ButtonHighlight;
            buttonshop.Location = new Point(373, 31);
            buttonshop.Name = "buttonshop";
            buttonshop.Size = new Size(63, 32);
            buttonshop.TabIndex = 20;
            buttonshop.Text = "SHOP";
            buttonshop.UseVisualStyleBackColor = false;
            // 
            // buttonevents
            // 
            buttonevents.BackColor = Color.Black;
            buttonevents.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonevents.ForeColor = SystemColors.ButtonHighlight;
            buttonevents.Location = new Point(438, 31);
            buttonevents.Name = "buttonevents";
            buttonevents.Size = new Size(90, 32);
            buttonevents.TabIndex = 21;
            buttonevents.Text = "EVENTS";
            buttonevents.UseVisualStyleBackColor = false;
            // 
            // buttonconnect
            // 
            buttonconnect.BackColor = Color.Black;
            buttonconnect.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonconnect.ForeColor = SystemColors.ButtonHighlight;
            buttonconnect.Location = new Point(534, 31);
            buttonconnect.Name = "buttonconnect";
            buttonconnect.Size = new Size(100, 32);
            buttonconnect.TabIndex = 22;
            buttonconnect.Text = "CONNECT";
            buttonconnect.UseVisualStyleBackColor = false;
            // 
            // buttoncontactus
            // 
            buttoncontactus.BackColor = Color.Black;
            buttoncontactus.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttoncontactus.ForeColor = SystemColors.ButtonHighlight;
            buttoncontactus.Location = new Point(640, 31);
            buttoncontactus.Name = "buttoncontactus";
            buttoncontactus.Size = new Size(119, 32);
            buttoncontactus.TabIndex = 23;
            buttoncontactus.Text = "CONTACT US";
            buttoncontactus.UseVisualStyleBackColor = false;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 585);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(panel1);
            Name = "Form7";
            Text = "Form7";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label9;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private Panel panel3;
        private Button buttonhome;
        private Button buttonmembership;
        private Button buttonshop;
        private Button buttonevents;
        private Button buttonconnect;
        private Button buttoncontactus;
    }
}