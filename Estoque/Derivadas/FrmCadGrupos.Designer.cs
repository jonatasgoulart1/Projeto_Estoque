namespace Estoque.Derivadas
{
    partial class FrmCadGrupos
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
            this.LblGrupoId = new System.Windows.Forms.Label();
            this.LblAbreviatura = new System.Windows.Forms.Label();
            this.LblDescricao = new System.Windows.Forms.Label();
            this.txtAbreviatura = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.PnlCadastro.Controls.Add(this.txtDescricao);
            this.PnlCadastro.Controls.Add(this.txtAbreviatura);
            this.PnlCadastro.Controls.Add(this.LblDescricao);
            this.PnlCadastro.Controls.Add(this.LblAbreviatura);
            this.PnlCadastro.Controls.Add(this.LblGrupoId);
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
            // LblGrupoId
            // 
            this.LblGrupoId.AutoSize = true;
            this.LblGrupoId.Location = new System.Drawing.Point(195, 60);
            this.LblGrupoId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblGrupoId.Name = "LblGrupoId";
            this.LblGrupoId.Size = new System.Drawing.Size(29, 19);
            this.LblGrupoId.TabIndex = 0;
            this.LblGrupoId.Text = "----";
            // 
            // LblAbreviatura
            // 
            this.LblAbreviatura.AutoSize = true;
            this.LblAbreviatura.Location = new System.Drawing.Point(79, 84);
            this.LblAbreviatura.Name = "LblAbreviatura";
            this.LblAbreviatura.Size = new System.Drawing.Size(103, 19);
            this.LblAbreviatura.TabIndex = 1;
            this.LblAbreviatura.Text = "Abreviatura:";
            // 
            // LblDescricao
            // 
            this.LblDescricao.AutoSize = true;
            this.LblDescricao.Location = new System.Drawing.Point(79, 132);
            this.LblDescricao.Name = "LblDescricao";
            this.LblDescricao.Size = new System.Drawing.Size(92, 19);
            this.LblDescricao.TabIndex = 2;
            this.LblDescricao.Text = "Descricao:\r\n";
            // 
            // txtAbreviatura
            // 
            this.txtAbreviatura.Location = new System.Drawing.Point(199, 82);
            this.txtAbreviatura.Name = "txtAbreviatura";
            this.txtAbreviatura.Size = new System.Drawing.Size(100, 26);
            this.txtAbreviatura.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtAbreviatura, "Digite a Abreviatura da  Classe");
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(199, 130);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(307, 26);
            this.txtDescricao.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtDescricao, "Digite a descrição da Classe");
            // 
            // FrmCadGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 735);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FrmCadGrupos";
            this.Text = "FrmCadGrupos";
            this.PnlLista.ResumeLayout(false);
            this.PnlLista.PerformLayout();
            this.PnlCadastro.ResumeLayout(false);
            this.PnlCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblGrupoId;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtAbreviatura;
        private System.Windows.Forms.Label LblDescricao;
        private System.Windows.Forms.Label LblAbreviatura;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}