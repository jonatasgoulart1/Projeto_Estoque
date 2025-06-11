using Estoque.Derivadas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void parametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FrmCadParametros frmCadParam = new FrmCadParametros())
            {
                frmCadParam.ShowDialog();
            }

        }

        private void usuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FrmCadUsuarios frmCadUser = new FrmCadUsuarios())
            { frmCadUser.ShowDialog();}
        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmCadClasses frmCadclasses = new FrmCadClasses())
            {
                { frmCadclasses.ShowDialog(); }
            
            }
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FrmCadGrupos frmCadgrupos = new FrmCadGrupos())
            { frmCadgrupos.ShowDialog(); }
        }

        private void familiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FrmCadFamilias frmCadFamilias = new FrmCadFamilias())
            { frmCadFamilias.ShowDialog(); }
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FrmCadDepartamentos frmCaddepartamentos = new FrmCadDepartamentos())
            { frmCaddepartamentos.ShowDialog(); }
        }

     

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmCadProdutos frmCadprodutos = new FrmCadProdutos())
            { frmCadprodutos.ShowDialog(); }
        }

        private void movimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FrmCadMovimentos frmCadmovimento = new FrmCadMovimentos())
            { frmCadmovimento.ShowDialog();}
        }

        private void tipoMovimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FrmTipoMovimento frmTipomovimento = new FrmTipoMovimento())
            { frmTipomovimento.ShowDialog(); }
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmCadFornecedores frmcadFornecedores = new FrmCadFornecedores())
            { frmcadFornecedores.ShowDialog(); }
        }
    }
}
