namespace frmCategoria
{
    partial class frmcategoria
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbtexto = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkDeletar = new System.Windows.Forms.CheckBox();
            this.lbTotalRegistro = new System.Windows.Forms.Label();
            this.DataGridCategoria = new System.Windows.Forms.DataGridView();
            this.Deletar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnDeletarLista = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxCategoria = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtDescricacaoCategoria = new System.Windows.Forms.TextBox();
            this.txtNomeCotegoria = new System.Windows.Forms.TextBox();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.lbDescricacao = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lb_IdCategoria = new System.Windows.Forms.Label();
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensagem = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCategoria)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBoxCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtexto
            // 
            this.lbtexto.AutoSize = true;
            this.lbtexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtexto.Location = new System.Drawing.Point(12, 9);
            this.lbtexto.Name = "lbtexto";
            this.lbtexto.Size = new System.Drawing.Size(96, 20);
            this.lbtexto.TabIndex = 1;
            this.lbtexto.Text = "Categorias";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(605, 341);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkDeletar);
            this.tabPage1.Controls.Add(this.lbTotalRegistro);
            this.tabPage1.Controls.Add(this.DataGridCategoria);
            this.tabPage1.Controls.Add(this.btnImprimir);
            this.tabPage1.Controls.Add(this.btnDeletarLista);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(597, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkDeletar
            // 
            this.chkDeletar.AutoSize = true;
            this.chkDeletar.Location = new System.Drawing.Point(8, 47);
            this.chkDeletar.Name = "chkDeletar";
            this.chkDeletar.Size = new System.Drawing.Size(60, 17);
            this.chkDeletar.TabIndex = 7;
            this.chkDeletar.Text = "Deletar";
            this.chkDeletar.UseVisualStyleBackColor = true;
            // 
            // lbTotalRegistro
            // 
            this.lbTotalRegistro.AutoSize = true;
            this.lbTotalRegistro.Location = new System.Drawing.Point(479, 51);
            this.lbTotalRegistro.Name = "lbTotalRegistro";
            this.lbTotalRegistro.Size = new System.Drawing.Size(112, 13);
            this.lbTotalRegistro.TabIndex = 6;
            this.lbTotalRegistro.Text = "Total de Registro: 000";
            // 
            // DataGridCategoria
            // 
            this.DataGridCategoria.AllowUserToAddRows = false;
            this.DataGridCategoria.AllowUserToDeleteRows = false;
            this.DataGridCategoria.AllowUserToOrderColumns = true;
            this.DataGridCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deletar});
            this.DataGridCategoria.Location = new System.Drawing.Point(6, 67);
            this.DataGridCategoria.MultiSelect = false;
            this.DataGridCategoria.Name = "DataGridCategoria";
            this.DataGridCategoria.ReadOnly = true;
            this.DataGridCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridCategoria.Size = new System.Drawing.Size(585, 228);
            this.DataGridCategoria.TabIndex = 5;
            // 
            // Deletar
            // 
            this.Deletar.HeaderText = "Deletar";
            this.Deletar.Name = "Deletar";
            this.Deletar.ReadOnly = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(422, 12);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnDeletarLista
            // 
            this.btnDeletarLista.Location = new System.Drawing.Point(341, 12);
            this.btnDeletarLista.Name = "btnDeletarLista";
            this.btnDeletarLista.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarLista.TabIndex = 3;
            this.btnDeletarLista.Text = "Deletar";
            this.btnDeletarLista.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(75, 14);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(179, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOME:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(260, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxCategoria);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(597, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configurações";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxCategoria
            // 
            this.groupBoxCategoria.Controls.Add(this.btnCancelar);
            this.groupBoxCategoria.Controls.Add(this.btnEditar);
            this.groupBoxCategoria.Controls.Add(this.btnSalvar);
            this.groupBoxCategoria.Controls.Add(this.btnNovo);
            this.groupBoxCategoria.Controls.Add(this.txtDescricacaoCategoria);
            this.groupBoxCategoria.Controls.Add(this.txtNomeCotegoria);
            this.groupBoxCategoria.Controls.Add(this.txtIdCategoria);
            this.groupBoxCategoria.Controls.Add(this.lbDescricacao);
            this.groupBoxCategoria.Controls.Add(this.lbNome);
            this.groupBoxCategoria.Controls.Add(this.lb_IdCategoria);
            this.groupBoxCategoria.Location = new System.Drawing.Point(19, 20);
            this.groupBoxCategoria.Name = "groupBoxCategoria";
            this.groupBoxCategoria.Size = new System.Drawing.Size(572, 289);
            this.groupBoxCategoria.TabIndex = 0;
            this.groupBoxCategoria.TabStop = false;
            this.groupBoxCategoria.Text = "Categoria";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(367, 196);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(274, 196);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(176, 196);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(85, 196);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // txtDescricacaoCategoria
            // 
            this.txtDescricacaoCategoria.Location = new System.Drawing.Point(86, 106);
            this.txtDescricacaoCategoria.Multiline = true;
            this.txtDescricacaoCategoria.Name = "txtDescricacaoCategoria";
            this.txtDescricacaoCategoria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricacaoCategoria.Size = new System.Drawing.Size(356, 84);
            this.txtDescricacaoCategoria.TabIndex = 5;
            // 
            // txtNomeCotegoria
            // 
            this.txtNomeCotegoria.Location = new System.Drawing.Point(86, 75);
            this.txtNomeCotegoria.Name = "txtNomeCotegoria";
            this.txtNomeCotegoria.Size = new System.Drawing.Size(356, 20);
            this.txtNomeCotegoria.TabIndex = 4;
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Location = new System.Drawing.Point(86, 40);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtIdCategoria.TabIndex = 3;
            // 
            // lbDescricacao
            // 
            this.lbDescricacao.AutoSize = true;
            this.lbDescricacao.Location = new System.Drawing.Point(13, 113);
            this.lbDescricacao.Name = "lbDescricacao";
            this.lbDescricacao.Size = new System.Drawing.Size(67, 13);
            this.lbDescricacao.TabIndex = 2;
            this.lbDescricacao.Text = "Descricação";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(17, 78);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome:";
            // 
            // lb_IdCategoria
            // 
            this.lb_IdCategoria.AutoSize = true;
            this.lb_IdCategoria.Location = new System.Drawing.Point(17, 47);
            this.lb_IdCategoria.Name = "lb_IdCategoria";
            this.lb_IdCategoria.Size = new System.Drawing.Size(40, 13);
            this.lb_IdCategoria.TabIndex = 0;
            this.lb_IdCategoria.Text = "Código";
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // ttMensagem
            // 
            this.ttMensagem.IsBalloon = true;
            // 
            // frmcategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 400);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbtexto);
            this.Name = "frmcategoria";
            this.Text = "Controle de Categorias";
            this.Load += new System.EventHandler(this.frmcategoria_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCategoria)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBoxCategoria.ResumeLayout(false);
            this.groupBoxCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbtexto;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnDeletarLista;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbTotalRegistro;
        private System.Windows.Forms.DataGridView DataGridCategoria;
        private System.Windows.Forms.CheckBox chkDeletar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Deletar;
        private System.Windows.Forms.GroupBox groupBoxCategoria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtDescricacaoCategoria;
        private System.Windows.Forms.TextBox txtNomeCotegoria;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.Label lbDescricacao;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lb_IdCategoria;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.ToolTip ttMensagem;
    }
}

