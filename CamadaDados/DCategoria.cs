using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.CodeDom;
using System.Data.SqlTypes;

namespace CamadaDados
{
    public class DCategoria
    {
        //propriedade
        private int _IdCategoria;
        private string _Nome;
        private string _Descricao;
        private string _TextoBuscar;
        //metodos get,set encapiculamento
        public int IdCategoria
        {
            get => _IdCategoria; 
            set => _IdCategoria = value;
        }
        public string Nome
        {
            get => _Nome;
            set => _Nome = value;
        }
        public string Descricao
        { 
            get => _Descricao;
            set => _Descricao = value;
        }
        public string TextoBuscar
        {
            get => _TextoBuscar;
            set => _TextoBuscar = value;
        }

        //costrutore vazio
        public DCategoria()
        {
        }
        //Construtor com os parametos 
        public DCategoria(int idcategoria, string nome, string descricao, string textobuscar)
        {
            this.IdCategoria = idcategoria;
            this.Nome = nome;
            this.Descricao = descricao;
            this.TextoBuscar = textobuscar;
        }
        //metodo inserir
        public string Inserir(DCategoria Categoria)
        {
            string resp="";
            //string connectionString = @"Data Source=ZATEC;Initial Catalog=dbcomercio;Integrated Security=True";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();
                                
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinserir_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCategoria = new SqlParameter();
                ParIdCategoria.ParameterName = "@idcategoria";
                ParIdCategoria.SqlDbType = SqlDbType.Int;
                ParIdCategoria.Direction = ParameterDirection.Output;

                SqlCmd.Parameters.Add(ParIdCategoria);
                //
                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@nome";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Categoria.Nome;

                SqlCmd.Parameters.Add(ParNome);
                //
                SqlParameter ParDescricao = new SqlParameter();
                ParDescricao.ParameterName = "@descricao";
                ParDescricao.SqlDbType = SqlDbType.VarChar;
                ParDescricao.Size = 100;
                ParDescricao.Value = Categoria.Descricao;

                SqlCmd.Parameters.Add(ParDescricao);
                
                //testar executar o camando
                resp=SqlCmd.ExecuteNonQuery()==1? "ok" :" nao teve registro";
                
            }
            catch (Exception ex)
            {
                resp = ex.Message;
                // ou //resp = "Erro ao conectar ao Banco de Dados";
            }
            finally
            {
                if (SqlCon.State==ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }
        //metodo editar
        public string Editar(DCategoria Categoria)
        {
            string resp = "";
            //string connectionString = @"Data Source=ZATEC;Initial Catalog=dbcomercio;Integrated Security=True";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCategoria = new SqlParameter();
                ParIdCategoria.ParameterName = "@idcategoria";
                ParIdCategoria.SqlDbType = SqlDbType.Int;
                ParIdCategoria.Value = Categoria.IdCategoria;

                SqlCmd.Parameters.Add(ParIdCategoria);
                //
                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@nome";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = Categoria.Nome;

                SqlCmd.Parameters.Add(ParNome);
                //
                SqlParameter ParDescricao = new SqlParameter();
                ParDescricao.ParameterName = "@descricao";
                ParDescricao.SqlDbType = SqlDbType.VarChar;
                ParDescricao.Size = 100;
                ParDescricao.Value = Categoria.Descricao;

                SqlCmd.Parameters.Add(ParDescricao);

                //testar executar o camando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "ok" : " nao editou registro";

            }
            catch (Exception ex)
            {
                //resp = ex.Message;
                resp = "Erro ao conectar ao Banco de Dados";
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }
        //metodo mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("categoria");
            //string connectionString = @"Data Source=ZATEC;Initial Catalog=dbcomercio;Integrated Security=True";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch(Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
        //metodo excluir
        public string Excluir(DCategoria Categoria)
        {
            string resp = "";
            //string connectionString = @"Data Source=ZATEC;Initial Catalog=dbcomercio;Integrated Security=True";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdeletar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCategoria = new SqlParameter();
                ParIdCategoria.ParameterName = "@idcategoria";
                ParIdCategoria.SqlDbType = SqlDbType.Int;
                ParIdCategoria.Value = Categoria.IdCategoria;

                SqlCmd.Parameters.Add(ParIdCategoria);
                
                //testar executar o camando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "ok" : " nao excluiu o registro";

            }
            catch (Exception ex)
            {
                //resp = ex.Message;
                resp = "Erro ao conectar ao Banco de Dados";
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }
        //metodo buscar nome
        public DataTable BuscarNome(DCategoria Categoria)
        {
            DataTable DtResultado = new DataTable("categoria");
            //string connectionString = @"Data Source=ZATEC;Initial Catalog=dbcomercio;Integrated Security=True";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_nome";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                
                //
                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Categoria.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);


            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
    }
}
