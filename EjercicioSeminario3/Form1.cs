namespace EjercicioSeminario3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Código opcional si se requiere realizar alguna acción al modificar el texto
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Código opcional si se requiere realizar alguna acción al hacer clic en la etiqueta
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double montoIngresado = Convert.ToDouble(textBox1.Text);
                double valorProducto = Convert.ToDouble(textBox2.Text);
                double vuelto = montoIngresado - valorProducto;

                if (vuelto < 0)
                {
                    label1.Text = "No te alcanza para este producto.";
                    return;
                }

                double[] billetesMonedas = { 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1, 0.5, 0.25 };
                int[] cantidad = new int[billetesMonedas.Length];

                double vueltoRestante = Math.Round(vuelto, 2);
                for (int i = 0; i < billetesMonedas.Length; i++)
                {
                    cantidad[i] = (int)(vueltoRestante / billetesMonedas[i]);
                    vueltoRestante = Math.Round(vueltoRestante % billetesMonedas[i], 2);
                }

                string resultado = "Vuelto: $" + vuelto.ToString("F2") + "\n";
                for (int i = 0; i < billetesMonedas.Length; i++)
                {
                    if (cantidad[i] > 0)
                    {
                        resultado += $"{cantidad[i]} de ${billetesMonedas[i]:0.00}\n";
                    }
                }

                label1.Text = resultado;
            }
            catch (FormatException)
            {
                label1.Text = "Ingrese valores numéricos válidos.";
            }
        }
    }
}