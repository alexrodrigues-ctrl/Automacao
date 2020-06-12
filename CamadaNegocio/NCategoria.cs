using System;
using System.Collections.Generic;
using System.Text;
using System.Data; //vou usar o BD
using CamadaDados; //vou precisa p/ instanciar um obejo da CamadaDados.

namespace CamadaNegocio
{
    public class NCategoria
    {
        //metodo inserir
        public static string Inserir(string nome, string descricao) //em inserir tem os dados nome e descricao
        {
            DCategoria Obj = new CamadaDados.DCategoria();
            Obj.Nome = nome;
            Obj.Descricao = descricao;
            return Obj.Inserir(Obj); //tem q retorno pq o metodo é tipo string (se fosse void nao precisava ter retorno) e retorno o Obj.Inserir(Obj) pq OBJ é o proprio DCategoria
        }
        //metodo editar
        public static string Editar(int idcategoria, string nome, string descricao)
        {
            DCategoria Obj = new CamadaDados.DCategoria();
            Obj.IdCategoria = idcategoria;
            Obj.Nome = nome;
            Obj.Descricao = descricao;
            return Obj.Editar(Obj);
        }
        //metdo excluir
        public static string Excluir(int idcategoria)
        {
            DCategoria Obj = new CamadaDados.DCategoria();
            Obj.IdCategoria = idcategoria;
            return Obj.Excluir(Obj);
        }
        //metodo mostrar
        public static DataTable Mostrar() //sempre que for trabalhar com tabela, listbox, grid usar  o DataTable
        {
            return new DCategoria().Mostrar(); // somente retornar o metodo CamadaDados.Mostrar()
        }
        //metodo Busca Nome
        public static DataTable BuscarNone(string textonome) 
        {
            DCategoria Obj = new DCategoria();
            Obj.TextoBuscar = textonome;
            return Obj.BuscarNome(Obj);
        }
    }
}
