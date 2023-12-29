namespace Calculo_de_idade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string calcularIdade(DateTime idade1, DateTime idade2) 
        {
            int a = idade1.Year;
            int b = idade2.Year; 

            if(idade1.Date.Month > idade2.Date.Month && idade1.Day > idade2.Day)
            {
                return $"Tem {(a - b) - 1} anos";
            }

            return $"Tem {a-b} anos";
        }

        private void calcular_data_Click(object sender, EventArgs e)
        {
            MessageBox.Show(calcularIdade(dataDesejada.Value, dataNascimento.Value));
        }
    }
}
