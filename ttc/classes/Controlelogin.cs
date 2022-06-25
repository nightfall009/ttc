using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttc.classes
{
    public class Controlelogin
    {
        public bool tem;
        public string mensagem = "";
        public bool neew;
        public bool pont =false;
        
        

        public bool acessar(string login, string senha)
        {
            Logindao logind = new Logindao();
            tem = logind.verificarlogin(login, senha);
            if (!logind.mensagem.Equals(""))
            {
                mensagem = logind.mensagem;
                
            }
            return tem;


        }

        public bool acessarponto(string codigo)
        {
            controledao ponto = new controledao();
            
        
            neew = ponto.verificarPonto(codigo);
            if (!ponto.mensagem.Equals(""))
            {
                mensagem = ponto.mensagem;

            }
            if (neew)
            {
                SqlCommand cmd = new SqlCommand();
                Conexao con = new Conexao();
                SqlDataReader dr;

                cmd.CommandText = "select * from ponto where idfunc = @codigo and saida = 0 ";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                try
                {
                    cmd.Connection = con.conectar();
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        pont = true;

                    }

                }
                catch (SqlException)
                {
                    this.mensagem = "Erro ";
                }
                return pont;
                
                con.desconectar();
                dr.Close();

            }
            
            return neew;


        }

    }
}
