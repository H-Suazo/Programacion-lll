namespace LP_lll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNumero.Text);

            txtParImpar.Text = ParImpar(num).ToString();

            txtNumPrimo.Text = NumPrimo(num).ToString();
        }

        private string ParImpar(int num)
        {
            string tipNum;

            if (num % 2 == 0)
            {
                tipNum = "El n�mero es par";
            }
            else
            {
                tipNum = "El n�mero es impar";
            }

            return tipNum;
        }

        private string NumPrimo(int num)
        {
            int n = 2;
            bool b = true;
            string tipNum2;

            while ((b) && (n < num))
            {
                if(num % n == 0)
                {
                    b = false;
                }
                else
                {
                    n++;
                }
            }

            if(b)
            {
                tipNum2 = "El n�mero es primo";
            }
            else
            {
                tipNum2 = "El n�mero no es primo";
            }

            return tipNum2;

        }
    }
}