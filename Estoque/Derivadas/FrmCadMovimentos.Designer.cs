namespace Estoque.Derivadas
{
    partial class FrmCadMovimentos
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
            this.lblMovimentoID = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.lblNrDocumento = new System.Windows.Forms.Label();
            this.txtNrDocumento = new System.Windows.Forms.TextBox();
            this.lblDataDocumento = new System.Windows.Forms.Label();
            this.txtSequencia = new System.Windows.Forms.TextBox();
            this.lblSequencia = new System.Windows.Forms.Label();
            this.lblTipoMov = new System.Windows.Forms.Label();
            this.TxtTipoMov = new System.Windows.Forms.TextBox();
            this.lblQtde = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.txtCustoUnitario = new System.Windows.Forms.TextBox();
            this.lblCustoUnitario = new System.Windows.Forms.Label();
            this.lblValorMovimento = new System.Windows.Forms.Label();
            this.txtValorMovimento = new System.Windows.Forms.TextBox();
            this.txtQtdeSaldo = new System.Windows.Forms.TextBox();
            this.lblQtdeSaldo = new System.Windows.Forms.Label();
            this.lblCustoUnitarioSaldo = new System.Windows.Forms.Label();
            this.txtCustoUnitarioSaldo = new System.Windows.Forms.TextBox();
            this.lblValorSaldo = new System.Windows.Forms.Label();
            this.txtValorSaldo = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dtpDataDocumento = new System.Windows.Forms.MaskedTextBox();
            this.label = new System.Windows.Forms.Label();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.PnlCadastro.SuspendLayout();
            this.PnlLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlCadastro
            // 
            this.PnlCadastro.Controls.Add(this.cmbFornecedor);
            this.PnlCadastro.Controls.Add(this.label);
            this.PnlCadastro.Controls.Add(this.dtpDataDocumento);
            this.PnlCadastro.Controls.Add(this.txtValorSaldo);
            this.PnlCadastro.Controls.Add(this.lblValorSaldo);
            this.PnlCadastro.Controls.Add(this.txtCustoUnitarioSaldo);
            this.PnlCadastro.Controls.Add(this.lblCustoUnitarioSaldo);
            this.PnlCadastro.Controls.Add(this.lblQtdeSaldo);
            this.PnlCadastro.Controls.Add(this.txtQtdeSaldo);
            this.PnlCadastro.Controls.Add(this.txtValorMovimento);
            this.PnlCadastro.Controls.Add(this.lblValorMovimento);
            this.PnlCadastro.Controls.Add(this.lblCustoUnitario);
            this.PnlCadastro.Controls.Add(this.txtCustoUnitario);
            this.PnlCadastro.Controls.Add(this.txtQtde);
            this.PnlCadastro.Controls.Add(this.lblQtde);
            this.PnlCadastro.Controls.Add(this.TxtTipoMov);
            this.PnlCadastro.Controls.Add(this.lblTipoMov);
            this.PnlCadastro.Controls.Add(this.lblSequencia);
            this.PnlCadastro.Controls.Add(this.txtSequencia);
            this.PnlCadastro.Controls.Add(this.lblDataDocumento);
            this.PnlCadastro.Controls.Add(this.txtNrDocumento);
            this.PnlCadastro.Controls.Add(this.lblNrDocumento);
            this.PnlCadastro.Controls.Add(this.cmbProduto);
            this.PnlCadastro.Controls.Add(this.lblProduto);
            this.PnlCadastro.Controls.Add(this.lblMovimentoID);
            this.PnlCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlCadastro.Location = new System.Drawing.Point(333, 132);
            this.PnlCadastro.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.PnlCadastro.Size = new System.Drawing.Size(1000, 603);
            // 
            // PnlLista
            // 
            this.PnlLista.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.PnlLista.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.PnlLista.Size = new System.Drawing.Size(333, 735);
            // 
            // TxtLocalizar
            // 
            this.TxtLocalizar.Location = new System.Drawing.Point(9, 8);
            this.TxtLocalizar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.TxtLocalizar.Size = new System.Drawing.Size(315, 26);
            // 
            // lblMovimentoID
            // 
            this.lblMovimentoID.AutoSize = true;
            this.lblMovimentoID.Location = new System.Drawing.Point(205, 23);
            this.lblMovimentoID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMovimentoID.Name = "lblMovimentoID";
            this.lblMovimentoID.Size = new System.Drawing.Size(39, 19);
            this.lblMovimentoID.TabIndex = 0;
            this.lblMovimentoID.Text = "------";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(6, 54);
            this.lblProduto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(77, 19);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produto:";
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(209, 46);
            this.cmbProduto.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(425, 27);
            this.cmbProduto.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cmbProduto, "Selecione o Produto");
            // 
            // lblNrDocumento
            // 
            this.lblNrDocumento.AutoSize = true;
            this.lblNrDocumento.Location = new System.Drawing.Point(6, 163);
            this.lblNrDocumento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNrDocumento.Name = "lblNrDocumento";
            this.lblNrDocumento.Size = new System.Drawing.Size(122, 19);
            this.lblNrDocumento.TabIndex = 3;
            this.lblNrDocumento.Text = "NrDocumento:";
            // 
            // txtNrDocumento
            // 
            this.txtNrDocumento.Location = new System.Drawing.Point(209, 156);
            this.txtNrDocumento.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtNrDocumento.Name = "txtNrDocumento";
            this.txtNrDocumento.Size = new System.Drawing.Size(425, 26);
            this.txtNrDocumento.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtNrDocumento, "Digite o Número do Documento");
            // 
            // lblDataDocumento
            // 
            this.lblDataDocumento.AutoSize = true;
            this.lblDataDocumento.Location = new System.Drawing.Point(6, 104);
            this.lblDataDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataDocumento.Name = "lblDataDocumento";
            this.lblDataDocumento.Size = new System.Drawing.Size(139, 19);
            this.lblDataDocumento.TabIndex = 6;
            this.lblDataDocumento.Text = "DataDocumento:";
            // 
            // txtSequencia
            // 
            this.txtSequencia.Location = new System.Drawing.Point(209, 224);
            this.txtSequencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSequencia.Name = "txtSequencia";
            this.txtSequencia.Size = new System.Drawing.Size(230, 26);
            this.txtSequencia.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtSequencia, "Digite a Sequencia do documento");
            // 
            // lblSequencia
            // 
            this.lblSequencia.AutoSize = true;
            this.lblSequencia.Location = new System.Drawing.Point(6, 231);
            this.lblSequencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSequencia.Name = "lblSequencia";
            this.lblSequencia.Size = new System.Drawing.Size(96, 19);
            this.lblSequencia.TabIndex = 8;
            this.lblSequencia.Text = "Sequencia:";
            // 
            // lblTipoMov
            // 
            this.lblTipoMov.AutoSize = true;
            this.lblTipoMov.Location = new System.Drawing.Point(553, 235);
            this.lblTipoMov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoMov.Name = "lblTipoMov";
            this.lblTipoMov.Size = new System.Drawing.Size(81, 19);
            this.lblTipoMov.TabIndex = 9;
            this.lblTipoMov.Text = "TipoMov:";
            // 
            // TxtTipoMov
            // 
            this.TxtTipoMov.Location = new System.Drawing.Point(644, 228);
            this.TxtTipoMov.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtTipoMov.Name = "TxtTipoMov";
            this.TxtTipoMov.Size = new System.Drawing.Size(261, 26);
            this.TxtTipoMov.TabIndex = 10;
            this.toolTip1.SetToolTip(this.TxtTipoMov, "Digite o tipo de Movimento");
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Location = new System.Drawing.Point(4, 282);
            this.lblQtde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(103, 19);
            this.lblQtde.TabIndex = 11;
            this.lblQtde.Text = "Quantidade:";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(209, 275);
            this.txtQtde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(204, 26);
            this.txtQtde.TabIndex = 12;
            this.toolTip1.SetToolTip(this.txtQtde, "Digite a quantidade");
            // 
            // txtCustoUnitario
            // 
            this.txtCustoUnitario.Location = new System.Drawing.Point(644, 275);
            this.txtCustoUnitario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustoUnitario.Name = "txtCustoUnitario";
            this.txtCustoUnitario.Size = new System.Drawing.Size(203, 26);
            this.txtCustoUnitario.TabIndex = 13;
            this.toolTip1.SetToolTip(this.txtCustoUnitario, "Digite o Custo Unitario");
            // 
            // lblCustoUnitario
            // 
            this.lblCustoUnitario.AutoSize = true;
            this.lblCustoUnitario.Location = new System.Drawing.Point(521, 282);
            this.lblCustoUnitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustoUnitario.Name = "lblCustoUnitario";
            this.lblCustoUnitario.Size = new System.Drawing.Size(115, 19);
            this.lblCustoUnitario.TabIndex = 14;
            this.lblCustoUnitario.Text = "CustoUnitario";
            // 
            // lblValorMovimento
            // 
            this.lblValorMovimento.AutoSize = true;
            this.lblValorMovimento.Location = new System.Drawing.Point(4, 328);
            this.lblValorMovimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorMovimento.Name = "lblValorMovimento";
            this.lblValorMovimento.Size = new System.Drawing.Size(132, 19);
            this.lblValorMovimento.TabIndex = 15;
            this.lblValorMovimento.Text = "ValorMovimento";
            // 
            // txtValorMovimento
            // 
            this.txtValorMovimento.Location = new System.Drawing.Point(209, 321);
            this.txtValorMovimento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValorMovimento.Name = "txtValorMovimento";
            this.txtValorMovimento.Size = new System.Drawing.Size(237, 26);
            this.txtValorMovimento.TabIndex = 16;
            this.toolTip1.SetToolTip(this.txtValorMovimento, "Digite o valor do movimento");
            // 
            // txtQtdeSaldo
            // 
            this.txtQtdeSaldo.Location = new System.Drawing.Point(644, 325);
            this.txtQtdeSaldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQtdeSaldo.Name = "txtQtdeSaldo";
            this.txtQtdeSaldo.Size = new System.Drawing.Size(141, 26);
            this.txtQtdeSaldo.TabIndex = 17;
            this.toolTip1.SetToolTip(this.txtQtdeSaldo, "Digite a quantidade de saldo");
            // 
            // lblQtdeSaldo
            // 
            this.lblQtdeSaldo.AutoSize = true;
            this.lblQtdeSaldo.Location = new System.Drawing.Point(547, 332);
            this.lblQtdeSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdeSaldo.Name = "lblQtdeSaldo";
            this.lblQtdeSaldo.Size = new System.Drawing.Size(89, 19);
            this.lblQtdeSaldo.TabIndex = 18;
            this.lblQtdeSaldo.Text = "QtdeSaldo";
            // 
            // lblCustoUnitarioSaldo
            // 
            this.lblCustoUnitarioSaldo.AutoSize = true;
            this.lblCustoUnitarioSaldo.Location = new System.Drawing.Point(4, 384);
            this.lblCustoUnitarioSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustoUnitarioSaldo.Name = "lblCustoUnitarioSaldo";
            this.lblCustoUnitarioSaldo.Size = new System.Drawing.Size(159, 19);
            this.lblCustoUnitarioSaldo.TabIndex = 19;
            this.lblCustoUnitarioSaldo.Text = "CustoUnitarioSaldo";
            // 
            // txtCustoUnitarioSaldo
            // 
            this.txtCustoUnitarioSaldo.Location = new System.Drawing.Point(209, 377);
            this.txtCustoUnitarioSaldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustoUnitarioSaldo.Name = "txtCustoUnitarioSaldo";
            this.txtCustoUnitarioSaldo.Size = new System.Drawing.Size(175, 26);
            this.txtCustoUnitarioSaldo.TabIndex = 20;
            this.toolTip1.SetToolTip(this.txtCustoUnitarioSaldo, "Digite o Custo Unitario");
            // 
            // lblValorSaldo
            // 
            this.lblValorSaldo.AutoSize = true;
            this.lblValorSaldo.Location = new System.Drawing.Point(544, 384);
            this.lblValorSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorSaldo.Name = "lblValorSaldo";
            this.lblValorSaldo.Size = new System.Drawing.Size(92, 19);
            this.lblValorSaldo.TabIndex = 21;
            this.lblValorSaldo.Text = "ValorSaldo";
            // 
            // txtValorSaldo
            // 
            this.txtValorSaldo.Location = new System.Drawing.Point(644, 377);
            this.txtValorSaldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValorSaldo.Name = "txtValorSaldo";
            this.txtValorSaldo.Size = new System.Drawing.Size(141, 26);
            this.txtValorSaldo.TabIndex = 22;
            this.toolTip1.SetToolTip(this.txtValorSaldo, "Digite o valor do Saldo");
            // 
            // dtpDataDocumento
            // 
            this.dtpDataDocumento.Location = new System.Drawing.Point(209, 95);
            this.dtpDataDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDataDocumento.Mask = "00/00/0000";
            this.dtpDataDocumento.Name = "dtpDataDocumento";
            this.dtpDataDocumento.Size = new System.Drawing.Size(141, 26);
            this.dtpDataDocumento.TabIndex = 23;
            this.dtpDataDocumento.ValidatingType = typeof(System.DateTime);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(538, 104);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(98, 19);
            this.label.TabIndex = 24;
            this.label.Text = "Fornecedor";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(644, 96);
            this.cmbFornecedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(171, 27);
            this.cmbFornecedor.TabIndex = 25;
            // 
            // FrmCadMovimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1333, 735);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FrmCadMovimentos";
            this.Text = "FrmCadMovimentos";
            this.PnlCadastro.ResumeLayout(false);
            this.PnlCadastro.PerformLayout();
            this.PnlLista.ResumeLayout(false);
            this.PnlLista.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblMovimentoID;
        private System.Windows.Forms.Label lblDataDocumento;
        private System.Windows.Forms.TextBox txtNrDocumento;
        private System.Windows.Forms.Label lblNrDocumento;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.TextBox TxtTipoMov;
        private System.Windows.Forms.Label lblTipoMov;
        private System.Windows.Forms.Label lblSequencia;
        private System.Windows.Forms.TextBox txtSequencia;
        private System.Windows.Forms.Label lblCustoUnitario;
        private System.Windows.Forms.TextBox txtCustoUnitario;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.TextBox txtCustoUnitarioSaldo;
        private System.Windows.Forms.Label lblCustoUnitarioSaldo;
        private System.Windows.Forms.Label lblQtdeSaldo;
        private System.Windows.Forms.TextBox txtQtdeSaldo;
        private System.Windows.Forms.TextBox txtValorMovimento;
        private System.Windows.Forms.Label lblValorMovimento;
        private System.Windows.Forms.TextBox txtValorSaldo;
        private System.Windows.Forms.Label lblValorSaldo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox dtpDataDocumento;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.Label label;
    }
}