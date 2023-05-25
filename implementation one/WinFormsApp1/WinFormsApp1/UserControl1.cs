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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { checkBox6.Checked = false; }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;


        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            checkBox3.Checked = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            checkBox6.Checked = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            checkBox5.Checked = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            checkBox4.Checked = true;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked) { checkBox1.Checked = false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            label2.Text = string.Empty;
            label3.Text = string.Empty;
            label4.Text = string.Empty;
            label5.Text = string.Empty;
            int n = 1;
            if (checkBox1.Checked || checkBox6.Checked)
            {

                label1.Text = n.ToString() + " _    you should go to the temple in the morning to enjoy it,s journy ";
                n++;

            }
            if (checkBox5.Checked)
            {
                label2.Text = n.ToString() + " _    you should eate some thing to countinue your journy  ";
                n++;

            }
            if (checkBox2.Checked)
            {
                label3.Text = n.ToString() + " _    you may love to go to pool to feel beter in the hot whaether ";
                n++;

            }
            if (checkBox3.Checked)
            {
                label4.Text = n.ToString() + " _    then the cafe in the medel of the day to drink some drinkes and eate sweets ";

                n++;
            }
            if (checkBox4.Checked)
            {
                label5.Text = n.ToString() + " _    the kornish of luxor is better in the night to have some fresh air ";

                n++;
            }
        }
    }

}
