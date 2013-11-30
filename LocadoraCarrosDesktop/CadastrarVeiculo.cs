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
    public partial class CadastrarVeiculo : Form
    {
        public CadastrarVeiculo()
        {
            InitializeComponent();

            Dictionary<string, string> cb_data_marcas = new Dictionary<string, string>();
            Dictionary<string, string> cb_data_combustiveis = new Dictionary<string, string>();

            theConn conn = new theConn();
            theConn conn2 = new theConn();

            var marcas = conn.Select("SELECT id,nome FROM veiculo_marcas");

            foreach (var marca in marcas)
            {
                cb_data_marcas.Add(marca["id"].ToString(), marca["nome"].ToString());
            }

            cbMarca.DataSource = new BindingSource(cb_data_marcas, null);
            cbMarca.DisplayMember = "Value";
            cbMarca.ValueMember = "Key";


            var combustiveis = conn2.Select("SELECT id,nome FROM combustivel");

            foreach (var combustivel in combustiveis)
            {
                cb_data_combustiveis.Add(combustivel["id"].ToString(), combustivel["nome"].ToString());
            }

            cbCombustivel.DataSource = new BindingSource(cb_data_combustiveis, null);
            cbCombustivel.DisplayMember = "Value";
            cbCombustivel.ValueMember = "Key";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            theConn conn = new theConn();

            conn.InsertItem("nome", txtNome.Text);
            conn.InsertItem("placa", txtPlaca.Text);
            conn.InsertItem("chassi", txtChassi.Text);
            conn.InsertItem("cor", txtCor.Text);
            conn.InsertItem("modelo", txtModelo.Text);
            conn.InsertItem("ano", txtAno.Text);
            conn.InsertItem("km", txtKm.Text);
            conn.InsertItem("tipo_combustivel", cbCombustivel.SelectedValue.ToString());
            conn.InsertItem("marca_id", cbMarca.SelectedValue.ToString());

            conn.Insert("veiculos");

            MessageBox.Show("O veículo foi cadastrado com sucesso!");

            this.Close();
        }
    }
}
