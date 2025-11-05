namespace helloEletro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = txtNome.Text + " Seja bem-vindo";
            txtNome.Clear();
        }
    }
}
