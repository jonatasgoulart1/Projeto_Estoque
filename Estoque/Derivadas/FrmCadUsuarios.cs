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
    public partial class FrmCadUsuarios : FrmTemplateBase
    {
        public FrmCadUsuarios()
        {
            InitializeComponent();
        }
        BLL_Usuarios MeuAdapterUsuarios = new BLL_Usuarios();


        public override void FrmTemplateBase_Load(object sender, EventArgs e)
        {
            GridLista.Columns[0].DataPropertyName = "Nome";
            // GridLista.Columns[0].HeaderText = "Descricao do Usuario";
            MeuAdapterUsuarios.MontarLista("");

            ExibirTitulo("Cadastro dos Usuarios");
            GridLista.DataSource = MeuAdapterUsuarios.DtUsuarios;
            base.FrmTemplateBase_Load(sender, e);
        }
        public override void TxtLocalizar_TextChanged(object sender, EventArgs e)
        {
            MeuAdapterUsuarios.MontarLista(TxtLocalizar.Text);
            GridLista.DataSource = MeuAdapterUsuarios.DtUsuarios;
            base.TxtLocalizar_TextChanged(sender, e);
        }
        public override void GridLista_SelectionChanged(object sender, EventArgs e)
        {
            if (GridLista.SelectedRows.Count > 0)
            {
                DataRowView linha =
                (DataRowView)GridLista.Rows[GridLista.SelectedRows[0].Index].DataBoundItem;
                LblUsuarioId.Text = linha["UsuarioID"].ToString();
                txtNome.Text = linha["Nome"].ToString();
                txtSenha.Text = linha["Senha"].ToString();
                cmbTipo.Text = linha["Tipo"].ToString();

            }
            base.GridLista_SelectionChanged(sender, e);
        }
        void LimparCampos()
        {
            LblUsuarioId.Text = "";
            txtNome.Clear(); txtSenha.Clear();
            cmbTipo.SelectedIndex = -1;
     
        }

        public override void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            base.BtnNovo_Click(sender, e);
        }
        public override void BtnConfirmar_Click(object sender, EventArgs e)
        {
            string Mensagem = "";
            if (string.IsNullOrEmpty(txtNome.Text) ||
               string.IsNullOrEmpty(txtSenha.Text) || String.IsNullOrEmpty(cmbTipo.Text))

            {
                MessageBox.Show("Obrigatorio inserir um Nome, Tipo e Senha", "atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else
            {

                if (LblUsuarioId.Text != "")

                    Mensagem = MeuAdapterUsuarios.AlterarUsuarios(
                 txtNome.Text, txtSenha.Text, cmbTipo.Text, Convert.ToInt32(LblUsuarioId.Text));


                else Mensagem = MeuAdapterUsuarios.InserirUsuario
                         (txtNome.Text, txtSenha.Text, cmbTipo.Text);

                if (Mensagem != "") MessageBox.Show(Mensagem, "Atenção!");


                LimparCampos();
                MeuAdapterUsuarios.MontarLista("");
                GridLista.DataSource = MeuAdapterUsuarios.DtUsuarios;
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
               linha["Nome"]), "Atenção",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Mensagem = MeuAdapterUsuarios.ExcluirUsuarios(Convert.ToInt32(LblUsuarioId.Text));
                    if (Mensagem != "") MessageBox.Show(Mensagem, "Atenção!");
                    LimparCampos();
                    MeuAdapterUsuarios.MontarLista("");
                    GridLista.DataSource = MeuAdapterUsuarios.DtUsuarios;
                    base.BtnExcluir_Click(sender, e);
                }
            }
            else
                MessageBox.Show("Favor selecionar um item para excluir", "Atenção");
            base.BtnExcluir_Click(sender, e);

        }

    }
}





