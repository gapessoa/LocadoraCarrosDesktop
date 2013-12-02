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
    public partial class CadastrarLocatario : Form
    {
        private string id;
        private bool update_mode = false;

        public CadastrarLocatario(string id = "vazio")
        {
            this.id = id;

            InitializeComponent();

            theConn conn = new theConn();
            theConn conn2 = new theConn();
            Dictionary<string, string> cb_tipos = new Dictionary<string, string>();

            var tipos = conn.Select("SELECT id, nome FROM tipo_pessoa");

            foreach (var tipo in tipos)
            {
                cb_tipos.Add(tipo["id"].ToString(), tipo["nome"].ToString());
            }

            cbTipo.DataSource = new BindingSource(cb_tipos, null);
            cbTipo.DisplayMember = "Value";
            cbTipo.ValueMember = "Key";

            List<string> cb_estados = new List<string>();

            var estados = conn2.Select("SELECT uf FROM estados ORDER BY uf ASC");

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
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void chanceTitles()
        {
            groupBox1.Text = "Editar Locatário";
            this.Text = "Editar Locatário";
        }

        private void getValues()
        {
            theConn conn = new theConn();

            var rows = conn.Select("SELECT * FROM locatarios WHERE id = '" + this.id + "'");

            txtNome.Text = rows[0]["nome"].ToString();
            txtCPF.Text = rows[0]["cpf"].ToString();
            txtEmail.Text = rows[0]["email"].ToString();
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

            var tipo = cbTipo.SelectedValue.ToString();

            if (tipo == "0")
            {
                conn.InsertItem("cpf", txtCPF.Text);
                conn.InsertItem("nome", txtNome.Text);
                conn.InsertItem("rg", txtRG.Text);
            }
            else
            {
                conn.InsertItem("nome_fantasia", txtCPF.Text);
                conn.InsertItem("cnpj", txtRG.Text);
                conn.InsertItem("nome", txtNome.Text);
            }

            conn.InsertItem("tipo", tipo);
            conn.InsertItem("email", txtEmail.Text);
            conn.InsertItem("logradouro", txtLogradouro.Text);
            conn.InsertItem("complemento", txtComplemento.Text);
            conn.InsertItem("estado", cbEstado.SelectedValue.ToString());
            conn.InsertItem("cidade", cbCidade.SelectedValue.ToString());
            conn.InsertItem("bairro", txtBairro.Text);
            conn.InsertItem("cep", txtCEP.Text);

            string msg = "Erro";

            if (!this.update_mode)
            {
                conn.Insert("locatarios");

                msg = "O condutor foi cadastrado com sucesso!";
            }
            else
            {
                conn.Update("locatarios", "id", this.id);

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

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipo.SelectedValue.ToString() != "1")
            {

                lblNome.Text = "Nome";
                lblCPF.Text = "CPF";
                lblRG.Text = "RG";
                txtCPF.MaxLength = 11;
                txtRG.MaxLength = 12;
            }
            else
            {
                lblNome.Text = "Razão Social";
                lblCPF.Text = "Nome Fantasia";
                lblRG.Text = "CNPJ";
                txtCPF.MaxLength = 255;
                txtRG.MaxLength = 14;
            }
            txtRG.Clear();
            txtCPF.Clear();
        }
    }
}
