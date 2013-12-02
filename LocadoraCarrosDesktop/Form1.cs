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

            //groupBox1.Anchor =
            //                    AnchorStyles.Bottom |
            //    AnchorStyles.Right |
            //    AnchorStyles.Top |
            //    AnchorStyles.Left;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
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
            ListarCondutores form = new ListarCondutores();
            form.MdiParent = this;
            form.Show();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListarLocatarios form = new ListarLocatarios();
            form.MdiParent = this;
            form.Show();
        }

        private void listarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ListarMarcas form = new ListarMarcas();
            form.MdiParent = this;
            form.Show();
        }

        private void listarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ListarVeiculos form = new ListarVeiculos();
            form.MdiParent = this;
            form.Show();
        }

        private void cadastrarToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            CadastrarVeiculo cadastrarForm = new CadastrarVeiculo();
            cadastrarForm.ShowDialog();
        }

        private void cadastrarToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            CadastrarCondutor form = new CadastrarCondutor();
            form.ShowDialog();
        }

    }
}
