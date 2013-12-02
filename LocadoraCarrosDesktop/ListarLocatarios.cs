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
    public partial class ListarLocatarios : Form
    {
        public ListarLocatarios()
        {
            InitializeComponent();

            groupBox1.Anchor =
                                AnchorStyles.Bottom |
                AnchorStyles.Right |
                AnchorStyles.Top |
                AnchorStyles.Left;
        }

        private void ListarLocatarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'locadoraDataSet.locatarios' table. You can move, or remove it, as needed.
            this.locatariosTableAdapter.Fill(this.locadoraDataSet.locatarios);
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastrarLocatario cadastrarForm = new CadastrarLocatario();
            cadastrarForm.ShowDialog();
        }

        private void cadastrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            CadastrarMarca cadastrarForm = new CadastrarMarca();
            cadastrarForm.ShowDialog();
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CadastrarVeiculo cadastrarForm = new CadastrarVeiculo();
            cadastrarForm.ShowDialog();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CadastrarCondutor cadastrarForm = new CadastrarCondutor();
            cadastrarForm.ShowDialog();
        }


        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CadastrarLocatario form = new CadastrarLocatario();
            form.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int rowindex = locatariosDataGridView.CurrentCell.RowIndex;

            string id = locatariosDataGridView.Rows[rowindex].Cells[0].Value.ToString();

            CadastrarLocatario form = new CadastrarLocatario(id);
            form.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.locatariosTableAdapter.Fill(this.locadoraDataSet.locatarios);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Você tem certeza que deseja deletar este registro?", "Deletar Registro?",
         MessageBoxButtons.OKCancel,
         MessageBoxIcon.Question,
         MessageBoxDefaultButton.Button2);

            if (response != DialogResult.Cancel)
            {

                int rowindex = locatariosDataGridView.CurrentCell.RowIndex;

                string id = locatariosDataGridView.Rows[rowindex].Cells[0].Value.ToString();

                theConn conn = new theConn();

                conn.Cmd("DELETE FROM locatarios WHERE id = '" + id + "'");

                locatariosDataGridView.Rows.RemoveAt(rowindex);
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            CadastrarLocatario form = new CadastrarLocatario();

            form.ShowDialog();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            int rowindex = locatariosDataGridView.CurrentCell.RowIndex;

            string id = locatariosDataGridView.Rows[rowindex].Cells[0].Value.ToString();

            CadastrarLocatario form = new CadastrarLocatario(id);
            form.ShowDialog();
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Você tem certeza que deseja deletar este registro?", "Deletar Registro?",
                MessageBoxButtons.OKCancel,
                 MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (response != DialogResult.Cancel)
            {

                int rowindex = locatariosDataGridView.CurrentCell.RowIndex;

                string id = locatariosDataGridView.Rows[rowindex].Cells[0].Value.ToString();

                theConn conn = new theConn();

                conn.Cmd("DELETE FROM locatarios WHERE id = '" + id + "'");

                locatariosDataGridView.Rows.RemoveAt(rowindex);
            }
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            this.locatariosTableAdapter.Fill(this.locadoraDataSet.locatarios);
        }


    }
}
