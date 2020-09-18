using System;
using System.Data.SqlClient;
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
                if (txtDistanciaInicial.Text != "")
                {
                    if (txtDistanciaFinal.Text != "")
                    {
                        var inicio = txtDistanciaInicial.Text;
                        var final = txtDistanciaFinal.Text;
                        var distanciaMaxima = 3;
                        var distanciaPoste = 10;

                        var contador = true;

                        var resultado = (Convert.ToDecimal(inicio) + Convert.ToDecimal(final)) / distanciaMaxima;
                        var totalPostes = ((Convert.ToInt32(inicio) + Convert.ToInt32(final)) / distanciaPoste) + 2;
                        if (resultado > 3)
                        {
                            var somar = 4;
                            while (contador == true)
                            {
                                resultado = (Convert.ToDecimal(inicio) + Convert.ToDecimal(final)) / somar;
                                if (resultado <= 3) { contador = false; } else { somar++; }
                            }
                        }
                        InserirBancoDeDados(Convert.ToDecimal(inicio), Convert.ToDecimal(final), resultado, totalPostes);
                        lblResultado.Text = "Distância entre pilares: " + resultado + " | Total de Pilares Reforçados: " + totalPostes;
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

        public void InserirBancoDeDados(decimal inicio, decimal final, decimal resultado, int pilares)
        {
            try
            {
                var id = RetornarID();
                System.Data.SqlClient.SqlConnection conexao = new System.Data.SqlClient.SqlConnection("connect");

                System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "INSERT INTO DADOS (ID, INICIO, FINAL, RESULTADO, PILARES) VALUES (" + id + ",'" + inicio.ToString().Replace(',','.') + "','" + final.ToString().Replace(',', '.') + "','" + resultado.ToString().Replace(',', '.') + "','" + pilares + "')";
                command.Connection = conexao;

                conexao.Open();
                command.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception e)
            {
                var msg = e.Message;
            }
        }

        public int RetornarID()
        {
            string connectionString = "connect";

            // Provide the query string with a parameter placeholder.
            string queryString = "SELECT TOP 1 ID FROM DADOS ORDER BY ID DESC;";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if(!reader.HasRows) { return 1; }
                    while (reader.Read())
                    {
                        return Convert.ToInt32(reader[0]) + 1;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
            return 0;
        }
    }
}
