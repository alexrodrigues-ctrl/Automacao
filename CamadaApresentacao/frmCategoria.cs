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
        //Meu METODO HABILITAR txt_box true/false
        private void MeuHabilitar()
        {
            this.txt_Nome.Enabled = true; 
            this.txt_IdCategoria.Enabled = false;
            this.txt_Descricao.Enabled = true;
        }
        //metodo habilitar txt_box boleano /// apenas leitura ou nao
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
                this.btn_Salvar.Enabled = true;
                this.btn_Editar.Enabled = false;
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
            //
            this.BuscarNome();
            //
            this.Top=0;
            this.Left=0;
            this.Habilitar(false);
            this.Botoes();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eEditar = false;
            this.Botoes();
            this.Limpar();
            this.Habilitar(true);
            //this.MeuHabilitar(); //para usar este Meu Metodo os txt Enabled = false no frmCategoria 
            txt_Nome.Focus();
            this.txt_IdCategoria.Enabled = false;

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if (this.txt_Nome.Text == string.Empty)
                {
                    MessagemErro("Preencha todos os Campos");
                    errorIcone.SetError(txt_Nome, "Insira o nome");
                }
                else
                {
                    if (this.eNovo)
                    {
                        resp = NCategoria.Inserir(this.txt_Nome.Text.Trim().ToUpper(), this.txt_Descricao.Text.Trim());
                    }
                    else
                    {
                        resp = NCategoria.Editar(Convert.ToInt32(this.txt_IdCategoria.Text), this.txt_Nome.Text.Trim().ToUpper(), this.txt_Descricao.Text.Trim());
                    }
                    if (resp.Equals("OK")) //resp é igual "OK"
                    {
                        if (this.eNovo) //se estou em novo 
                        {
                            this.MessagemOK("Registro Salvo com sucesso!");
                        }
                        else //entao estou em ediçao
                        {
                            this.MessagemOK("Registro Editado com sucesso");
                        }
                    }
                    else
                    {
                        this.MessagemErro(resp); //resp=SqlCmd.ExecuteNonQuery()==1? "OK" :" Registro não foi Inserido"; //de DCategoria
                    }
                    ////agora se inseriu ou editou
                    this.eNovo = false;
                    this.eEditar = false;
                    this.Botoes();
                    this.Limpar();
                    this.MostrarGrid();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace); // messgem de detalhamento de erro pro programador
            }
        }

        private void dataGridView_Lista_DoubleClick(object sender, EventArgs e)
        {
            //minha txt vai receber o conteudo da linha corrente da grid (q é os dados do BD), mais uma celula específica (id, nome ou outra) só q o VALOR
            this.txt_IdCategoria.Text = Convert.ToString(this.dataGridView_Lista.CurrentRow.Cells["idcategoria"].Value);
            this.txt_Nome.Text = Convert.ToString(this.dataGridView_Lista.CurrentRow.Cells["nome"].Value);
            this.txt_Descricao.Text = Convert.ToString(this.dataGridView_Lista.CurrentRow.Cells["descricao"].Value);

            //chamar a aba (tab) p/ edicao - primeira aba é a 0 (Lista de categoria) e a segunda aba é a 1 (Configuração)
            this.tabControl1.SelectedIndex = 1;
        }
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (this.txt_IdCategoria.Text.Equals(""))
            {
                this.MessagemErro("Selecione um registro para Edição!");
            }
            else
            {
                this.eEditar = true;
                this.Botoes();
                this.Habilitar(true);
            }
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.eNovo = false;
            this.eEditar = false;
            this.Botoes();
            this.Habilitar(false);
            this.Limpar();
        }
    }  
}
