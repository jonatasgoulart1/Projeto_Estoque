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
    public partial class FrmCadDepartamentos : FrmTemplateBase
    {
        public FrmCadDepartamentos()
        {
            InitializeComponent();
        }
        BLL_Departamentos MeuAdapterDepartamentos = new BLL_Departamentos();


        public override void FrmTemplateBase_Load(object sender, EventArgs e)
        {
            GridLista.Columns[0].DataPropertyName = "Descricao";
            GridLista.Columns[0].HeaderText = "Descricao do  Departamento";
            MeuAdapterDepartamentos.MontarLista("");

            ExibirTitulo("Cadastro do Departamento");
            GridLista.DataSource = MeuAdapterDepartamentos.DtDepartamentos;
            base.FrmTemplateBase_Load(sender, e);
        }

        public override void TxtLocalizar_TextChanged(object sender, EventArgs e)
        {
            MeuAdapterDepartamentos.MontarLista(TxtLocalizar.Text);
            GridLista.DataSource = MeuAdapterDepartamentos.DtDepartamentos;
            base.TxtLocalizar_TextChanged(sender, e);
        }

        public override void GridLista_SelectionChanged(object sender, EventArgs e)
        {
            if (GridLista.SelectedRows.Count > 0)
            {
                DataRowView linha =
                (DataRowView)GridLista.Rows[GridLista.SelectedRows[0].Index].DataBoundItem;
                LblDepartamentoId.Text = linha["DepartamentoId"].ToString();
                txtDescricao.Text = linha["Descricao"].ToString();
            

            }
            base.GridLista_SelectionChanged(sender, e);
        }

        void LimparCampos()
        {
            LblDepartamentoId.Text = "";
            txtDescricao.Clear();
 
        }

        public override void BtnNovo_Click(object sender, EventArgs e)

        {
            LimparCampos();
            base.BtnNovo_Click(sender, e);

        }
        public override void BtnConfirmar_Click(object sender, EventArgs e)
        {
            string Mensagem = "";
            if (String.IsNullOrEmpty(txtDescricao.Text))
      
            {
                MessageBox.Show("Obrigatório Inserir o Parametro,Valor e Comentario", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (LblDepartamentoId.Text != "")

                    Mensagem = MeuAdapterDepartamentos.AlterarDepartamento(
                        Convert.ToInt32(LblDepartamentoId.Text), txtDescricao.Text);

                else Mensagem = MeuAdapterDepartamentos.InserirDepartamentos(txtDescricao.Text);


                if (!string.IsNullOrEmpty(Mensagem)) MessageBox.Show(Mensagem, "Atenção!");

                LimparCampos();
                MeuAdapterDepartamentos.MontarLista("");
                GridLista.DataSource = MeuAdapterDepartamentos.DtDepartamentos;
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
                    Mensagem = MeuAdapterDepartamentos.ExcluirDepartamentos(Convert.ToInt32(LblDepartamentoId.Text));
                    if (Mensagem != "") MessageBox.Show(Mensagem, "Atenção!");
                    LimparCampos();
                    MeuAdapterDepartamentos.MontarLista("");
                    GridLista.DataSource = MeuAdapterDepartamentos.DtDepartamentos;
                    base.BtnExcluir_Click(sender, e);
                }
            }
            else
                MessageBox.Show("Favor selecionar um item para excluir", "Atenção");
            base.BtnExcluir_Click(sender, e);

        }
    }
}







