using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estoque.Base;
using Estoque.BLL;

namespace Estoque.Derivadas
{
    public partial class FrmCadParametros : FrmTemplateBase
    {
        public FrmCadParametros()
        {
            InitializeComponent();
        }
        BLL_Parametros MeuAdapterParametros = new BLL_Parametros();

        public override void FrmTemplateBase_Load(object sender, EventArgs e)
        {
            GridLista.Columns[0].DataPropertyName = "Parametro";
            GridLista.Columns[0].HeaderText = "Descricao do Parâmetro";
            MeuAdapterParametros.MontarLista("");

            ExibirTitulo("Cadastro dos Parâmetros");
            GridLista.DataSource = MeuAdapterParametros.DtParametros;
            base.FrmTemplateBase_Load(sender, e);
        }

        public override void TxtLocalizar_TextChanged(object sender, EventArgs e)
        {
            MeuAdapterParametros.MontarLista(TxtLocalizar.Text);
            GridLista.DataSource = MeuAdapterParametros.DtParametros;
            base.TxtLocalizar_TextChanged(sender, e);
        }
        public override void GridLista_SelectionChanged(object sender, EventArgs e)
        {
            if (GridLista.SelectedRows.Count > 0)
            {
                DataRowView linha =
                    (DataRowView)GridLista.Rows[GridLista.SelectedRows[0].Index].DataBoundItem;
                LblCodigo.Text = linha["ParametroID"].ToString();
                TxtParametro.Text = linha["Parametro"].ToString();
                TxtValor.Text = linha["Valor"].ToString();
                TxtComentario.Text = linha["Comentario"].ToString();

            }
            base.GridLista_SelectionChanged(sender, e);
        }

        void LimparCampos()
        {
            LblCodigo.Text = "";
            TxtParametro.Clear(); TxtValor.Clear();
            TxtComentario.Clear();
        }

        public override void BtnNovo_Click(object sender, EventArgs e)

        {
            LimparCampos();
            base.BtnNovo_Click(sender, e);

        }
        public override void BtnConfirmar_Click(object sender, EventArgs e)
        {
            string Mensagem = "";
            if (string.IsNullOrEmpty(TxtParametro.Text) ||
               string.IsNullOrEmpty(TxtValor.Text) || String.IsNullOrEmpty(TxtComentario.Text))

            {
                MessageBox.Show("Obrigatorio inserir um parametro, valor e comentario", "atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

                if (LblCodigo.Text != "")

                    Mensagem = MeuAdapterParametros.AlterarParametros(
                        TxtParametro.Text, TxtValor.Text, TxtComentario.Text,Convert.ToInt32(LblCodigo.Text));

                else Mensagem = MeuAdapterParametros.InserirParametros
                         (TxtParametro.Text, TxtValor.Text, TxtComentario.Text);

                if(Mensagem != "") MessageBox.Show(Mensagem, "Atenção!");


                LimparCampos();
                MeuAdapterParametros.MontarLista("");
                GridLista.DataSource = MeuAdapterParametros.DtParametros;
                base.BtnConfirmar_Click(sender, e);



            }
        }
        public override void BtnExcluir_Click(object sender, EventArgs e)
        {
            string Mensagem = "";
            if (GridLista.SelectedRows.Count > 0)
            {
                DataRowView linha =
               (DataRowView)GridLista.Rows[GridLista.SelectedRows[0].Index].DataBoundItem;
                if (MessageBox.Show(string.Format("Deseja Excluir {0}?",
               linha["Parametro"]), "Atenção",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Mensagem = MeuAdapterParametros.ExcluirParametros(Convert.ToInt32(LblCodigo.Text));
                    if (Mensagem != "") MessageBox.Show(Mensagem, "Atenção!");
                    LimparCampos();
                    MeuAdapterParametros.MontarLista("");
                    GridLista.DataSource = MeuAdapterParametros.DtParametros;
                    base.BtnExcluir_Click(sender, e);
                }
            }
            else
                MessageBox.Show("Favor selecionar um item para excluir", "Atenção");
            base.BtnExcluir_Click(sender, e);

        }

    }
}




      



