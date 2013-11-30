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
    public partial class CadastrarCondutor : Form
    {
        public CadastrarCondutor()
        {
            InitializeComponent();
            
            theConn conn = new theConn();
            List<string> cb_estados = new List<string>();

            var estados = conn.Select("SELECT uf FROM estados ORDER BY uf ASC");

            foreach (var estado in estados)
            {
                cb_estados.Add(estado["uf"].ToString());
            }

            cbEstado.DataSource = cb_estados;

            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCidade.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            theConn conn = new theConn();

            conn.InsertItem("nome", txtNome.Text);
            conn.InsertItem("cpf", txtCPF.Text);
            conn.InsertItem("rg", txtRG.Text);
            conn.InsertItem("email", txtEmail.Text);
            conn.InsertItem("cnh_registro", txtCNHRegistro.Text);
            conn.InsertItem("cnh_data_expedicao", Convert.ToDateTime(txtCNHExpedicao.Text).ToString("yyyy-MM-dd"));
            conn.InsertItem("cnh_data_primeira_habilitacao", Convert.ToDateTime(txtCNHPrimeiraHabilitacao.Text).ToString("yyyy-MM-dd"));
            conn.InsertItem("cnh_vencimento", Convert.ToDateTime(txtCNHVencimento.Text).ToString("yyyy-MM-dd"));
            conn.InsertItem("cidade", cbCidade.SelectedValue.ToString());
            conn.InsertItem("estado", cbEstado.SelectedValue.ToString());
            conn.InsertItem("logradouro", txtLogradouro.Text);
            conn.InsertItem("cep", txtCEP.Text);
            conn.InsertItem("complemento", txtComplemento.Text);
            conn.InsertItem("bairro", txtBairro.Text);

            conn.Insert("condutores");

            MessageBox.Show("O condutor foi cadastrado com sucesso!");
            
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKm_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            var estado = cbEstado.SelectedValue.ToString();
            
            theConn conn2 = new theConn();

            List<string> cb_cidades = new List<string>();

            var cidades = conn2.Select("Select nome FROM cidades WHERE uf = '" + estado + "'"
                );

            foreach (var cidade in cidades)
            {
                cb_cidades.Add(cidade["nome"].ToString());
            }

            cbCidade.DataSource = cb_cidades;
        }
    }
}
