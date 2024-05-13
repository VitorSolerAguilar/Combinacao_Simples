using System.Runtime.InteropServices;

namespace matematicaDiscreta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void arranjoSimples_Click(object sender, EventArgs e)
        {
            //An,k = N!/(N-K)!
            int fatorialN = 1, fatorialK = 1, numRepeticaoN_k = 0, aNK = 0;
            int valorN = int.Parse(ValorN.Text);
            int valorK = int.Parse(ValorK.Text);

            numRepeticaoN_k = valorN - valorK;

            for (int i = 1; i < valorN + 1; i++)
            {
                fatorialN *= i;
            }
            for (int j = 1; j < numRepeticaoN_k + 1; j++)
            {
                fatorialK *= j;
            }

            aNK = fatorialN / fatorialK;
            labelResultado.Text = aNK.ToString();
        }

        private void combinacaoSimples_Click(object sender, EventArgs e)
        {
            //Cn,k = N!/K!(N-K)!
            int fatorialN = 1, fatorialK = 1, numRepeticaoN_k = 0, fatorialN_K = 1, cNK;

            int valorN = int.Parse(ValorN.Text);
            int valorK = int.Parse(ValorK.Text);
            numRepeticaoN_k = valorN - valorK;

            for (int i = 1; i < valorN + 1; i++)
            {
                fatorialN *= i;
            }
            for (int j = 1; j < valorK + 1; j++)
            {
                fatorialK *= j;
            }
            for (int k = 1; k < numRepeticaoN_k + 1; k++)
            {
                fatorialN_K *= k;
            }

            cNK = fatorialN / (fatorialK * fatorialN_K);
            labelResultado.Text = cNK.ToString();
        }
    }
}
