using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;

namespace CamadaDados
{
    public class Conexao
    {
        public static string Cn = "Data Source=ZATEC\\SQLEXPRESS;Initial Catalog=dbcomercio;Integrated Security=True";
    }
}
