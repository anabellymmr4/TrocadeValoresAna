namespace TrocadeValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btm1_Click(object sender, EventArgs e)
        {
            string a = Txt1.Text;
            Txt1.Text = Txt2.Text;
            Txt2.Text = a;
        }

        private void Txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtmClicar_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
