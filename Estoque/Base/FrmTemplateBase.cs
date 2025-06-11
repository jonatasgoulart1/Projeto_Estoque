using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.Base
{
    public partial class FrmTemplateBase : Form
    {
        public FrmTemplateBase()
        {
            InitializeComponent();
            GridLista.AutoGenerateColumns = false;


        }
        public void ExibirTitulo(string Titulo)
        {
            this.Text = Titulo;

        }
        public void ExibirLista()
        {
            BtnNovo.Visible = true; BtnEditar.Visible = true;
            BtnExcluir.Visible = true; BtnCancelar.Visible = false;
            BtnConfirmar.Visible = false;
            PnlLista.Enabled = true; PnlCadastro.Enabled = false;
        }

        public void ExibirCadastro()
        {
            BtnNovo.Visible = false; BtnEditar.Visible = false;
            BtnExcluir.Visible = false; BtnCancelar.Visible = true;
            BtnConfirmar.Visible = true;
            PnlLista.Enabled = false; PnlCadastro.Enabled = true;

        }

        public virtual void FrmTemplateBase_Load(object sender, EventArgs e)
        {
            ExibirLista();
        }

        public virtual void GridLista_SelectionChanged(object sender, EventArgs e)
        {

        }

        public virtual void TxtLocalizar_TextChanged(object sender, EventArgs e)
        {

        }

        public virtual  void BtnNovo_Click(object sender, EventArgs e)
        {

            ExibirCadastro();

        }

        public virtual void BtnEditar_Click(object sender, EventArgs e)
        {
            ExibirCadastro();
        }

         public virtual void BtnExcluir_Click(object sender, EventArgs e)
        {
            ExibirLista();

        }

       public virtual void BtnCancelar_Click(object sender, EventArgs e)
        {
            ExibirLista();
        }

        public virtual void BtnConfirmar_Click(object sender, EventArgs e)
        {
            ExibirLista();
        }

       
    }
}
