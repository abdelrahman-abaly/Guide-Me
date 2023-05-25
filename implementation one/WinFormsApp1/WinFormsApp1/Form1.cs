namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            exitpanel.Visible = false;
            whatpanel.Visible = false;
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 8)
            {
                pictureBox1.Image = imageList1.Images[count];
                pictureBox2.Image = imageList2.Images[count];
                count++;

            }
            else { count = 0; }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            exitpanel.Show();
            first1.SendToBack();
            sec1.SendToBack();
            third11.SendToBack();
            fourth11.SendToBack();
            fifth11.SendToBack();
            userControl11.SendToBack();
            whatpanel.Hide();
            userControl21.SendToBack();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "00")
            {
                this.Close();

            }
            else
            {
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            first1.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sec1.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            third11.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            first1.SendToBack();
            sec1.SendToBack();
            third11.SendToBack();
            fourth11.SendToBack();
            exitpanel.Hide();
            fifth11.SendToBack();
            userControl11.SendToBack();
            whatpanel.Hide();
            userControl21.SendToBack();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fourth11.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fifth11.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            whatpanel.Show();
            first1.SendToBack();
            sec1.SendToBack();
            third11.SendToBack();
            fourth11.SendToBack();
            fifth11.SendToBack();
            userControl11.SendToBack();
            userControl21.SendToBack();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           userControl21.BringToFront();

        }
    }
}