using System;
using System.Windows.Forms;

namespace App_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            try
            {
                if(txtDistanciaInicial.Text != "")
                {
                    if(txtDistanciaFinal.Text != "")
                    {
                        var inicio = txtDistanciaInicial.Text;
                        var final = txtDistanciaFinal.Text;
                        var distanciaMaxima = 3;

                        var contador = true;

                        var resultado = (Convert.ToDecimal(inicio) + Convert.ToDecimal(final)) / distanciaMaxima;
                        if (resultado > 3)
                        {
                            var somar = 4;
                            while (contador == true)
                            {
                                resultado = (Convert.ToDecimal(inicio) + Convert.ToDecimal(final)) / somar;
                                if (resultado <= 3) { contador = false; } else { somar++; }
                            }
                        }

                        lblResultado.Text = "Distância entre pilares: " + resultado;
                        lblResultado.Visible = true;
                    }
                    else
                    {
                        var result = MessageBox.Show("Entre com uma distância final", "Fechar Formulário",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    var result = MessageBox.Show("Entre com uma distância inicial", "Fechar Formulário",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                var result = MessageBox.Show(ex.Message, "Fechar Formulário",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
