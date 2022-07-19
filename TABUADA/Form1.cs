namespace TABUADA
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

        private void button1_Click(object sender, EventArgs e)
        {
            int num, cont, tab;
            num = Convert.ToInt16(txbNum.Text);
            for (cont = 0; cont <= 10; cont++)
            {
                tab = num * cont;
                lsbTabuada.Items.Add(num.ToString() + "*" + cont.ToString() + "=" + tab.ToString());
            }
        }
        //Para o botão da Tabuada
        private void btnTabuada_KeyPress(object sender, KeyPressEventArgs e)
        {
                      

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Para o botão Limpar
            lsbTabuada.Items.Clear(); // Cuidado items é com m e o I deve ser maiusculo
        }

        private void btnTabuada_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}