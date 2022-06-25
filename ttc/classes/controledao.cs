using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttc.classes
{
     public class controledao
    {
      
        public bool neew = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;


        public bool verificarPonto(string codigo)
        {
            //comando sql se tem funcionario no banco
            cmd.CommandText = "select * from funcionario where idfunc = @codigo ";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    neew = true;
                }

            }
            catch (SqlException)
            {
                this.mensagem = "Erro ";
            }
            return neew;
            con.desconectar();
            dr.Close();
            
        }
    }
}
