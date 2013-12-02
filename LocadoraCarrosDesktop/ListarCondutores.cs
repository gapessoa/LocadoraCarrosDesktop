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
    public partial class ListarCondutores : Form
    {
        public ListarCondutores()
        {
            InitializeComponent();
            //dataGridView1.Anchor =
            //    AnchorStyles.Bottom |
            //    AnchorStyles.Right |
            //    AnchorStyles.Top |
            //    AnchorStyles.Left;

            groupBox1.Anchor =
                                AnchorStyles.Bottom |
                AnchorStyles.Right |
                AnchorStyles.Top |
                AnchorStyles.Left;
        }

        private void ListarCondutores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'locadoraDataSet.condutores' table. You can move, or remove it, as needed.
            this.condutoresTableAdapter.Fill(this.locadoraDataSet.condutores);

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

        private void condutoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.condutoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.locadoraDataSet);

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.condutoresTableAdapter.Fill(this.locadoraDataSet.condutores);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            int rowindex = condutoresDataGridView.CurrentCell.RowIndex;

            string id = condutoresDataGridView.Rows[rowindex].Cells[0].Value.ToString();

            CadastrarCondutor form = new CadastrarCondutor(id);
            form.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CadastrarCondutor form = new CadastrarCondutor();
            form.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Você tem certeza que deseja deletar este registro?", "Deletar Registro?",
          MessageBoxButtons.OKCancel,
          MessageBoxIcon.Question,
          MessageBoxDefaultButton.Button2);

            if (response != DialogResult.Cancel)
            {

                int rowindex = condutoresDataGridView.CurrentCell.RowIndex;

                string id = condutoresDataGridView.Rows[rowindex].Cells[0].Value.ToString();

                theConn conn = new theConn();

                conn.Cmd("DELETE FROM condutores WHERE id = '" + id + "'");

                condutoresDataGridView.Rows.RemoveAt(rowindex);
            }

        }



    }
}
