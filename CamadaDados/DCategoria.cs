using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.CodeDom;

namespace CamadaDados
{
    class DCategoria
    {
        //propriedade
        private int _IdCategoria;
        private string _Nome;
        private string _Descricao;
        private string _TextoBuscar;
        //metodos get,set encapiculamento
        public int IdCategoria { get => _IdCategoria; set => _IdCategoria = value; }
        public string Nome { get => _Nome; set => _Nome = value; }
        public string Descricao { get => _Descricao; set => _Descricao = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

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
        
        }
        //metodo mostrar
        public DataTable Mostrar(DCategoria Categoria)
        {
        }
        //metodo excluir
        public string Excluir(DCategoria Categoria)
        {
        }
        //metodo buscarnome
        public string BuscarNome(DCategoria Categoria)
        {
        }
    }
}
