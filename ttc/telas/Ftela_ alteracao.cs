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
    public partial class Ftela__alteracao : Form
    {

         public string idfunc = "";
        public Ftela__alteracao()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void dadoUpdate(string codigo)
        {
            idfunc = codigo;
            Conexao conn = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn.conectar();
            cmd.CommandText = "select idfunc, nomefunc, codebar , sexo, cargo,datanasc,foto,telefone, cpf from funcionario where idfunc= @func; ";
            cmd.Parameters.AddWithValue("@func", idfunc);

            SqlDataReader dm = cmd.ExecuteReader();
            while (dm.Read())
            {
                txtfuncio.Text = dm.GetValue(0).ToString();
                txtnome.Text = dm.GetValue(1).ToString();
                txtcodigo.Text = dm.GetValue(2).ToString();
                txtsex.Text = dm.GetValue(3).ToString();
                cmbfun.Text = dm.GetValue(4).ToString();
                txtdata.Text = dm.GetValue(5).ToString();
                imagefunc.ImageLocation = dm.GetValue(6).ToString();
                txtfone.Text = dm.GetValue(7).ToString();
                txtcpf.Text = dm.GetValue(8).ToString();
            }




            dm.Close();
            conn.desconectar();

            cmd.Connection = conn.conectar();
            cmd.CommandText = "select idponto, data , horaentrada , horasaida from ponto where idfunc = @idfunc ; ";
            cmd.Parameters.AddWithValue("@idfunc", idfunc);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.desconectar();

        }
        public void reaload()
        {
            Conexao conn = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn.conectar();
            cmd.CommandText = "select idponto, data , horaentrada , horasaida from ponto where idfunc = @idfunc ; ";
            cmd.Parameters.AddWithValue("@idfunc", idfunc);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.desconectar();

        }
        private void imagefunc_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            imagefunc.ImageLocation = openFileDialog1.FileName;
        }

        private void txtfone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
   

        private void Ftela__alteracao_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();



         
            cmd.CommandText = "update funcionario set nomefunc = @nome, codebar = @codbar , sexo = @sexo ,datanasc = @datanasc , foto = @foto,  telefone= @telefone, cpf= @cpf where idfunc = @idfunc";
            cmd.Parameters.AddWithValue("@nome", txtnome.Text);
            cmd.Parameters.AddWithValue("@codbar", txtcodigo.Text);
            cmd.Parameters.AddWithValue("@sexo",  txtsex.Text);
            cmd.Parameters.AddWithValue("@cargo", cmbfun.Text);
            cmd.Parameters.AddWithValue("@datanasc", txtdata.Text);
            cmd.Parameters.AddWithValue("@foto", imagefunc.ImageLocation.ToString());
            cmd.Parameters.AddWithValue("@telefone", txtfone.Text);
            cmd.Parameters.AddWithValue("@cpf", txtcpf.Text);
            cmd.Parameters.AddWithValue("@idfunc", txtfuncio.Text);

            cmd.Connection = con.conectar();
            cmd.ExecuteNonQuery();
            con.desconectar();


            MessageBox.Show("alteração feito com sucesso");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("deseja excluir mesmo ", "deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {

                SqlCommand cmd = new SqlCommand();
                Conexao con = new Conexao();
                con.desconectar();
                cmd.Connection = con.conectar();



                cmd.CommandText = "delete ponto where Idponto = @idp;";
                cmd.Parameters.AddWithValue("@idp", txtidp.Text);

                cmd.ExecuteNonQuery();
                con.desconectar();
                MessageBox.Show("deletado com sucesso");
                reaload();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

                string mensagem = "";
                SqlCommand cmd = new SqlCommand();
                Conexao con = new Conexao();
                con.desconectar();
                cmd.Connection = con.conectar();

            if (txtsaida.Text != "")
            {

                cmd.CommandText = @"update ponto set data = @datap , horaentrada = @horaent, horasaida = @horasai where idponto = @idp";
                cmd.Parameters.AddWithValue("@datap", txtdatap.Text);
                cmd.Parameters.AddWithValue("@horaent", txtentrada.Text);
                cmd.Parameters.AddWithValue("@horasai", txtsaida.Text);
                cmd.Parameters.AddWithValue("@idp", int.Parse(txtidp.Text));
                try
                {


                    cmd.ExecuteNonQuery();
                    con.desconectar();

                    MessageBox.Show("alteração feito com sucesso");
                    reaload();
                }
                catch (SqlException)
                {
                    mensagem = " Erro com banco de dados";
                }
                
            }
            else
            {
              
                con.desconectar();
                cmd.Connection = con.conectar();

                string saida = "00:00:00";
                cmd.CommandText = @"update ponto set data = @datap , horaentrada = @horaent, horasaida = @horasai, saida = 0 where idponto = @idp";
                cmd.Parameters.AddWithValue("@datap", txtdatap.Text);
                cmd.Parameters.AddWithValue("@horaent", txtentrada.Text);
                cmd.Parameters.AddWithValue("@horasai", txtsaida.Text);
                cmd.Parameters.AddWithValue("@idp", int.Parse(txtidp.Text));
                try
                {


                    cmd.ExecuteNonQuery();
                    con.desconectar();

                    MessageBox.Show("alteração feito com sucesso");
                    reaload();
                }
                catch (SqlException)
                {
                    mensagem = " Erro com banco de dados";
                }

            }
            if (mensagem != "")
            {
                MessageBox.Show(mensagem, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("deseja excluir mesmo", "deletar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();
                Conexao con = new Conexao();

                cmd.Connection = con.conectar();
                cmd.CommandText = "delete ponto where idfunc = @idf;";
                cmd.Parameters.AddWithValue("@idf", idfunc);

                cmd.ExecuteNonQuery();
                con.desconectar();

                cmd.Connection = con.conectar();
                cmd.CommandText = "delete funcionario where Idfunc = @idfunc;";
                cmd.Parameters.AddWithValue("@idfunc", idfunc);

                cmd.ExecuteNonQuery();
                con.desconectar();



                MessageBox.Show("funcinario excluido com sucesso");
                this.Close();
            }
            


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtidp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            txtnome.Enabled = true;
            txtcodigo.Enabled = true;
            txtsex.Enabled = true;
            cmbfun.Enabled = true;
            txtdata.Enabled = true;
            imagefunc.Enabled = true;
            txtfone.Enabled = true;
            txtcpf.Enabled = true;
            btnsalvar.Enabled = true;
        }
    }
}
