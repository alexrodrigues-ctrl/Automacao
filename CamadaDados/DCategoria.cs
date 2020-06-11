using System;
using System.Collections.Generic;
using System.Text;
using System.Data; //habilita uso sql
using System.Data.SqlClient; // uso da sql

namespace CamadaDados
{
    class DCategoria //Classe Dados da Categoria
    {
        //criando as propriedades dos campos p/  chamar no DB-SQL p/ editar, insercao, etc
        private int _IdCategoria;
        private string _Nome;
        private string _Descricao;
        private string _TextoBuscar;
        //tratar, obter e setar as propriedade _IdCategoria, _Nome, _Descricao
        public int IdCategoria
        {
            get { return _IdCategoria; }
            set { _IdCategoria = value; }
        }
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }
        public string Descricao
        {
            get { return _Descricao; }
            set { _Descricao = value; }
        }
        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }
        //public string TextoBuscar1 { get => _TextoBuscar1; set => _TextoBuscar1 = value; }
        //public string Descricao1 { get => _Descricao; set => _Descricao = value; }

        //construtor vazio, todas as classes irao usar
        public DCategoria()
        {
        }
        //construtor c/ parametros p/ usar as variaveis do campo get, set das propriedades/ para realacionar os campos get,set das variaveis
        public DCategoria(int idcategoria, string nome, string descricao, string textobuscar)
        {
            this.IdCategoria = idcategoria;
            this.Nome = nome;
            this.Descricao = descricao;
            this.TextoBuscar = textobuscar;

        }
            //metodo INSERIR   --  (DCategoria Categoria')-> ficou assim variavel 'Categoria' que pertence a classe ''DCategoria''
        public string Inserir(DCategoria Categoria)
        {
                //uma var vazia, vou usar p/ resposta do tratamento de erro na conexao com o banco de dados
            string resp = "";
            
                //fazer conexao*
            SqlConnection SqlCon = new SqlConnection();

                //inicia a insercao
            SqlCommand SqlCmd = new SqlCommand(); //criar uma var p/ comando de insercao, ou seja, instanciando uma variavel com o nome SqlCmd
            SqlCmd.Connection = SqlCon; //minha conexao de SqlCmd recebe a cenexao do SqlCon
            SqlCmd.CommandText = "spinserir_categoria"; // a SqlCmd vai receber um texto, esse texto é o nome da PROCEDURE, lá SQL da query 'spinserir_categoria'. ou seja o comando de texto q vai ser passado para minha var SqlCmd vai ser justamente oque exitedentro do spinserir_categoria
            SqlCmd.CommandType = CommandType.StoredProcedure;  //executa um tipo de comando de procedure

                //pedir pra executar  as variaveis q ta dentro da procedure (@idcategoria int output, @nome varchar(50), @descricao varchar(100))
                //como inicia-las?
            SqlParameter ParIdcategoria= new SqlParameter(); //criando a instancia de ParIdcategoria
            ParIdcategoria.ParameterName = "@idcategoria"; //passando o nome p/ o paramento  ParIdcategoria
            ParIdcategoria.SqlDbType = SqlDbType.Int; //passando o tipo inteiro
            ParIdcategoria.Direction = ParameterDirection.Output; //passando a direcao 
                //ParIdcategoria.Value = Categoria.IdCategoria; //NÃO é necessario, pq o IdCategoria é AUTO-INCREMENTO

                //adicionado: criei a variavel e vamos adiocanar oa paramento.
            SqlCmd.Parameters.Add(ParIdcategoria); //dizendo aqui ao meu SqlCmd que será adicionado o vem lá do ParIdcategoria, que já tratamos tudo.

                //repetir o processo para nome
            SqlParameter ParNome = new SqlParameter();
            ParNome.ParameterName = "@nome"; 
            ParNome.SqlDbType = SqlDbType.VarChar; // @nome varchar(50)
            ParNome.Size = 50; //define o tamanho de caracteres definido procedure (@nome varchar(50))
            ParNome.Value = Categoria.Nome; //vai receber o valor  da varial string nome, ---> public string Nome { set { _Nome = value; }}

            SqlCmd.Parameters.Add(ParNome);

                //repetir o processo para descricao
            SqlParameter ParDescricao = new SqlParameter();
            ParDescricao.ParameterName =" @descricao";
            ParDescricao.SqlDbType = SqlDbType.VarChar;
            ParDescricao.Size = 100; // atencao aqui é o mesmo valor no Banco de Dados/ @descricao varchar(100)
            ParDescricao.Value = Categoria.Descricao;

            SqlCmd.Parameters.Add(ParDescricao);

                // testando execucao:
            resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "nao foi inserido";//aqui vou ver se gravou algo, ou seja =1, caso nao "nao foi gravado"    

            //tratar erro c/ try, catch e finally, caso ocorra ao abrir banco de dados* 
            try
            {
                    //fazer a conexao usndo a var string da classe Conexao: public static string Cn = "Data Source = DESKTOP-FAQGP0O; initial Catalog = dbcomercio; Integrated Security=true";
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open(); //abri a conexao
            }
            catch(Exception ex) //pegar uma exececao na var ex, caso falhe o try
            {
                    //resp = "Erro ao fazer a conexao com o banco de dados"; // ideal p/ avisa 
                resp = ex.Message; //aqui vai dizer qual erro do sistema ideal para corrigir
            }
            finally {
                    //fechar a conexao caso tenha sido aberta com sucesso no try, 
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); 
            }
        }
        //Metodo EDITAR
        public string Editar(DCategoria Categoria)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon; 
            SqlCmd.CommandText = "speditar_categoria";  //ATEÇÃO AQUI, agora é EDITAR, speditar_categoria
            SqlCmd.CommandType = CommandType.StoredProcedure;

            SqlParameter ParIdcategoria = new SqlParameter(); 
            ParIdcategoria.ParameterName = "@idcategoria"; // tem campo no procedure no banco?
            ParIdcategoria.SqlDbType = SqlDbType.Int;
            //ParIdcategoria.Direction = ParameterDirection.Output; //eu nao tenho Output na procedure para editar
            ParIdcategoria.Value = Categoria.IdCategoria; //pra editar vou basear no ID
            SqlCmd.Parameters.Add(ParIdcategoria);
            
            SqlParameter ParNome = new SqlParameter();
            ParNome.ParameterName = "@nome";
            ParNome.SqlDbType = SqlDbType.VarChar; 
            ParNome.Size = 50; 
            ParNome.Value = Categoria.Nome;
            SqlCmd.Parameters.Add(ParNome);

           
            SqlParameter ParDescricao = new SqlParameter();
            ParDescricao.ParameterName = " @descricao";
            ParDescricao.SqlDbType = SqlDbType.VarChar;
            ParDescricao.Size = 100;
            ParDescricao.Value = Categoria.Descricao;
            SqlCmd.Parameters.Add(ParDescricao);

            resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "nao foi editado";
            
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open(); 
            }
            catch (Exception ex) 
            {
                
                resp = ex.Message; 
            }
            finally
            {
                
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }


        }
        //METODO DELETAR
        public string Excluir(DCategoria Categoria)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "spdeletar_categoria";  
            SqlCmd.CommandType = CommandType.StoredProcedure;

            SqlParameter ParIdcategoria = new SqlParameter();
            ParIdcategoria.ParameterName = "@idcategoria"; 
            ParIdcategoria.SqlDbType = SqlDbType.Int;
            //ParIdcategoria.Direction = ParameterDirection.Output; //eu nao tenho Output na procedure para editar
            ParIdcategoria.Value = Categoria.IdCategoria; 
            SqlCmd.Parameters.Add(ParIdcategoria);

            //para excluir nao vou precicar dos paramentos NOME nem DESCRICAO, comentei todos ABAIXO

            //SqlParameter ParNome = new SqlParameter();
            //ParNome.ParameterName = "@nome";
            //ParNome.SqlDbType = SqlDbType.VarChar;
            //ParNome.Size = 50;
            //ParNome.Value = Categoria.Nome;
            //SqlCmd.Parameters.Add(ParNome);


            //SqlParameter ParDescricao = new SqlParameter();
            //ParDescricao.ParameterName = " @descricao";
            //ParDescricao.SqlDbType = SqlDbType.VarChar;
            //ParDescricao.Size = 100;
            //ParDescricao.Value = Categoria.Descricao;
            //SqlCmd.Parameters.Add(ParDescricao);

            resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "nao foi excluido";

            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();
            }
            catch (Exception ex)
            {

                resp = ex.Message;
            }
            finally
            {

                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        //METODO MOSTRAR
        public DataTable Mostrar(DCategoria Categoria) //pq DataTable? pq sera mostrado numa tabela
        {
                //aqui vai um pouco difernte, pq vamos precisar de um datatable.
            DataTable DtResultado = new DataTable("categoria"); //ao instaciar quero um objeto do tipo "categoria" seria o nome da tabela que vamos trabalhar
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);//precisa para guardar ou exibir numa tabela, 

            } catch { } finally { }

            
            
        }
        public string BuscarNome(DCategoria Categoria)
        {
            
        }
        
    }
    
}


