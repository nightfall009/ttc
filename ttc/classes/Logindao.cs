using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttc.classes;

namespace ttc
{
     class Logindao
    {
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool verificarlogin(string login,string senha)
        {
            //comando sql se tem login banco
            cmd.CommandText = "select * from loginadm where loginadm = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }

            }
            catch (SqlException)
            {
                this.mensagem = "Erro com banco de dados";
            }

            con.desconectar();
            dr.Close();
            return tem;
        }

      

       

    }
}
