using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraCarrosDesktop
{
    public partial class CadastrarMarca : Form
    {
        public CadastrarMarca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            theConn conn = new theConn();

            conn.InsertItem("nome", textBox1.Text);
            conn.Insert("veiculo_marcas");

            MessageBox.Show("Sua marca foi cadastrada com sucesso!");

            this.Close();
        }
    }
}
