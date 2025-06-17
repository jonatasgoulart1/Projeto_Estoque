namespace Estoque.Derivadas
{
    partial class FrmCadProdutos
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
            this.LblProdutoId = new System.Windows.Forms.Label();
            this.LblDescricao = new System.Windows.Forms.Label();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.LblUnidade = new System.Windows.Forms.Label();
            this.TxtUnidade = new System.Windows.Forms.TextBox();
            this.LblClasse = new System.Windows.Forms.Label();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.LblGrupo = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.LblFamilia = new System.Windows.Forms.Label();
            this.cmbFamilia = new System.Windows.Forms.ComboBox();
            this.LblDepartamento = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblQtdeSaldo = new System.Windows.Forms.Label();
            this.txtQtdeSaldo = new System.Windows.Forms.TextBox();
            this.lblCustoMedio = new System.Windows.Forms.Label();
            this.txtCustoMedio = new System.Windows.Forms.TextBox();
            this.lblValorSaldo = new System.Windows.Forms.Label();
            this.txtValorSaldo = new System.Windows.Forms.TextBox();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.lblDataUltCompra = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtLocalArmazenamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPesoLiquido = new System.Windows.Forms.TextBox();
            this.TxtPesoBruto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.dtpUltCompra = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PnlLista.SuspendLayout();
            this.PnlCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlLista
            // 
            this.PnlLista.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.PnlLista.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.PnlLista.Size = new System.Drawing.Size(331, 735);
            // 
            // PnlCadastro
            // 
            this.PnlCadastro.Controls.Add(this.label4);
            this.PnlCadastro.Controls.Add(this.TxtLocalArmazenamento);
            this.PnlCadastro.Controls.Add(this.dtpUltCompra);
            this.PnlCadastro.Controls.Add(this.dtpDataCadastro);
            this.PnlCadastro.Controls.Add(this.label3);
            this.PnlCadastro.Controls.Add(this.label2);
            this.PnlCadastro.Controls.Add(this.TxtPesoBruto);
            this.PnlCadastro.Controls.Add(this.TxtPesoLiquido);
            this.PnlCadastro.Controls.Add(this.TxtCodigo);
            this.PnlCadastro.Controls.Add(this.label1);
            this.PnlCadastro.Controls.Add(this.lblDataUltCompra);
            this.PnlCadastro.Controls.Add(this.cmbSituacao);
            this.PnlCadastro.Controls.Add(this.lblSituacao);
            this.PnlCadastro.Controls.Add(this.lblDataCadastro);
            this.PnlCadastro.Controls.Add(this.txtValorSaldo);
            this.PnlCadastro.Controls.Add(this.lblValorSaldo);
            this.PnlCadastro.Controls.Add(this.txtCustoMedio);
            this.PnlCadastro.Controls.Add(this.lblCustoMedio);
            this.PnlCadastro.Controls.Add(this.txtQtdeSaldo);
            this.PnlCadastro.Controls.Add(this.lblQtdeSaldo);
            this.PnlCadastro.Controls.Add(this.cmbDepartamento);
            this.PnlCadastro.Controls.Add(this.LblDepartamento);
            this.PnlCadastro.Controls.Add(this.cmbFamilia);
            this.PnlCadastro.Controls.Add(this.LblFamilia);
            this.PnlCadastro.Controls.Add(this.cmbGrupo);
            this.PnlCadastro.Controls.Add(this.LblGrupo);
            this.PnlCadastro.Controls.Add(this.cmbClasse);
            this.PnlCadastro.Controls.Add(this.LblClasse);
            this.PnlCadastro.Controls.Add(this.TxtUnidade);
            this.PnlCadastro.Controls.Add(this.LblUnidade);
            this.PnlCadastro.Controls.Add(this.TxtDescricao);
            this.PnlCadastro.Controls.Add(this.LblDescricao);
            this.PnlCadastro.Controls.Add(this.LblProdutoId);
            this.PnlCadastro.Location = new System.Drawing.Point(331, 104);
            this.PnlCadastro.Margin = new System.Windows.Forms.Padding(10);
            this.PnlCadastro.Size = new System.Drawing.Size(1002, 631);
            // 
            // TxtLocalizar
            // 
            this.TxtLocalizar.Location = new System.Drawing.Point(9, 8);
            this.TxtLocalizar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.TxtLocalizar.Size = new System.Drawing.Size(313, 26);
            // 
            // LblProdutoId
            // 
            this.LblProdutoId.AutoSize = true;
            this.LblProdutoId.Location = new System.Drawing.Point(126, 3);
            this.LblProdutoId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblProdutoId.Name = "LblProdutoId";
            this.LblProdutoId.Size = new System.Drawing.Size(39, 19);
            this.LblProdutoId.TabIndex = 0;
            this.LblProdutoId.Text = "------";
            // 
            // LblDescricao
            // 
            this.LblDescricao.AutoSize = true;
            this.LblDescricao.Location = new System.Drawing.Point(19, 68);
            this.LblDescricao.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblDescricao.Name = "LblDescricao";
            this.LblDescricao.Size = new System.Drawing.Size(92, 19);
            this.LblDescricao.TabIndex = 1;
            this.LblDescricao.Text = "Descricao:";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(130, 61);
            this.TxtDescricao.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(465, 26);
            this.TxtDescricao.TabIndex = 2;
            this.toolTip1.SetToolTip(this.TxtDescricao, "Digite a Descrição do Produto");
            // 
            // LblUnidade
            // 
            this.LblUnidade.AutoSize = true;
            this.LblUnidade.Location = new System.Drawing.Point(317, 108);
            this.LblUnidade.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblUnidade.Name = "LblUnidade";
            this.LblUnidade.Size = new System.Drawing.Size(79, 19);
            this.LblUnidade.TabIndex = 3;
            this.LblUnidade.Text = "Unidade:";
            // 
            // TxtUnidade
            // 
            this.TxtUnidade.Location = new System.Drawing.Point(406, 99);
            this.TxtUnidade.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.TxtUnidade.Name = "TxtUnidade";
            this.TxtUnidade.Size = new System.Drawing.Size(211, 26);
            this.TxtUnidade.TabIndex = 4;
            this.toolTip1.SetToolTip(this.TxtUnidade, "Inserir Unidade do Produto");
            // 
            // LblClasse
            // 
            this.LblClasse.AutoSize = true;
            this.LblClasse.Location = new System.Drawing.Point(44, 108);
            this.LblClasse.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblClasse.Name = "LblClasse";
            this.LblClasse.Size = new System.Drawing.Size(67, 19);
            this.LblClasse.TabIndex = 5;
            this.LblClasse.Text = "Classe:";
            // 
            // cmbClasse
            // 
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Location = new System.Drawing.Point(130, 99);
            this.cmbClasse.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(164, 27);
            this.cmbClasse.TabIndex = 6;
            this.toolTip1.SetToolTip(this.cmbClasse, "Selecione a Classe do Produto");
            // 
            // LblGrupo
            // 
            this.LblGrupo.AutoSize = true;
            this.LblGrupo.Location = new System.Drawing.Point(48, 151);
            this.LblGrupo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblGrupo.Name = "LblGrupo";
            this.LblGrupo.Size = new System.Drawing.Size(63, 19);
            this.LblGrupo.TabIndex = 7;
            this.LblGrupo.Text = "Grupo:";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(130, 142);
            this.cmbGrupo.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(164, 27);
            this.cmbGrupo.TabIndex = 8;
            this.toolTip1.SetToolTip(this.cmbGrupo, "Selecione o Grupo do Produto");
            // 
            // LblFamilia
            // 
            this.LblFamilia.AutoSize = true;
            this.LblFamilia.Location = new System.Drawing.Point(317, 151);
            this.LblFamilia.Name = "LblFamilia";
            this.LblFamilia.Size = new System.Drawing.Size(69, 19);
            this.LblFamilia.TabIndex = 9;
            this.LblFamilia.Text = "Familia:";
            // 
            // cmbFamilia
            // 
            this.cmbFamilia.FormattingEnabled = true;
            this.cmbFamilia.Location = new System.Drawing.Point(409, 147);
            this.cmbFamilia.Name = "cmbFamilia";
            this.cmbFamilia.Size = new System.Drawing.Size(210, 27);
            this.cmbFamilia.TabIndex = 10;
            this.toolTip1.SetToolTip(this.cmbFamilia, "Selecione a Familia do Produto");
            // 
            // LblDepartamento
            // 
            this.LblDepartamento.AutoSize = true;
            this.LblDepartamento.Location = new System.Drawing.Point(29, 232);
            this.LblDepartamento.Name = "LblDepartamento";
            this.LblDepartamento.Size = new System.Drawing.Size(123, 19);
            this.LblDepartamento.TabIndex = 11;
            this.LblDepartamento.Text = "Departamento:";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(33, 253);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(205, 27);
            this.cmbDepartamento.TabIndex = 12;
            this.toolTip1.SetToolTip(this.cmbDepartamento, "Selecione o Departamento do Produto");
            // 
            // lblQtdeSaldo
            // 
            this.lblQtdeSaldo.AutoSize = true;
            this.lblQtdeSaldo.Location = new System.Drawing.Point(317, 232);
            this.lblQtdeSaldo.Name = "lblQtdeSaldo";
            this.lblQtdeSaldo.Size = new System.Drawing.Size(151, 19);
            this.lblQtdeSaldo.TabIndex = 13;
            this.lblQtdeSaldo.Text = "Quantidade Saldo:";
            // 
            // txtQtdeSaldo
            // 
            this.txtQtdeSaldo.Location = new System.Drawing.Point(321, 253);
            this.txtQtdeSaldo.Name = "txtQtdeSaldo";
            this.txtQtdeSaldo.Size = new System.Drawing.Size(141, 26);
            this.txtQtdeSaldo.TabIndex = 14;
            this.toolTip1.SetToolTip(this.txtQtdeSaldo, "Inserir quantidade do Saldo");
            // 
            // lblCustoMedio
            // 
            this.lblCustoMedio.AutoSize = true;
            this.lblCustoMedio.Location = new System.Drawing.Point(29, 304);
            this.lblCustoMedio.Name = "lblCustoMedio";
            this.lblCustoMedio.Size = new System.Drawing.Size(107, 19);
            this.lblCustoMedio.TabIndex = 15;
            this.lblCustoMedio.Text = "CustoMedio:";
            // 
            // txtCustoMedio
            // 
            this.txtCustoMedio.Location = new System.Drawing.Point(33, 326);
            this.txtCustoMedio.Name = "txtCustoMedio";
            this.txtCustoMedio.Size = new System.Drawing.Size(165, 26);
            this.txtCustoMedio.TabIndex = 16;
            this.toolTip1.SetToolTip(this.txtCustoMedio, "Inserir Custo Medio do Produto");
            // 
            // lblValorSaldo
            // 
            this.lblValorSaldo.AutoSize = true;
            this.lblValorSaldo.Location = new System.Drawing.Point(317, 304);
            this.lblValorSaldo.Name = "lblValorSaldo";
            this.lblValorSaldo.Size = new System.Drawing.Size(92, 19);
            this.lblValorSaldo.TabIndex = 17;
            this.lblValorSaldo.Text = "ValorSaldo";
            // 
            // txtValorSaldo
            // 
            this.txtValorSaldo.Location = new System.Drawing.Point(321, 326);
            this.txtValorSaldo.Name = "txtValorSaldo";
            this.txtValorSaldo.Size = new System.Drawing.Size(141, 26);
            this.txtValorSaldo.TabIndex = 18;
            this.toolTip1.SetToolTip(this.txtValorSaldo, "Inserir Valor do Saldo");
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(29, 371);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(124, 19);
            this.lblDataCadastro.TabIndex = 19;
            this.lblDataCadastro.Text = " DataCadastro:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(29, 457);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(82, 19);
            this.lblSituacao.TabIndex = 21;
            this.lblSituacao.Text = "Situação:";
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Location = new System.Drawing.Point(130, 449);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(121, 27);
            this.cmbSituacao.TabIndex = 22;
            this.toolTip1.SetToolTip(this.cmbSituacao, "Selecionar Situação do produto");
            // 
            // lblDataUltCompra
            // 
            this.lblDataUltCompra.AutoSize = true;
            this.lblDataUltCompra.Location = new System.Drawing.Point(317, 371);
            this.lblDataUltCompra.Name = "lblDataUltCompra";
            this.lblDataUltCompra.Size = new System.Drawing.Size(159, 19);
            this.lblDataUltCompra.TabIndex = 23;
            this.lblDataUltCompra.Text = "DataUltimaCompra:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(130, 27);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(164, 26);
            this.TxtCodigo.TabIndex = 26;
            this.toolTip1.SetToolTip(this.TxtCodigo, "Digite a Descrição do Produto");
            // 
            // TxtLocalArmazenamento
            // 
            this.TxtLocalArmazenamento.Location = new System.Drawing.Point(385, 454);
            this.TxtLocalArmazenamento.Name = "TxtLocalArmazenamento";
            this.TxtLocalArmazenamento.Size = new System.Drawing.Size(232, 26);
            this.TxtLocalArmazenamento.TabIndex = 33;
            this.toolTip1.SetToolTip(this.TxtLocalArmazenamento, "Inserir Custo Medio do Produto");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Código:";
            // 
            // TxtPesoLiquido
            // 
            this.TxtPesoLiquido.Location = new System.Drawing.Point(130, 190);
            this.TxtPesoLiquido.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPesoLiquido.Name = "TxtPesoLiquido";
            this.TxtPesoLiquido.Size = new System.Drawing.Size(141, 26);
            this.TxtPesoLiquido.TabIndex = 27;
            // 
            // TxtPesoBruto
            // 
            this.TxtPesoBruto.Location = new System.Drawing.Point(409, 190);
            this.TxtPesoBruto.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPesoBruto.Name = "TxtPesoBruto";
            this.TxtPesoBruto.Size = new System.Drawing.Size(141, 26);
            this.TxtPesoBruto.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Peso Liquido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Peso Bruto:";
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.Location = new System.Drawing.Point(167, 364);
            this.dtpDataCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataCadastro.Mask = "00/00/0000";
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(141, 26);
            this.dtpDataCadastro.TabIndex = 31;
            this.dtpDataCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // dtpUltCompra
            // 
            this.dtpUltCompra.Location = new System.Drawing.Point(491, 367);
            this.dtpUltCompra.Margin = new System.Windows.Forms.Padding(4);
            this.dtpUltCompra.Mask = "00/00/0000";
            this.dtpUltCompra.Name = "dtpUltCompra";
            this.dtpUltCompra.Size = new System.Drawing.Size(141, 26);
            this.dtpUltCompra.TabIndex = 32;
            this.dtpUltCompra.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "Local Armazenamento";
            // 
            // FrmCadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 735);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmCadProdutos";
            this.Text = "FrmCadProdutos";
            this.PnlLista.ResumeLayout(false);
            this.PnlLista.PerformLayout();
            this.PnlCadastro.ResumeLayout(false);
            this.PnlCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Label LblDescricao;
        private System.Windows.Forms.Label LblProdutoId;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.Label LblGrupo;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.Label LblClasse;
        private System.Windows.Forms.TextBox TxtUnidade;
        private System.Windows.Forms.Label LblUnidade;
        private System.Windows.Forms.Label LblDepartamento;
        private System.Windows.Forms.ComboBox cmbFamilia;
        private System.Windows.Forms.Label LblFamilia;
        private System.Windows.Forms.Label lblQtdeSaldo;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label lblValorSaldo;
        private System.Windows.Forms.TextBox txtCustoMedio;
        private System.Windows.Forms.Label lblCustoMedio;
        private System.Windows.Forms.TextBox txtQtdeSaldo;
        private System.Windows.Forms.Label lblDataUltCompra;
        private System.Windows.Forms.ComboBox cmbSituacao;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.TextBox txtValorSaldo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPesoBruto;
        private System.Windows.Forms.TextBox TxtPesoLiquido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox dtpUltCompra;
        private System.Windows.Forms.MaskedTextBox dtpDataCadastro;
        private System.Windows.Forms.TextBox TxtLocalArmazenamento;
        private System.Windows.Forms.Label label4;
    }
}