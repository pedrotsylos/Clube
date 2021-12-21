using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Form3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Criamos a string conexão
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GUI9492\\SQLDEVELOPER;Initial Catalog=clube;Integrated Security=True");
            //Cria string de inserção SQL
            string sql = "INSERT INTO tb_socio(nome, email, numero_cartao_socio, endereco, telefone) values (@nome, @email, @numero_cartao_socio, @endereco, @telefone)";
            Random numeroID = new Random();
            numeroID.Next();

            try
            {
                //objeto
                SqlCommand c = new SqlCommand(sql, conn);

                //inserir dados
                c.Parameters.Add(new SqlParameter("@id", numeroID.Next()));
                c.Parameters.Add(new SqlParameter("@nome", this.textBox1.Text));
                c.Parameters.Add(new SqlParameter("@email", this.textBox2.Text));
                c.Parameters.Add(new SqlParameter("@numero_cartao_socio", this.textBox3.Text));
                c.Parameters.Add(new SqlParameter("@endereco", this.textBox4.Text));
                c.Parameters.Add(new SqlParameter("@telefone", this.textBox5.Text));
                c.Parameters.Add(new SqlParameter("@categoria", this.comboBox1.Text));

                //abrir conexão
                conn.Open();

                //executar comando
                c.ExecuteNonQuery();

                //fechar conexão
                conn.Close();

                MessageBox.Show("Enviado com sucesso!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("select nome from tb_categorias order by id");
            comboBox1.Refresh();
        }
    }
}
