namespace Exercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImprima_Click(object sender, EventArgs e)
        {
            float txbN1, txbN2, txbN3;

            txbN1 = float.Parse(txbNumero1.Text);
            txbN2 = float.Parse(txbNumero2.Text);
            txbN3 = float.Parse(txbNumero3.Text);

            var minhaLista = new List<float> { txbN1, txbN2, txbN3};
            minhaLista.Sort();
            txbNmaior.Text = minhaLista[2].ToString();
            txbNmenor.Text = minhaLista[0].ToString();
           
        }
    }
}