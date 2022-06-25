using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ttc.classes;

namespace ttc.classes
{
    internal class cadastro
    {
        public bool tem = false;
        public bool pont = false;
        public bool neew = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

      

        
    }
}
