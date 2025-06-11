namespace Estoque.Derivadas
{
    partial class FrmTipoMovimento
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
            this.LblTipoMovimId = new System.Windows.Forms.Label();
            this.LblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.TxtTipo = new System.Windows.Forms.TextBox();
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
            this.PnlCadastro.Controls.Add(this.TxtTipo);
            this.PnlCadastro.Controls.Add(this.lblTipo);
            this.PnlCadastro.Controls.Add(this.txtDescricao);
            this.PnlCadastro.Controls.Add(this.LblDescricao);
            this.PnlCadastro.Controls.Add(this.LblTipoMovimId);
            this.PnlCadastro.Location = new System.Drawing.Point(333, 132);
            this.PnlCadastro.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.PnlCadastro.Size = new System.Drawing.Size(1000, 603);
            // 
            // TxtLocalizar
            // 
            this.TxtLocalizar.Location = new System.Drawing.Point(9, 8);
            this.TxtLocalizar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.TxtLocalizar.Size = new System.Drawing.Size(315, 26);
            // 
            // LblTipoMovimId
            // 
            this.LblTipoMovimId.AutoSize = true;
            this.LblTipoMovimId.Location = new System.Drawing.Point(173, 26);
            this.LblTipoMovimId.Name = "LblTipoMovimId";
            this.LblTipoMovimId.Size = new System.Drawing.Size(29, 19);
            this.LblTipoMovimId.TabIndex = 0;
            this.LblTipoMovimId.Text = "----\r\n";
            // 
            // LblDescricao
            // 
            this.LblDescricao.AutoSize = true;
            this.LblDescricao.Location = new System.Drawing.Point(79, 51);
            this.LblDescricao.Name = "LblDescricao";
            this.LblDescricao.Size = new System.Drawing.Size(92, 19);
            this.LblDescricao.TabIndex = 1;
            this.LblDescricao.Text = "Descricao:\r\n";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(177, 48);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(223, 26);
            this.txtDescricao.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtDescricao, "Digite a Descrição");
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(90, 104);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(49, 19);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo:";
            // 
            // TxtTipo
            // 
            this.TxtTipo.Location = new System.Drawing.Point(177, 96);
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Size = new System.Drawing.Size(223, 26);
            this.TxtTipo.TabIndex = 4;
            this.toolTip1.SetToolTip(this.TxtTipo, "Digite o Tipo de Movimento");
            // 
            // FrmTipoMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 735);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmTipoMovimento";
            this.Text = "FrmTipoMovimento";
            this.PnlLista.ResumeLayout(false);
            this.PnlLista.PerformLayout();
            this.PnlCadastro.ResumeLayout(false);
            this.PnlCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTipoMovimId;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label LblDescricao;
        private System.Windows.Forms.TextBox TxtTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}