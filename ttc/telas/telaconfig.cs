using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ttc.classes;

namespace ttc
{
    public partial class telaconfig : Form
    {
        
        public telaconfig()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ftela_cadastro novaform = new Ftela_cadastro();
            novaform.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            
            
            
            if (txtbusca.Text == "") { 
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ABACATE\SQLEXPRESS;Initial Catalog=ControlePontos;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select idfunc , nomefunc ,cpf , codebar , sexo , cargo,datanasc,telefone from funcionario;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            } else
            {
                string buscar = "%" + txtbusca.Text + "%";
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ABACATE\SQLEXPRESS;Initial Catalog=ControlePontos;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();
                SqlCommand cmd = new SqlCommand("select idfunc , nomefunc ,cpf , codebar , sexo , cargo,datanasc,telefone from funcionario where idfunc like @busca ; ", con);
                cmd.Parameters.AddWithValue("@busca", buscar);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridView1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Controlelogin controle = new Controlelogin();
            controle.acessarponto(txtbusca.Text);
            if (txtbusca.Text != "")
            {
                if (controle.neew)
                {
                    Ftela__alteracao form = new Ftela__alteracao();
                    form.dadoUpdate(txtbusca.Text);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("codigo do funcionario incorreto");
                }
            }
            else
            {
                MessageBox.Show("selecione um funcionario");
            }

        }
    }
}
