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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Anchor =
                AnchorStyles.Bottom |
                AnchorStyles.Right |
                AnchorStyles.Top |
                AnchorStyles.Left;

            groupBox1.Anchor =
                                AnchorStyles.Bottom |
                AnchorStyles.Right |
                AnchorStyles.Top |
                AnchorStyles.Left;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'locadoraDataSet.condutores' table. You can move, or remove it, as needed.
            this.condutoresTableAdapter.Fill(this.locadoraDataSet.condutores);

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.condutoresTableAdapter.FillBy(this.locadoraDataSet.condutores);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastrarVeiculo cadastrarForm = new CadastrarVeiculo();
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
    }
}
