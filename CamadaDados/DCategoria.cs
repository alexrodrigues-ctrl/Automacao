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
            set { _Nome=value; }
        }
        public string Descricao
        {
            get { return _Descricao; }
            set { _Descricao=value; }
        }
        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }
        //public string TextoBuscar1 { get => _TextoBuscar1; set => _TextoBuscar1 = value; }
        //public string Descricao1 { get => _Descricao; set => _Descricao = value; }
    }
}
