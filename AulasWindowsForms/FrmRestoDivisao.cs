using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulasWindowsForms
{
    public partial class FrmRestoDivisao : Form
    {
        public FrmRestoDivisao()
        {
            InitializeComponent();
        }

        private void FrmRestoDivisao_Load(object sender, EventArgs e)
        {

        }

        private void BtnRestodaDivisao_Click(object sender, EventArgs e)
        {
            try {
                int Dividendo = Convert.ToInt32(TxtDividendo.Text);
                int Divisor = Convert.ToInt32(TxtDivisor.Text);
                int Resto = Dividendo % Divisor;
                TxtResto.Text = Resto.ToString();
            }
            catch (FormatException exc)
            {
            MessageBox.Show("Entrada de Dados Inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            catch (DivideByZeroException exc )
            {
                MessageBox.Show("Não é possivel realizar divisão por zero", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
