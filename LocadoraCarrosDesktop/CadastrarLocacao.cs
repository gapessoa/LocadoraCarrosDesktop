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
    public partial class CadastrarLocacao : Form
    {
        private string privatePath = @"C:\Users\Gabriel\Documents\GitHub\LocadoraCarrosDesktop\LocadoraCarrosDesktop\Img\";

        public CadastrarLocacao()
        {
            InitializeComponent();

            this.load_Veiculos();
            this.load_CbTipo();
            this.load_Condutores();
            this.load_Locatarios();

        }

        private void load_CbTipo()
        {
            Dictionary<string, string> tipoLocacao = new Dictionary<string, string>();
            tipoLocacao.Add("0", "Diária");
            tipoLocacao.Add("1", "Mensal");

            cbTipo.DataSource = new BindingSource(tipoLocacao, null);
            cbTipo.DisplayMember = "Value";
            cbTipo.ValueMember = "Key";
        }

        private void load_Condutores()
        {
            theConn conn = new theConn();
            var rows = conn.Select("SELECT id,nome FROM condutores ORDER BY nome ASC");
            Dictionary<string, string> cbData = new Dictionary<string, string>();

            foreach (var row in rows)
            {
                cbData.Add(row["id"].ToString(), row["nome"].ToString());
            }

            cbCondutor.DataSource = new BindingSource(cbData, null);
            cbCondutor.DisplayMember = "Value";
            cbCondutor.ValueMember = "Key";
        }

        private void load_Veiculos()
        {
            cbVeiculo.SelectedIndexChanged -= new System.EventHandler(this.cbVeiculo_SelectedIndexChanged);

            theConn conn = new theConn();
            var rows = conn.Select("SELECT id,nome FROM veiculos WHERE alugado = 0 ORDER BY nome ASC");
            Dictionary<string, string> cbData = new Dictionary<string, string>();

            foreach (var row in rows)
            {
                cbData.Add(row["id"].ToString(), row["nome"].ToString());
            }

            cbVeiculo.DataSource = new BindingSource(cbData, null);
            cbVeiculo.DisplayMember = "Value";
            cbVeiculo.ValueMember = "Key";

            cbVeiculo.SelectedIndexChanged += new System.EventHandler(this.cbVeiculo_SelectedIndexChanged);

            cbVeiculo.SelectedIndex = 1;
            cbVeiculo.SelectedIndex = 0;


        }

        private void load_Locatarios()
        {
            theConn conn = new theConn();
            var rows = conn.Select("SELECT id,nome FROM locatarios ORDER BY nome ASC");
            Dictionary<string, string> cbData = new Dictionary<string, string>();

            foreach (var row in rows)
            {
                cbData.Add(row["id"].ToString(), row["nome"].ToString());
            }

            cbLocatario.DataSource = new BindingSource(cbData, null);
            cbLocatario.DisplayMember = "Value";
            cbLocatario.ValueMember = "Key";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            theConn conn = new theConn();

            conn.InsertItem("data_reserva", Convert.ToDateTime(txtDataReserva.Text).ToString("yyyy-MM-dd"));
            conn.InsertItem("tipo_locacao", cbTipo.SelectedValue.ToString());
            conn.InsertItem("franquia_dia", txtFranquiaDia.Text);
            conn.InsertItem("diarias_previstas", txtDiariasPrevistas.Text);
            conn.InsertItem("destino", txtDestino.Text);
            conn.InsertItem("data_saida", Convert.ToDateTime(txtDataSaida.Text).ToString("yyyy-MM-dd"));
            conn.InsertItem("km_saida", txtKmSaida.Text);
            conn.InsertItem("data_contrato", Convert.ToDateTime(txtDataContrato.Text).ToString("yyyy-MM-dd"));
            conn.InsertItem("veiculo_id", cbVeiculo.SelectedValue.ToString());
            conn.InsertItem("condutor_id", cbCondutor.SelectedValue.ToString());
            conn.InsertItem("locatario_id", cbLocatario.SelectedValue.ToString());

            conn.Insert("locacoes");

            theConn conn2 = new theConn();
            conn2.InsertItem("alugado", "1");
            conn2.Update("veiculos", "id", cbVeiculo.SelectedValue.ToString());

            MessageBox.Show("Locação cadastrada com sucesso!");

            this.Close();
        }

        private void cbVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

            string veiculoID = cbVeiculo.SelectedValue.ToString();

            Console.WriteLine(veiculoID);
            theConn conn3 = new theConn();

            var veiculoPhoto = conn3.Select("SELECT imgfile FROM veiculos WHERE id = '" + veiculoID + "' ORDER BY nome ASC");

            string file = veiculoPhoto[0]["imgfile"].ToString();

            string filename = file;

            pctCarro.Image = Image.FromFile(this.privatePath + filename);


        }
    }
}
