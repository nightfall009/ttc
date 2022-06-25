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
    public partial class telacha : Form
    {


        string cod ;
        
        



        public telacha()
        {
           
        
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
        public void codigoGET(string codigo)
        {
            cod = codigo.ToString();
            Form1 form = new Form1();
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();
            cmd.Connection = con.conectar();
            cmd.CommandText = "select top 1 data,horaentrada,horasaida,saida from ponto where idfunc = @codigo ORDER BY Idponto DESC ;";
            cmd.Parameters.AddWithValue("@codigo", cod);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lbldata.Text = dr.GetValue(0).ToString();
                //se mostrar a horasaida ou a horaentrada
                if (dr.GetValue(3).Equals(true))
                {
                    lblhora.Text = dr.GetValue(2).ToString();
                    lblensa.Visible = true;
                }
                else
                {
                    lblhora.Text = dr.GetValue(1).ToString();
                    label2.Visible = true;
                }
            }
            dr.Close();
            con.desconectar();
            Conexao conn = new Conexao();

            cmd.Connection = con.conectar();
            cmd.CommandText = "select nomefunc,foto from funcionario where idfunc = @func; ";
            cmd.Parameters.AddWithValue("@func", cod);

            SqlDataReader dm = cmd.ExecuteReader();
            while (dm.Read())
            {
                txtnome.Text = dm.GetValue(0).ToString();
                imagefunc.ImageLocation = dm.GetValue(1).ToString();
            }
            dm.Close();
            con.desconectar();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imagefunc_Click(object sender, EventArgs e)
        {

        }

        private void lblhora_Click(object sender, EventArgs e)
        {

        }

        private void lblfunc_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbldata_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblensa_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblteste_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
