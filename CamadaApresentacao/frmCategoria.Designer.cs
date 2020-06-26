namespace CamadaApresentacao
{
    partial class frmCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbcategoria = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox_deletar = new System.Windows.Forms.CheckBox();
            this.dataGridView_Lista = new System.Windows.Forms.DataGridView();
            this.Deletar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lb_TotalResgistro = new System.Windows.Forms.Label();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.lbnome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_IdCategoria = new System.Windows.Forms.TextBox();
            this.lbdescricao = new System.Windows.Forms.Label();
            this.lbnome1 = new System.Windows.Forms.Label();
            this.lbidcategoria = new System.Windows.Forms.Label();
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip_mensagem = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lista)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // lbcategoria
            // 
            this.lbcategoria.AutoSize = true;
            this.lbcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcategoria.Location = new System.Drawing.Point(13, 3);
            this.lbcategoria.Name = "lbcategoria";
            this.lbcategoria.Size = new System.Drawing.Size(76, 16);
            this.lbcategoria.TabIndex = 0;
            this.lbcategoria.Text = "Categoria";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 348);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox_deletar);
            this.tabPage1.Controls.Add(this.dataGridView_Lista);
            this.tabPage1.Controls.Add(this.lb_TotalResgistro);
            this.tabPage1.Controls.Add(this.btn_Imprimir);
            this.tabPage1.Controls.Add(this.btn_deletar);
            this.tabPage1.Controls.Add(this.btn_Buscar);
            this.tabPage1.Controls.Add(this.txt_Buscar);
            this.tabPage1.Controls.Add(this.lbnome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(746, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listar Categoria";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox_deletar
            // 
            this.checkBox_deletar.AutoSize = true;
            this.checkBox_deletar.Location = new System.Drawing.Point(9, 43);
            this.checkBox_deletar.Name = "checkBox_deletar";
            this.checkBox_deletar.Size = new System.Drawing.Size(60, 17);
            this.checkBox_deletar.TabIndex = 7;
            this.checkBox_deletar.Text = "Deletar";
            this.checkBox_deletar.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Lista
            // 
            this.dataGridView_Lista.AllowUserToAddRows = false;
            this.dataGridView_Lista.AllowUserToDeleteRows = false;
            this.dataGridView_Lista.AllowUserToOrderColumns = true;
            this.dataGridView_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deletar});
            this.dataGridView_Lista.Location = new System.Drawing.Point(9, 66);
            this.dataGridView_Lista.MultiSelect = false;
            this.dataGridView_Lista.Name = "dataGridView_Lista";
            this.dataGridView_Lista.ReadOnly = true;
            this.dataGridView_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Lista.Size = new System.Drawing.Size(548, 241);
            this.dataGridView_Lista.TabIndex = 6;
            // 
            // Deletar
            // 
            this.Deletar.HeaderText = "Deletar";
            this.Deletar.Name = "Deletar";
            this.Deletar.ReadOnly = true;
            // 
            // lb_TotalResgistro
            // 
            this.lb_TotalResgistro.AutoSize = true;
            this.lb_TotalResgistro.Location = new System.Drawing.Point(478, 50);
            this.lb_TotalResgistro.Name = "lb_TotalResgistro";
            this.lb_TotalResgistro.Size = new System.Drawing.Size(79, 13);
            this.lb_TotalResgistro.TabIndex = 5;
            this.lb_TotalResgistro.Text = "total de registro";
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Location = new System.Drawing.Point(372, 11);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(75, 23);
            this.btn_Imprimir.TabIndex = 4;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(292, 11);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(75, 23);
            this.btn_deletar.TabIndex = 3;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(212, 11);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(58, 13);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(148, 20);
            this.txt_Buscar.TabIndex = 1;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Location = new System.Drawing.Point(6, 16);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(38, 13);
            this.lbnome.TabIndex = 0;
            this.lbnome.Text = "Nome:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configurações";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Cancelar);
            this.groupBox1.Controls.Add(this.btn_Novo);
            this.groupBox1.Controls.Add(this.btn_Editar);
            this.groupBox1.Controls.Add(this.btn_Salvar);
            this.groupBox1.Controls.Add(this.txt_Descricao);
            this.groupBox1.Controls.Add(this.txt_Nome);
            this.groupBox1.Controls.Add(this.txt_IdCategoria);
            this.groupBox1.Controls.Add(this.lbdescricao);
            this.groupBox1.Controls.Add(this.lbnome1);
            this.groupBox1.Controls.Add(this.lbidcategoria);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(315, 166);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 9;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(143, 166);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.btn_Novo.TabIndex = 8;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(224, 166);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 7;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(62, 166);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 6;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.Location = new System.Drawing.Point(62, 96);
            this.txt_Descricao.Multiline = true;
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Descricao.Size = new System.Drawing.Size(328, 64);
            this.txt_Descricao.TabIndex = 5;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(62, 59);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(328, 20);
            this.txt_Nome.TabIndex = 4;
            // 
            // txt_IdCategoria
            // 
            this.txt_IdCategoria.Location = new System.Drawing.Point(62, 23);
            this.txt_IdCategoria.Name = "txt_IdCategoria";
            this.txt_IdCategoria.Size = new System.Drawing.Size(100, 20);
            this.txt_IdCategoria.TabIndex = 3;
            // 
            // lbdescricao
            // 
            this.lbdescricao.AutoSize = true;
            this.lbdescricao.Location = new System.Drawing.Point(6, 99);
            this.lbdescricao.Name = "lbdescricao";
            this.lbdescricao.Size = new System.Drawing.Size(55, 13);
            this.lbdescricao.TabIndex = 2;
            this.lbdescricao.Text = "Descrição";
            // 
            // lbnome1
            // 
            this.lbnome1.AutoSize = true;
            this.lbnome1.Location = new System.Drawing.Point(6, 62);
            this.lbnome1.Name = "lbnome1";
            this.lbnome1.Size = new System.Drawing.Size(35, 13);
            this.lbnome1.TabIndex = 1;
            this.lbnome1.Text = "Nome";
            // 
            // lbidcategoria
            // 
            this.lbidcategoria.AutoSize = true;
            this.lbidcategoria.Location = new System.Drawing.Point(6, 26);
            this.lbidcategoria.Name = "lbidcategoria";
            this.lbidcategoria.Size = new System.Drawing.Size(40, 13);
            this.lbidcategoria.TabIndex = 0;
            this.lbidcategoria.Text = "Código";
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // toolTip_mensagem
            // 
            this.toolTip_mensagem.IsBalloon = true;
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbcategoria);
            this.Name = "frmCategoria";
            this.Text = "Controle de Categorias";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lista)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbcategoria;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox_deletar;
        private System.Windows.Forms.DataGridView dataGridView_Lista;
        private System.Windows.Forms.Label lb_TotalResgistro;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Deletar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.TextBox txt_Descricao;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_IdCategoria;
        private System.Windows.Forms.Label lbdescricao;
        private System.Windows.Forms.Label lbnome1;
        private System.Windows.Forms.Label lbidcategoria;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.ToolTip toolTip_mensagem;
    }
}