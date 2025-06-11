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
    public partial class FrmTipoMovimento : FrmTemplateBase
    {
        public FrmTipoMovimento()
        {
            InitializeComponent();
        }
        BLL_Tipo_Movimento MeuAdapterTipo_Movimento= new BLL_Tipo_Movimento();


        public override void FrmTemplateBase_Load(object sender, EventArgs e)
        {
            GridLista.Columns[0].DataPropertyName = "Descricao";
            GridLista.Columns[0].HeaderText = "Descricao do Tipo Movimento";
            MeuAdapterTipo_Movimento.MontarLista("");

            ExibirTitulo("Cadastro do tipo Movimento");
            GridLista.DataSource = MeuAdapterTipo_Movimento.DtTipo_Movimento;
            base.FrmTemplateBase_Load(sender, e);
        }

        public override void TxtLocalizar_TextChanged(object sender, EventArgs e)
        {
            MeuAdapterTipo_Movimento.MontarLista(TxtLocalizar.Text);
            GridLista.DataSource = MeuAdapterTipo_Movimento.DtTipo_Movimento;
            base.TxtLocalizar_TextChanged(sender, e);
        }
        public override void GridLista_SelectionChanged(object sender, EventArgs e)
        {
            if (GridLista.SelectedRows.Count > 0)
            {
                DataRowView linha =
                (DataRowView)GridLista.Rows[GridLista.SelectedRows[0].Index].DataBoundItem;
                LblTipoMovimId.Text = linha["TipoMovimId"].ToString();
                txtDescricao.Text = linha["Descricao"].ToString();
                TxtTipo.Text = linha["Tipo"].ToString();
           

            }
            base.GridLista_SelectionChanged(sender, e);
        }

        void LimparCampos()
        {
            LblTipoMovimId.Text = "";
            txtDescricao.Clear(); TxtTipo.Clear();
        
        }

        public override void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            base.BtnNovo_Click(sender, e);
        }
        public override void BtnConfirmar_Click(object sender, EventArgs e)

        {
            string Mensagem;
            if (string.IsNullOrEmpty(txtDescricao.Text) || string.IsNullOrEmpty(TxtTipo.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            else
            {
                if (LblTipoMovimId.Text != "")

                    Mensagem = MeuAdapterTipo_Movimento.Alteratipo_Movimento(
                        Convert.ToInt32(LblTipoMovimId.Text), txtDescricao.Text, TxtTipo.Text);

                else Mensagem = MeuAdapterTipo_Movimento.InserirTipo_Movimento(txtDescricao.Text, TxtTipo.Text);


                if (!string.IsNullOrEmpty(Mensagem))
                    MessageBox.Show(Mensagem, "Atenção!");

                LimparCampos();
                MeuAdapterTipo_Movimento.MontarLista("");
                GridLista.DataSource = MeuAdapterTipo_Movimento.DtTipo_Movimento;

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
               linha["Descricao"]), "Atenção",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Mensagem = MeuAdapterTipo_Movimento.ExcluirTipo_Movimento(Convert.ToInt32(LblTipoMovimId.Text));
                    if (Mensagem != "") MessageBox.Show(Mensagem, "Atenção!");
                    LimparCampos();
                    MeuAdapterTipo_Movimento.MontarLista("");
                    GridLista.DataSource = MeuAdapterTipo_Movimento.DtTipo_Movimento;
                    base.BtnExcluir_Click(sender, e);
                }
            }
            else
                MessageBox.Show("Favor selecionar um item para excluir", "Atenção");
            base.BtnExcluir_Click(sender, e);

        }
    }
}




