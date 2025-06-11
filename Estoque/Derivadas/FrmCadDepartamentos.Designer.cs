namespace Estoque.Derivadas
{
    partial class FrmCadDepartamentos
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
            this.LblDepartamentoId = new System.Windows.Forms.Label();
            this.LblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PnlLista.SuspendLayout();
            this.PnlCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlLista
            // 
            this.PnlLista.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PnlLista.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.PnlLista.Size = new System.Drawing.Size(333, 735);
            // 
            // PnlCadastro
            // 
            this.PnlCadastro.Controls.Add(this.txtDescricao);
            this.PnlCadastro.Controls.Add(this.LblDescricao);
            this.PnlCadastro.Controls.Add(this.LblDepartamentoId);
            this.PnlCadastro.Location = new System.Drawing.Point(333, 104);
            this.PnlCadastro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PnlCadastro.Size = new System.Drawing.Size(1000, 631);
            // 
            // TxtLocalizar
            // 
            this.TxtLocalizar.Location = new System.Drawing.Point(8, 7);
            this.TxtLocalizar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtLocalizar.Size = new System.Drawing.Size(317, 26);
            // 
            // LblDepartamentoId
            // 
            this.LblDepartamentoId.AutoSize = true;
            this.LblDepartamentoId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDepartamentoId.Location = new System.Drawing.Point(161, 39);
            this.LblDepartamentoId.Name = "LblDepartamentoId";
            this.LblDepartamentoId.Size = new System.Drawing.Size(24, 19);
            this.LblDepartamentoId.TabIndex = 0;
            this.LblDepartamentoId.Text = "---";
            // 
            // LblDescricao
            // 
            this.LblDescricao.AutoSize = true;
            this.LblDescricao.Location = new System.Drawing.Point(67, 68);
            this.LblDescricao.Name = "LblDescricao";
            this.LblDescricao.Size = new System.Drawing.Size(92, 19);
            this.LblDescricao.TabIndex = 1;
            this.LblDescricao.Text = "Descricao:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(165, 61);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(310, 26);
            this.txtDescricao.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtDescricao, "Digite a Descrição do Departamento");
            // 
            // FrmCadDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 735);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmCadDepartamentos";
            this.Text = "FrmCadDepartamentos";
            this.PnlLista.ResumeLayout(false);
            this.PnlLista.PerformLayout();
            this.PnlCadastro.ResumeLayout(false);
            this.PnlCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label LblDescricao;
        private System.Windows.Forms.Label LblDepartamentoId;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}