namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //07.07.2023 çember alan çevre hesaplama
        private void button1_Click(object sender, EventArgs e)
        {
            int r;
            double R;
            double cevre;
            double alan;


            r = Convert.ToInt32(textBox1.Text);
            if (radioButton1.Checked)
            {
                cevre = (2 * 3.14 * r);
                listBox1.Items.Add(cevre);  

            }
            if (radioButton2.Checked)
            {
                alan = ( r * r*3.14);
                listBox1.Items.Add(alan);

            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


