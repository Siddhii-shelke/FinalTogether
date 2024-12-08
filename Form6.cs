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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
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

        private void buttonhome_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.Show();  // Shows the current form (Form3) again
            this.Hide();   // Hides the current form (Form3) temporarily if needed
        }
        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
