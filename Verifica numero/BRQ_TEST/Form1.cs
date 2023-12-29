using static System.Net.Mime.MediaTypeNames;

namespace BRQ_TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Par_Impar(int number)
        {
            if(number % 2 == 0)
            {
                return "� par";
            }

            else
            {
                return  "� impar";
            }
        }

        private void ValidaNumero(string txt)
        {

            if(int.TryParse(txt, out int nbr))
            {
                MessageBox.Show($"Numero informado {txt} e ele � {Par_Impar(nbr)}");
                TXT_TEST.Text = " ";
            }

            else
            {
                MessageBox.Show("Digite um n�mero v�lido", "N�mero inv�lido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_TEST.Text = " ";
            }
        }

        private void BTN_TEST_Click(object sender, EventArgs e)
        {
            ValidaNumero(TXT_TEST.Text);
        }
    }
}
