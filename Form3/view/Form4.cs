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

namespace Form3.view
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Criamos a string conexão
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GUI9492\\SQLDEVELOPER;Initial Catalog=clube;Integrated Security=True");
            //Cria string de inserção SQL
            string sql = "INSERT INTO tb_categorias(nome) values (@nome)";
            Random numeroID = new Random();
            numeroID.Next();


            try
            {
                //objeto
                SqlCommand c = new SqlCommand(sql, conn);

                //inserir dados
                c.Parameters.Add(new SqlParameter("@id", numeroID.Next()));
                c.Parameters.Add(new SqlParameter("@nome", this.textBox1.Text));

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
    }
}
