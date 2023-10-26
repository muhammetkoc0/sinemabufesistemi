namespace sinemabüfesistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int mısır, cay,  su, bilet, toplam;
            mısır = Convert.ToInt16(textBox1.Text);
            cay = Convert.ToInt16(textBox2.Text);
            su = Convert.ToInt16(textBox3.Text);
            bilet = Convert.ToInt16(textBox4.Text);

            toplam = mısır * 25 + cay * 10 + su * 5 + bilet * 75;
            tutarlab.Text = toplam.ToString()+ " TL ";

            kasatutar = kasatutar + toplam;
            kasalab.Text = kasatutar.ToString()+" TL";
        }
    }
}