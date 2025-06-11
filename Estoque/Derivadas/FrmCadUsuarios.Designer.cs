namespace Estoque.Derivadas
{
    partial class FrmCadUsuarios
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
            this.LblUsuarioId = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.LblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.LblTipo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.PnlLista.SuspendLayout();
            this.PnlCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlLista
            // 
            this.PnlLista.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.PnlLista.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.PnlLista.Size = new System.Drawing.Size(333, 735);
            // 
            // PnlCadastro
            // 
            this.PnlCadastro.Controls.Add(this.cmbTipo);
            this.PnlCadastro.Controls.Add(this.LblTipo);
            this.PnlCadastro.Controls.Add(this.txtSenha);
            this.PnlCadastro.Controls.Add(this.LblSenha);
            this.PnlCadastro.Controls.Add(this.txtNome);
            this.PnlCadastro.Controls.Add(this.LblNome);
            this.PnlCadastro.Controls.Add(this.LblUsuarioId);
            this.PnlCadastro.Location = new System.Drawing.Point(333, 104);
            this.PnlCadastro.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.PnlCadastro.Size = new System.Drawing.Size(1000, 631);
            // 
            // TxtLocalizar
            // 
            this.TxtLocalizar.Location = new System.Drawing.Point(9, 8);
            this.TxtLocalizar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.TxtLocalizar.Size = new System.Drawing.Size(315, 26);
            // 
            // LblUsuarioId
            // 
            this.LblUsuarioId.AutoSize = true;
            this.LblUsuarioId.Location = new System.Drawing.Point(180, 29);
            this.LblUsuarioId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblUsuarioId.Name = "LblUsuarioId";
            this.LblUsuarioId.Size = new System.Drawing.Size(24, 19);
            this.LblUsuarioId.TabIndex = 0;
            this.LblUsuarioId.Text = "---";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(63, 51);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(60, 19);
            this.LblNome.TabIndex = 1;
            this.LblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(184, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(384, 26);
            this.txtNome.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtNome, "Inserir nome do Usuario");
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.Location = new System.Drawing.Point(63, 95);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(64, 19);
            this.LblSenha.TabIndex = 3;
            this.LblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(184, 92);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(237, 26);
            this.txtSenha.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtSenha, "Inserir a senha do usuario");
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.Location = new System.Drawing.Point(67, 139);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(49, 19);
            this.LblTipo.TabIndex = 5;
            this.LblTipo.Text = "Tipo:\r\n";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(184, 131);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(173, 27);
            this.cmbTipo.TabIndex = 7;
            // 
            // FrmCadUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 735);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmCadUsuarios";
            this.Text = "FrmCadUsuarios";
            this.PnlLista.ResumeLayout(false);
            this.PnlLista.PerformLayout();
            this.PnlCadastro.ResumeLayout(false);
            this.PnlCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblUsuarioId;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbTipo;
    }
}