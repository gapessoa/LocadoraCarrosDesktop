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
        private string id;
        private bool update_mode = false;

        public CadastrarCondutor(string id = "vazio")
        {
            this.id = id;

            InitializeComponent();

            theConn conn = new theConn();
            List<string> cb_estados = new List<string>();

            var estados = conn.Select("SELECT uf FROM estados ORDER BY uf ASC");

            foreach (var estado in estados)
            {
                cb_estados.Add(estado["uf"].ToString());
            }

            cbEstado.DataSource = cb_estados;

            if (this.id != "vazio")
            {
                Console.WriteLine(this.id);
                this.getValues();
                this.chanceTitles();
                this.update_mode = true;
            }

            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCidade.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void chanceTitles()
        {
            groupBox1.Text = "Editar Condutor";
            this.Text = "Editar Condutor";
        }

        private void getValues()
        {
            theConn conn = new theConn();

            var rows = conn.Select("SELECT condutores.id,condutores.nome,condutores.cpf,condutores.rg,condutores.email,condutores.cnh_registro,DATE_FORMAT(condutores.cnh_data_expedicao, '%d/%c/%Y') as cnh_data_expedicao,DATE_FORMAT(condutores.cnh_data_primeira_habilitacao, '%d/%c/%Y') as cnh_data_primeira_habilitacao,DATE_FORMAT(condutores.cnh_vencimento, '%d/%c/%Y') as cnh_vencimento,condutores.cidade,condutores.estado,condutores.logradouro,condutores.bairro,condutores.cep,condutores.complemento FROM condutores WHERE id = '" + this.id + "'");

            txtNome.Text = rows[0]["nome"].ToString();
            txtCPF.Text = rows[0]["cpf"].ToString();
            txtEmail.Text = rows[0]["email"].ToString();
            txtCNHRegistro.Text = rows[0]["cnh_registro"].ToString();
            txtCNHExpedicao.Text = Convert.ToDateTime(rows[0]["cnh_data_expedicao"]).ToString();
            txtCNHPrimeiraHabilitacao.Text = Convert.ToDateTime(rows[0]["cnh_data_primeira_habilitacao"]).ToString();
            txtCNHVencimento.Text = Convert.ToDateTime(rows[0]["cnh_vencimento"]).ToString();
            cbEstado.SelectedItem = rows[0]["estado"].ToString();
            cbCidade.SelectedItem = rows[0]["cidade"].ToString();
            txtLogradouro.Text = rows[0]["logradouro"].ToString();
            txtCEP.Text = rows[0]["cep"].ToString();
            txtComplemento.Text = rows[0]["complemento"].ToString();
            txtBairro.Text = rows[0]["bairro"].ToString();
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

            string msg = "Erro";

            if (!this.update_mode)
            {
                conn.Insert("condutores");

                msg = "O condutor foi cadastrado com sucesso!";
            }
            else
            {
                conn.Update("condutores", "id", this.id);

                msg = "O condutor foi editado com sucesso!";
            }

            MessageBox.Show(msg);
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
