using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.buttonmembership.Click += new System.EventHandler(this.buttonmembership_Click);
            this.buttonshop.Click += new System.EventHandler(this.buttonshop_Click);
            this.buttonevents.Click += new System.EventHandler(this.buttonevents_Click);
            this.buttonconnect.Click += new System.EventHandler(this.buttonconnect_Click);
            this.buttonjoinus.Click += new System.EventHandler(this.buttonjoinus_Click);
        }
        // Click event for Membership Button
        private void buttonmembership_Click(object sender, EventArgs e)
        {
            // Navigate to Form4
            Form4 form4 = new Form4();
            this.Hide();  // Hide the current form
            form4.Show(); // Show Form4
        }

        // Click event for Shop Button
        private void buttonshop_Click(object sender, EventArgs e)
        {
            // Navigate to Form5
            Form5 form5 = new Form5();
            this.Hide();  // Hide the current form
            form5.Show(); // Show Form5
        }

        // Click event for Events Button
        private void buttonevents_Click(object sender, EventArgs e)
        {
            // Navigate to Form6
            Form6 form6 = new Form6();
            this.Hide();  // Hide the current form
            form6.Show(); // Show Form6
        }

        // Click event for Connect Button
        private void buttonconnect_Click(object sender, EventArgs e)
        {
            // Navigate to Form8
            Form8 form8 = new Form8();
            this.Hide();  // Hide the current form
            form8.Show(); // Show Form8
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Home button clicked!");
            Form3 form3 = new Form3();
            form3.Show();  // Shows the current form (Form3) again
            this.Hide();   // Hides the current form (Form3) temporarily if needed
        }

        // Click event for Join Us Button
        private void buttonjoinus_Click(object sender, EventArgs e)
        {
            // Navigate to Form4
            Form4 form4 = new Form4();
            this.Hide();  // Hide the current form
            form4.Show(); // Show Form4
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void buttonabout_Click(object sender, EventArgs e)
        {

        }

        private void buttoncontactus_Click(object sender, EventArgs e)
        {

        }
    }
}
