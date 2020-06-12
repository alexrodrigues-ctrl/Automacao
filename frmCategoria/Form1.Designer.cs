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
            this.lbtexto = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnDeletarLista = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dvgCategoria = new System.Windows.Forms.DataGridView();
            this.lbTotalRegistro = new System.Windows.Forms.Label();
            this.chkDeletar = new System.Windows.Forms.CheckBox();
            this.Deletar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBoxCategoria = new System.Windows.Forms.GroupBox();
            this.lb_IdCategoria = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbDescricacao = new System.Windows.Forms.Label();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.txtNomeCotegoria = new System.Windows.Forms.TextBox();
            this.tctDescricacaoCategoria = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCategoria)).BeginInit();
            this.groupBoxCategoria.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.dvgCategoria);
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
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(260, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
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
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(75, 14);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(179, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // btnDeletarLista
            // 
            this.btnDeletarLista.Location = new System.Drawing.Point(363, 11);
            this.btnDeletarLista.Name = "btnDeletarLista";
            this.btnDeletarLista.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarLista.TabIndex = 3;
            this.btnDeletarLista.Text = "Deletar";
            this.btnDeletarLista.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(461, 12);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.button3_Click);
            // 
            // dvgCategoria
            // 
            this.dvgCategoria.AllowUserToAddRows = false;
            this.dvgCategoria.AllowUserToDeleteRows = false;
            this.dvgCategoria.AllowUserToOrderColumns = true;
            this.dvgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deletar});
            this.dvgCategoria.Location = new System.Drawing.Point(21, 67);
            this.dvgCategoria.MultiSelect = false;
            this.dvgCategoria.Name = "dvgCategoria";
            this.dvgCategoria.ReadOnly = true;
            this.dvgCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCategoria.Size = new System.Drawing.Size(515, 228);
            this.dvgCategoria.TabIndex = 5;
            // 
            // lbTotalRegistro
            // 
            this.lbTotalRegistro.AutoSize = true;
            this.lbTotalRegistro.Location = new System.Drawing.Point(424, 51);
            this.lbTotalRegistro.Name = "lbTotalRegistro";
            this.lbTotalRegistro.Size = new System.Drawing.Size(112, 13);
            this.lbTotalRegistro.TabIndex = 6;
            this.lbTotalRegistro.Text = "Total de Registro: 000";
            // 
            // chkDeletar
            // 
            this.chkDeletar.AutoSize = true;
            this.chkDeletar.Location = new System.Drawing.Point(21, 44);
            this.chkDeletar.Name = "chkDeletar";
            this.chkDeletar.Size = new System.Drawing.Size(60, 17);
            this.chkDeletar.TabIndex = 7;
            this.chkDeletar.Text = "Deletar";
            this.chkDeletar.UseVisualStyleBackColor = true;
            // 
            // Deletar
            // 
            this.Deletar.HeaderText = "Deletar";
            this.Deletar.Name = "Deletar";
            this.Deletar.ReadOnly = true;
            // 
            // groupBoxCategoria
            // 
            this.groupBoxCategoria.Controls.Add(this.btnCancelar);
            this.groupBoxCategoria.Controls.Add(this.btnEditar);
            this.groupBoxCategoria.Controls.Add(this.btnSalvar);
            this.groupBoxCategoria.Controls.Add(this.btnNovo);
            this.groupBoxCategoria.Controls.Add(this.tctDescricacaoCategoria);
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
            this.groupBoxCategoria.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(17, 78);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome:";
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
            // txtIdCategoria
            // 
            this.txtIdCategoria.Location = new System.Drawing.Point(86, 40);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtIdCategoria.TabIndex = 3;
            // 
            // txtNomeCotegoria
            // 
            this.txtNomeCotegoria.Location = new System.Drawing.Point(86, 75);
            this.txtNomeCotegoria.Name = "txtNomeCotegoria";
            this.txtNomeCotegoria.Size = new System.Drawing.Size(198, 20);
            this.txtNomeCotegoria.TabIndex = 4;
            // 
            // tctDescricacaoCategoria
            // 
            this.tctDescricacaoCategoria.Location = new System.Drawing.Point(86, 106);
            this.tctDescricacaoCategoria.Multiline = true;
            this.tctDescricacaoCategoria.Name = "tctDescricacaoCategoria";
            this.tctDescricacaoCategoria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tctDescricacaoCategoria.Size = new System.Drawing.Size(291, 84);
            this.tctDescricacaoCategoria.TabIndex = 5;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(20, 196);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(111, 196);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(209, 196);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(302, 196);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCategoria)).EndInit();
            this.groupBoxCategoria.ResumeLayout(false);
            this.groupBoxCategoria.PerformLayout();
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
        private System.Windows.Forms.DataGridView dvgCategoria;
        private System.Windows.Forms.CheckBox chkDeletar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Deletar;
        private System.Windows.Forms.GroupBox groupBoxCategoria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox tctDescricacaoCategoria;
        private System.Windows.Forms.TextBox txtNomeCotegoria;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.Label lbDescricacao;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lb_IdCategoria;
    }
}

