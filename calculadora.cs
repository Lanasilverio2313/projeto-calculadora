namespace caculadora
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero1.Text))
            {

                MessageBox.Show("O 1 campo está vazio, por favor preencha.");
                return; //para parar de dar erros
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //validaçao de campos

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNumero1.Text))
            {

                MessageBox.Show("O 2 campo está vazio, por favor preencha.");
                return; //para parar de dar erro

            }

            if (string.IsNullOrWhiteSpace(txtNumero1.Text))
            {

                MessageBox.Show("O 1 campo está vazio, por favor preencha.");
                return; //para parar de dar erro

                if (!double.TryParse(txtNumero1.Text, out double numero1))
                {
                    MessageBox.Show("Por favor, Preencha o Campo Número 1 somente com número.");
                    return;

                }
                if (!double.TryParse(txtNumero1.Text, out double numero2))
                {
                    MessageBox.Show("Por favor, Preencha o Campo Número 2 somente com número.");
                    return;

                }
                //Realizar a soma dos numeros e exibe o resultado
                lblResultado.Text = (numero1 + numero2).ToString();
            }
        }



        private void somar_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            lblResultado.Text = (numero1 - numero2).ToString();

        }







        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero1.Text))

            {

                MessageBox.Show("O campo  está vazio, por favor preencha.");
                button2.Focus();
                return;
            }

            if (!double.TryParse(txtNumero1.Text, out double numero1))
            {
                MessageBox.Show("Por favor, Preencha o Campo Número 1 somente com número.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumero2.Text))

            {

                MessageBox.Show("O campo  está vazio, por favor preencha.");
                button2.Focus();
                return;
            }

            if (!double.TryParse(txtNumero1.Text, out double numero2))
            {
                MessageBox.Show("Por favor, Preencha o Campo Número 1 somente com número.");
                return;
            }

            lblResultado.Text = (numero1 * numero2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero1.Text))

            {

                MessageBox.Show("O campo  está vazio, por favor preencha.");
                button2.Focus();
                return;
            }

            if (!double.TryParse(txtNumero1.Text, out double numero1))
            {
                MessageBox.Show("Por favor, Preencha o Campo Número 1 somente com número.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumero2.Text))

            {

                MessageBox.Show("O campo  está vazio, por favor preencha.");
                button2.Focus();
                return;
            }

            if (!double.TryParse(txtNumero1.Text, out double numero2))
            {
                MessageBox.Show("Por favor, Preencha o Campo Número 1 somente com número.");
                return;
            }
        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

            if(string.IsNullOrWhiteSpace(txtNumero1.Text))

            {

                MessageBox.Show("O campo  está vazio, por favor preencha.");
                button2.Focus();
                return;
            }

            if (!double.TryParse(txtNumero1.Text, out double numero1))
            {
                MessageBox.Show("Por favor, Preencha o Campo Número 1 somente com número.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumero2.Text))

            {

                MessageBox.Show("O campo  está vazio, por favor preencha.");
                button2.Focus();
                return;
            }

            if (!double.TryParse(txtNumero1.Text, out double numero2))
            {
                MessageBox.Show("Por favor, Preencha o Campo Número 1 somente com número.");
                return;
            }
            lblResultado.Text = (numero2 - numero1).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

        


    



