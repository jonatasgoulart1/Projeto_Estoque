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
    public partial class FrmCadClasses : FrmTemplateBase
    {
        public FrmCadClasses()
        {
            InitializeComponent();
        }
        BLL_Classes MeuAdapterClasses = new BLL_Classes();


        public override void FrmTemplateBase_Load(object sender, EventArgs e)
        {
            GridLista.Columns[0].DataPropertyName = "Descricao";
            GridLista.Columns[0].HeaderText = "Descricao da  Classe";
            MeuAdapterClasses.MontarLista("");

            ExibirTitulo("Cadastro das Classes");
            GridLista.DataSource = MeuAdapterClasses.DtClasses;
            base.FrmTemplateBase_Load(sender, e);
        }

        public override void TxtLocalizar_TextChanged(object sender, EventArgs e)
        {
            MeuAdapterClasses.MontarLista(TxtLocalizar.Text);
            GridLista.DataSource = MeuAdapterClasses.DtClasses;
            base.TxtLocalizar_TextChanged(sender, e);
        }
        public override void GridLista_SelectionChanged(object sender, EventArgs e)
        {
            if (GridLista.SelectedRows.Count > 0)
            {
                DataRowView linha =
                (DataRowView)GridLista.Rows[GridLista.SelectedRows[0].Index].DataBoundItem;
                LblClasseId.Text = linha["ClasseId"].ToString();
                txtAbreviatura.Text = linha["Abreviatura"].ToString();
                txtDescricao.Text = linha["Descricao"].ToString();


            }
            base.GridLista_SelectionChanged(sender, e);
        }
        void LimparCampos()
        {
            LblClasseId.Text = "";
            txtDescricao.Clear();
            txtAbreviatura.Clear();
        }

        public override void BtnNovo_Click(object sender, EventArgs e)

        {
            LimparCampos();
            base.BtnNovo_Click(sender, e);

        }
        public override void BtnConfirmar_Click(object sender, EventArgs e)
        {
            string Mensagem = "";
            if (string.IsNullOrEmpty(txtDescricao.Text) || string.IsNullOrEmpty(txtAbreviatura.Text))
            {
                MessageBox.Show("É obrigatório preencher os campos Descrição e Abreviatura!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (LblClasseId.Text != "")
                
                    Mensagem = MeuAdapterClasses.AlterarClasse(
                        Convert.ToInt32(LblClasseId.Text), txtDescricao.Text,txtAbreviatura.Text);               
                
             else  Mensagem = MeuAdapterClasses.InserirClasses(txtDescricao.Text, txtAbreviatura.Text);
                

                if (!string.IsNullOrEmpty(Mensagem))  MessageBox.Show(Mensagem, "Atenção!");
                

                LimparCampos();
                MeuAdapterClasses.MontarLista("");
                GridLista.DataSource = MeuAdapterClasses.DtClasses;
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
                    Mensagem = MeuAdapterClasses.ExcluirClasses(Convert.ToInt32(LblClasseId.Text));
                    if (Mensagem != "") MessageBox.Show(Mensagem, "Atenção!");
                    LimparCampos();
                    MeuAdapterClasses.MontarLista("");
                    GridLista.DataSource = MeuAdapterClasses.DtClasses;
                    base.BtnExcluir_Click(sender, e);
                }
            }
            else
                MessageBox.Show("Favor selecionar um item para excluir", "Atenção");
            base.BtnExcluir_Click(sender, e);

        }
    }
}






