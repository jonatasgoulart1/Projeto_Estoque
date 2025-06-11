namespace Estoque.Derivadas
{
    partial class FrmCadParametros
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
            this.TxtParametro = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.TxtComentario = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.PnlCadastro.Controls.Add(this.label4);
            this.PnlCadastro.Controls.Add(this.label3);
            this.PnlCadastro.Controls.Add(this.label2);
            this.PnlCadastro.Controls.Add(this.LblCodigo);
            this.PnlCadastro.Controls.Add(this.TxtComentario);
            this.PnlCadastro.Controls.Add(this.TxtValor);
            this.PnlCadastro.Controls.Add(this.TxtParametro);
            this.PnlCadastro.Location = new System.Drawing.Point(333, 104);
            this.PnlCadastro.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.PnlCadastro.Size = new System.Drawing.Size(1000, 631);
            // 
            // TxtLocalizar
            // 
            this.TxtLocalizar.Location = new System.Drawing.Point(9, 8);
            this.TxtLocalizar.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.TxtLocalizar.Size = new System.Drawing.Size(315, 26);
            // 
            // TxtParametro
            // 
            this.TxtParametro.Location = new System.Drawing.Point(233, 47);
            this.TxtParametro.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.TxtParametro.Name = "TxtParametro";
            this.TxtParametro.Size = new System.Drawing.Size(587, 26);
            this.TxtParametro.TabIndex = 0;
            this.toolTip1.SetToolTip(this.TxtParametro, "Digite o Nome do Parâmetro");
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(233, 125);
            this.TxtValor.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.TxtValor.Multiline = true;
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(587, 121);
            this.TxtValor.TabIndex = 1;
            this.toolTip1.SetToolTip(this.TxtValor, "Digite o Valor do Parametro");
            // 
            // TxtComentario
            // 
            this.TxtComentario.Location = new System.Drawing.Point(233, 294);
            this.TxtComentario.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.TxtComentario.Name = "TxtComentario";
            this.TxtComentario.Size = new System.Drawing.Size(587, 26);
            this.TxtComentario.TabIndex = 2;
            this.toolTip1.SetToolTip(this.TxtComentario, "Digite um Comentario");
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(229, 23);
            this.LblCodigo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(29, 20);
            this.LblCodigo.TabIndex = 3;
            this.LblCodigo.Text = "-----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parâmetro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 300);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Comentario:";
            // 
            // FrmCadParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 735);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.Name = "FrmCadParametros";
            this.Text = "FrmCadParametros";
            this.PnlLista.ResumeLayout(false);
            this.PnlLista.PerformLayout();
            this.PnlCadastro.ResumeLayout(false);
            this.PnlCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtParametro;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.TextBox TxtComentario;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}