namespace TrocadeValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtmClicar_Click(object sender, EventArgs e)
        {
            string y = TxTValor1.Text;
            TxTValor1.Text = TxtValor2.Text;
            TxtValor2.Text = y;
        }
       
private void TxTValor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblValor1_Click(object sender, EventArgs e)
        {

        }

        private void TxtValor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblValor2_Click(object sender, EventArgs e)
        {

        }

        private void BtmClicar_MouseHover(object sender, EventArgs e)
        {
         
        }
    }
}
