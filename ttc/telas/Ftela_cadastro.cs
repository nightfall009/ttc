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
    public partial class Ftela_cadastro : Form
    {
        

        public Ftela_cadastro()
        {
            InitializeComponent();
        }

        private void imagefunc_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            imagefunc.ImageLocation = openFileDialog1.FileName;
        }

        private void btncancela_Click(object sender, EventArgs e)
        {
           
            txtnome.Text = "";
            txtcodigo.Text = "";
            txtsex.Text = "";
            cmbfun.Text = "";
            txtdata.Text = "" ;
            imagefunc.ImageLocation = "";
            txtfone.Text = "";
            txtcpf.Text = "";
        }

        private void btnsalva_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();
            string foto;
            foto = openFileDialog1.FileName;

            if (txtnome.Text != "")
              {if (txtcpf.Text != "   ,   ,   -")
                { if (txtsex.Text == "M" || txtsex.Text =="F")
                    {


                        cmd.CommandText = "insert into funcionario(nomefunc, codebar, sexo, cargo, datanasc, telefone, cpf, foto) values (  @nome , @codbar , @sexo , @cargo,@datanasc,@telefone,@cpf , @foto);";
                        cmd.Parameters.AddWithValue("@nome", txtnome.Text);
                        cmd.Parameters.AddWithValue("@codbar", txtcodigo.Text);
                        cmd.Parameters.AddWithValue("@sexo", txtsex.Text);
                        cmd.Parameters.AddWithValue("@cargo", cmbfun.Text);
                        cmd.Parameters.AddWithValue("@datanasc", txtdata.Text);
                        cmd.Parameters.AddWithValue("@foto", foto);
                        cmd.Parameters.AddWithValue("@telefone", txtfone.Text);
                        cmd.Parameters.AddWithValue("@cpf", txtcpf.Text);


                        cmd.Connection = con.conectar();
                        cmd.ExecuteNonQuery();
                        con.desconectar();

                        cmd.Connection = con.conectar();
                        cmd.CommandText = "SELECT TOP 1 idfunc,nomefunc, codebar, sexo, cargo, datanasc, telefone, cpf, foto from funcionario order by idfunc  DESC";
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            txtfuncio.Text = dr.GetValue(0).ToString();
                            txtnome.Text = dr.GetValue(1).ToString();
                            txtcodigo.Text = dr.GetValue(2).ToString();
                            txtsex.Text = dr.GetValue(3).ToString();
                            cmbfun.Text = dr.GetValue(4).ToString();
                            txtdata.Text = dr.GetValue(5).ToString();
                            imagefunc.ImageLocation = dr.GetValue(8).ToString();
                            txtfone.Text = dr.GetValue(6).ToString();
                            txtcpf.Text = dr.GetValue(7).ToString();
                        }
                        MessageBox.Show("cadastro feito com sucesso");
                        btnsalva.Enabled = false;
                        btnovo.Enabled = true  ;
                        btnlimpar.Enabled = false;
                        txtnome.Enabled = false;
                        txtcodigo.Enabled = false;
                        txtsex.Enabled = false;
                        cmbfun.Enabled = false;
                        txtdata.Enabled = false;
                        imagefunc.Enabled = false;
                        txtfone.Enabled = false;
                        txtcpf.Enabled = false;

                    }
                    else { MessageBox.Show("insira M ou F"); }
              }
              else { MessageBox.Show("insira um cpf "); }
            }
            else { MessageBox.Show("insira o nome do funcionario"); }
               
      


        }

        private void btnovo_Click(object sender, EventArgs e)
        {
            txtfuncio.Text = "";
            txtnome.Text = "";
            txtcodigo.Text = "";
            txtsex.Text = "";
            cmbfun.Text = "";
            txtdata.Text = "";
            imagefunc.ImageLocation = "";
            txtfone.Text = "";
            txtcpf.Text = "";
            btnlimpar.Enabled = true;
            btnsalva.Enabled = true;
            btnovo.Enabled = false;

            txtnome.Enabled = true;
            txtcodigo.Enabled = true;
            txtsex.Enabled = true;
            cmbfun.Enabled = true;
            txtdata.Enabled = true;
            imagefunc.Enabled = true;
            txtfone.Enabled = true;
            txtcpf.Enabled = true;


        }
    }
}
