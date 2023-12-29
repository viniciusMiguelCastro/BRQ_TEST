namespace Conversor_Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string ConverterTemperatura(double temperatura)
        {
            double f = ((temperatura - 32) * 5) / 9;

            double k = (temperatura + 273.15);

            return $"A temperatura em Celsius de {temperatura} para \nFahrenheit é {f} e para \nKelvin é {k}";
        }

        private void calcular_teperatura_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ConverterTemperatura((double)temperatura.Value));
        }
    }
}
