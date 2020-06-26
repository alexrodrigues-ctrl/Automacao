using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaNegocio;
using System.Data.SqlClient;

namespace CamadaApresentacao
{
    public partial class frmCategoria : Form
    {
        private bool eNovo = false;
        private bool eEditar = false;
        public frmCategoria()
        {
            InitializeComponent();
            this.toolTip_mensagem.SetToolTip(this.txt_Nome, "Insira o Nome da Categoria");
        }
        //metodo messagemOK
        private void MessagemOK(string message)
        {
            MessageBox.Show(message,"Sistema Zatec",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        //metodo messagemErro
        private void MessagemErro(string message)
        {
            MessageBox.Show(message, "Sistema Zatec", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //metodo limpar campos
        private void Limpar()
        {
            this.txt_Nome.Text = string.Empty;
            this.txt_IdCategoria.Text = string.Empty;
            this.txt_Descricao.Text = string.Empty;
        }
        //metodo habilitar txt_box
        private void Habilitar(bool valor)
        {
            this.txt_Nome.ReadOnly = !valor;
            this.txt_IdCategoria.ReadOnly = !valor;
            this.txt_Descricao.ReadOnly = !valor;
        }
        //metodo habilitar botoes
        private void Botoes()
        {
            if (this.eNovo || this.eEditar)
            {
                this.Habilitar(true);
                this.btn_Novo.Enabled = false;
                this.btn_Editar.Enabled = false;
                this.btn_Salvar.Enabled = true;
                this.btn_Cancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btn_Novo.Enabled = true;
                this.btn_Editar.Enabled = true;
                this.btn_Salvar.Enabled = false;
                this.btn_Cancelar.Enabled = false;
            }            
        }
        //metodo ocultar colunas do grid
        private void OcultarColunas()
        {
            this.dataGridView_Lista.Columns[0].Visible = false;
            this.dataGridView_Lista.Columns[1].Visible = false;
        }
        //metodo Mostrar itens da tabela
        private void MostrarGrid()
        {
            this.dataGridView_Lista.DataSource = NCategoria.Mostrar();
            this.OcultarColunas();
            lb_TotalResgistro.Text = "Total de Registro encontrado: " + Convert.ToString(dataGridView_Lista.Rows.Count);
        }
        //metodo Buscar pelo Nome
        private void BuscarNome()
        {
            this.dataGridView_Lista.DataSource = NCategoria.BuscarNome(this.txt_Buscar.Text);
           //MessageBox.Show("teste");
            this.OcultarColunas();
            lb_TotalResgistro.Text = "Total de Registro encontrado: " + Convert.ToString(dataGridView_Lista.Rows.Count);
        }
        private void frmCategoria_Load(object sender, EventArgs e)
        {
            //string conexao = @"Data Source=ZATEC\SQLEXPRESS;Initial Catalog=dbcomercio;Integrated Security=True"; 
            //SqlConnection sqlconn = new SqlConnection(conexao);
            //sqlconn.Open();
            //if (sqlconn.State == ConnectionState.Open)
            //{
            //    MessageBox.Show("abriu o bd");
            //}
            //else { MessageBox.Show("NAO abriu o bd"); }
            this.Top=0;
            this.Left=0;
            this.Habilitar(false);
            this.Botoes();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            this.BuscarNome();
            //MessageBox.Show("botao Buscar");

        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNome();
            //MessageBox.Show("txt buscar");
        }
    }
}
