using ttc.classes;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ttc
{
    public partial class Form1 : Form
    {
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        public string codigo;
        
        
       

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            button5.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = false;
            txtcod.Enabled = false;
            button7.Enabled = false;



        }

    

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
            groupBox1.Visible = false;
            txtlogadm.Text = "";
            txtlogs.Text = "";
            button5.Enabled = true;
            button1.Enabled = true;       
            button3.Enabled = true;
            txtcod.Enabled = true;
            button7.Enabled = true;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
                Controlelogin controle = new Controlelogin();
                controle.acessar(txtlogadm.Text, txtlogs.Text);
                if (controle.tem)
                {
                   
                    telaconfig novatela = new telaconfig();
                    novatela.Show();
                   txtlogadm.Text = "";
                   txtlogs.Text = "";

            }
                else
                {
                    MessageBox.Show("login ou senha incorreta", "erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
                Controlelogin controle = new Controlelogin();
                controle.acessarponto(txtcod.Text);
            if (txtcod.Text != ""){
                if (controle.neew) {

                    if (controle.pont)
                    {
                        SqlCommand cmd = new SqlCommand();
                        Conexao con = new Conexao();

                            cmd.CommandText = "update ponto set horasaida = getdate(),saida = 1 where idfunc = @func and saida = 0;";
                            cmd.Parameters.AddWithValue("@func", int.Parse(txtcod.Text));
                            
                                cmd.Connection = con.conectar();
                                cmd.ExecuteNonQuery();

                                con.desconectar();
                            
                              telacha novaform = new telacha();
                              novaform.codigoGET(txtcod.Text);
                              novaform.Show();
                    }else{
                        SqlCommand cmd = new SqlCommand();
                        Conexao con = new Conexao();

                        cmd.CommandText = "insert into ponto (idfunc,horasaida) Values (@func, null);";
                        cmd.Parameters.AddWithValue("@func", int.Parse(txtcod.Text));

                        cmd.Connection = con.conectar();
                        cmd.ExecuteNonQuery();

                        con.desconectar();

                        telacha novaform = new telacha();
                        novaform.codigoGET(txtcod.Text);
                        novaform.Show();
                        }
                }else{
                    MessageBox.Show("codigo do funcionario incorreta","erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                     }
            }else{
                lblcode.ForeColor = Color.Red;
                timer1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblcode.ForeColor = Color.Black;
            timer1.Enabled = false;
        }
    }
}