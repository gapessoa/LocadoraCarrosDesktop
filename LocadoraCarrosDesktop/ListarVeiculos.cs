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
    public partial class ListarVeiculos : Form
    {
        public ListarVeiculos()
        {
            InitializeComponent();

            groupBox1.Anchor =
                                AnchorStyles.Bottom |
                AnchorStyles.Right |
                AnchorStyles.Top |
                AnchorStyles.Left;
        }

        private void ListarVeiculos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'locadoraDataSet.veiculos' table. You can move, or remove it, as needed.
            this.veiculosTableAdapter.Fill(this.locadoraDataSet.veiculos);
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.veiculosTableAdapter.Fill(this.locadoraDataSet.veiculos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var SelectedIndex = veiculosDataGridView.CurrentCell.RowIndex;
            MessageBox.Show(SelectedIndex.ToString());
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Você tem certeza que deseja deletar este registro?", "Deletar Registro?",
                      MessageBoxButtons.OKCancel,
                      MessageBoxIcon.Question,
                      MessageBoxDefaultButton.Button2);

            if (response != DialogResult.Cancel)
            {

                int rowindex = veiculosDataGridView.CurrentCell.RowIndex;

                string id = veiculosDataGridView.Rows[rowindex].Cells[0].Value.ToString();

                theConn conn = new theConn();

                conn.Cmd("DELETE FROM veiculos WHERE id = '" + id + "'");

                veiculosDataGridView.Rows.RemoveAt(rowindex);
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            int rowindex = veiculosDataGridView.CurrentCell.RowIndex;
            
            string id = veiculosDataGridView.Rows[rowindex].Cells[0].Value.ToString();

            CadastrarVeiculo form = new CadastrarVeiculo(id);
            form.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            CadastrarVeiculo form = new CadastrarVeiculo();
            form.ShowDialog();
        }
    }
}
