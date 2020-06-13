using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaNegocio; //referenciando a camadanegocio a este form, vou precisar de funcoes dentro desta camada

namespace frmCategoria
{
    public partial class frmcategoria : Form
    {
        private bool eNovo = false; //vou usar p/ saber se estou entrando em estado, NOVO ou Edição.
        private bool eEditar = false;

        public frmcategoria()
        {
            InitializeComponent();
            //passando uma instrucao p/ usuario em balao ToolTip, do que preencher nestes campos.
            this.ttMensagem.SetToolTip(this.txtNomeCotegoria, "Insira o Nome da Categoria.");
            this.ttMensagem.SetToolTip(this.txtIdCategoria, "Insira o Código da Categoria.");
            this.ttMensagem.SetToolTip(this.txtDescricacaoCategoria, "Insira a descrição da Categoria.");
                        
        }
        //metodo mensagem de sucesso p/ usar sempre q quiser avisar q algo deu certo,
        private void MensagemOK(string mensagem)
        {
            MessageBox.Show(mensagem, "Automação Comercial", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //metodo mensagem de erro
        private void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Automação Comercial",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        //metodo limpar campos (componete textbox)
        private void LimpaCampo()
        {
            this.txtNomeCotegoria.Text = string.Empty;
            this.txtIdCategoria.Text = string.Empty;
            this.txtDescricacaoCategoria.Text = string.Empty;
        }
        //metodo habilitar campos(textbox)
        private void habilitaCampos(bool valor) 
        {
            //campos apenas em leitura
            this.txtNomeCotegoria.ReadOnly = !valor;
            this.txtIdCategoria.ReadOnly = !valor;
            this.txtDescricacaoCategoria.ReadOnly = !valor;
        }
        //metodo habilitar botoes
        private void habilitarbotoes() 
        {
            //se eNovo ou eEditar for verdadeiro, estou em modo de digitacao.
            if (this.eNovo || this.eEditar)
            {
                //meu metodo for verdadeiro, o metodo NÃO estar em modo apenas leitura. posso digitar
                this.habilitaCampos(true); //habilito meus campos
                this.btnNovo.Enabled = false;
                this.btnSalvar.Enabled = true; //todos esses é uma questao de saber quem deve tá false ou true nesse caso.
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                //meu metodo for falso, o metodo Estar em modo apenas leitura. Não posso digitar
                this.habilitaCampos(true); //NÃO habilito meus campos
                this.btnNovo.Enabled = true;
                this.btnSalvar.Enabled = false; //todos esses é uma questao de saber quem deve tá false ou true nesse caso.
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            } 
        }
        //metodo ocultar colunas
        private void OcultarColuna()
        {
                // os indices começam a conta de zero, ou seja, 0,1,2,3,4 
            this.DataGridCategoria.Columns[0].Visible = false; //indice zero, 1ª coluna, este qui é a coluna deletar
            this.DataGridCategoria.Columns[1].Visible = false;//indice um, 2ª coluna, este aqui é a coluna código        
        }
        //metdo mostrar o DataGridCategoria, a tabela
        private void MostrarDataGridCategoria()
        {
            //aqui chamo na DataGridCategoria com o DataSource o metodo Mostrar() q ta na CamadaNegocio na classe NCategoria
            this.DataGridCategoria.DataSource = NCategoria.Mostrar();
            this.OcultarColuna();//chamar o metodo p/ ocultar as colunas
            //mostra na label Total de Registro(lbTotalRegistro), quantos registro na tabela.
            lbTotalRegistro.Text = "Total de registro: " + Convert.ToString(DataGridCategoria.Rows.Count); 
        }
        private void frmcategoria_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.MostrarDataGridCategoria();
            this.habilitaCampos(false);
            this.habilitarbotoes();
        }
    }
}
