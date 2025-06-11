namespace Estoque.Base
{
    partial class FrmTemplateBase
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
            this.PnlLista = new System.Windows.Forms.Panel();
            this.GridLista = new System.Windows.Forms.DataGridView();
            this.colunaPadrao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtLocalizar = new System.Windows.Forms.TextBox();
            this.PnlBotoes = new System.Windows.Forms.Panel();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.PnlCadastro = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridLista)).BeginInit();
            this.PnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlLista
            // 
            this.PnlLista.Controls.Add(this.GridLista);
            this.PnlLista.Controls.Add(this.TxtLocalizar);
            this.PnlLista.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLista.Location = new System.Drawing.Point(0, 0);
            this.PnlLista.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PnlLista.Name = "PnlLista";
            this.PnlLista.Padding = new System.Windows.Forms.Padding(6);
            this.PnlLista.Size = new System.Drawing.Size(233, 561);
            this.PnlLista.TabIndex = 0;
            // 
            // GridLista
            // 
            this.GridLista.AllowUserToAddRows = false;
            this.GridLista.AllowUserToDeleteRows = false;
            this.GridLista.AllowUserToResizeColumns = false;
            this.GridLista.AllowUserToResizeRows = false;
            this.GridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaPadrao});
            this.GridLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridLista.Location = new System.Drawing.Point(6, 27);
            this.GridLista.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GridLista.MultiSelect = false;
            this.GridLista.Name = "GridLista";
            this.GridLista.ReadOnly = true;
            this.GridLista.RowHeadersVisible = false;
            this.GridLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridLista.Size = new System.Drawing.Size(221, 528);
            this.GridLista.TabIndex = 1;
      
            this.GridLista.SelectionChanged += new System.EventHandler(this.GridLista_SelectionChanged);
            // 
            // colunaPadrao
            // 
            this.colunaPadrao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colunaPadrao.DataPropertyName = "colunaExibicao";
            this.colunaPadrao.HeaderText = "Descrição";
            this.colunaPadrao.Name = "colunaPadrao";
            this.colunaPadrao.ReadOnly = true;
            // 
            // TxtLocalizar
            // 
            this.TxtLocalizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtLocalizar.Location = new System.Drawing.Point(6, 6);
            this.TxtLocalizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtLocalizar.Name = "TxtLocalizar";
            this.TxtLocalizar.Size = new System.Drawing.Size(221, 21);
            this.TxtLocalizar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.TxtLocalizar, "Pesquisar");
            this.TxtLocalizar.TextChanged += new System.EventHandler(this.TxtLocalizar_TextChanged);
            // 
            // PnlBotoes
            // 
            this.PnlBotoes.Controls.Add(this.BtnExcluir);
            this.PnlBotoes.Controls.Add(this.BtnConfirmar);
            this.PnlBotoes.Controls.Add(this.BtnCancelar);
            this.PnlBotoes.Controls.Add(this.BtnEditar);
            this.PnlBotoes.Controls.Add(this.BtnNovo);
            this.PnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBotoes.Location = new System.Drawing.Point(233, 0);
            this.PnlBotoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PnlBotoes.Name = "PnlBotoes";
            this.PnlBotoes.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PnlBotoes.Size = new System.Drawing.Size(703, 104);
            this.PnlBotoes.TabIndex = 1;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnExcluir.FlatAppearance.BorderSize = 2;
            this.BtnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Image = global::Estoque.Properties.Resources.Excluir;
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcluir.Location = new System.Drawing.Point(285, 14);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(132, 83);
            this.BtnExcluir.TabIndex = 2;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.BackColor = System.Drawing.Color.LightPink;
            this.BtnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnConfirmar.FlatAppearance.BorderSize = 2;
            this.BtnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.Image = global::Estoque.Properties.Resources.Confirmar;
            this.BtnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmar.Location = new System.Drawing.Point(564, 14);
            this.BtnConfirmar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(136, 83);
            this.BtnConfirmar.TabIndex = 4;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCancelar.FlatAppearance.BorderSize = 2;
            this.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = global::Estoque.Properties.Resources.Cancelar;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(425, 14);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(132, 83);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Magenta;
            this.BtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnEditar.FlatAppearance.BorderSize = 2;
            this.BtnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Image = global::Estoque.Properties.Resources.Editar;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(146, 14);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(132, 83);
            this.BtnEditar.TabIndex = 1;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnNovo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnNovo.FlatAppearance.BorderSize = 2;
            this.BtnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.Image = global::Estoque.Properties.Resources.Novo;
            this.BtnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNovo.Location = new System.Drawing.Point(7, 14);
            this.BtnNovo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(132, 83);
            this.BtnNovo.TabIndex = 0;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // PnlCadastro
            // 
            this.PnlCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCadastro.Location = new System.Drawing.Point(233, 104);
            this.PnlCadastro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PnlCadastro.Name = "PnlCadastro";
            this.PnlCadastro.Size = new System.Drawing.Size(703, 457);
            this.PnlCadastro.TabIndex = 2;
            // 
            // FrmTemplateBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 561);
            this.Controls.Add(this.PnlCadastro);
            this.Controls.Add(this.PnlBotoes);
            this.Controls.Add(this.PnlLista);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmTemplateBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTemplateBase";
            this.Load += new System.EventHandler(this.FrmTemplateBase_Load);
            this.PnlLista.ResumeLayout(false);
            this.PnlLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridLista)).EndInit();
            this.PnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel PnlLista;
        private System.Windows.Forms.Panel PnlBotoes;
        protected System.Windows.Forms.Panel PnlCadastro;
        private System.Windows.Forms.ToolTip toolTip1;
        protected System.Windows.Forms.TextBox TxtLocalizar;
        public System.Windows.Forms.DataGridView GridLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaPadrao;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNovo;
    }
}