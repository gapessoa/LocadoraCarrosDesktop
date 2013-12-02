using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace LocadoraCarrosDesktop
{
    public partial class ListarLocacoes : Form
    {
        public ListarLocacoes()
        {
            InitializeComponent();

            groupBox1.Anchor =
                                AnchorStyles.Bottom |
                AnchorStyles.Right |
                AnchorStyles.Top |
                AnchorStyles.Left;
        }

        private void ListarLocacoes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'locadoraDataSet.locacoes' table. You can move, or remove it, as needed.
            this.locacoesTableAdapter.Fill(this.locadoraDataSet.locacoes);

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            CadastrarLocacao form = new CadastrarLocacao();
            form.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.locacoesTableAdapter.Fill(this.locadoraDataSet.locacoes);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int rowindex = locacoesDataGridView.CurrentCell.RowIndex;

            string id = locacoesDataGridView.Rows[rowindex].Cells[0].Value.ToString();

            CadastrarDevolucao form = new CadastrarDevolucao(id);
            form.ShowDialog();
        }
    }
}
