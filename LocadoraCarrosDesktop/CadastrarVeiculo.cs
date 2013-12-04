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
        private string id;
        private bool update_mode = false;
        private string imagePath = null;
        private string privatePath = @"C:\Users\Gabriel\Documents\GitHub\LocadoraCarrosDesktop\LocadoraCarrosDesktop\Img\";

        public CadastrarVeiculo(string id = "vazio")
        {
            this.id = id;

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

            if (this.id != "vazio")
            {
                this.getValues();
                this.chanceTitles();
                this.update_mode = true;
            }

            cbCombustivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void chanceTitles()
        {
            groupBox1.Text = "Editar Veículo";
            this.Text = "Editar Veículo";
        }

        private void getValues()
        {
            theConn conn = new theConn();

            var rows = conn.Select("SELECT * FROM veiculos WHERE id = '" + this.id + "'");

            txtNome.Text = rows[0]["nome"].ToString();
            txtPlaca.Text = rows[0]["placa"].ToString();
            txtChassi.Text = rows[0]["chassi"].ToString();
            txtCor.Text = rows[0]["cor"].ToString();
            txtModelo.Text = rows[0]["modelo"].ToString();
            txtAno.Text = rows[0]["ano"].ToString();
            txtKm.Text = rows[0]["km"].ToString();
            cbCombustivel.SelectedValue = rows[0]["tipo_combustivel"].ToString();
            cbMarca.SelectedValue = rows[0]["marca_id"].ToString();
            pctCarro.Image = Image.FromFile(this.privatePath + rows[0]["imgfile"].ToString() + ".png");

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
            conn.InsertItem("imgfile", this.imagePath);

            string msg = "Erro";

            if (!this.update_mode)
            {
                conn.Insert("veiculos");

                msg = "O veículo foi cadastrado com sucesso!";
            }
            else
            {
                conn.Update("veiculos", "id", this.id);

                msg = "O veículo foi editado com sucesso!";
            }

            MessageBox.Show(msg);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog photo = new OpenFileDialog();
            photo.Filter = "Images only. | *.jpg; *.jpeg; *.png; *.gif;";

            DialogResult dr = photo.ShowDialog();

            pctCarro.Image = Image.FromFile(photo.FileName);

            lblImgPath.Text = photo.FileName;

            var imagem = Image.FromFile(photo.FileName);
            var newImage = this.ScaleImage(imagem, 217, 248);
            string imageName = this.GenerateId();
            newImage.Save(this.privatePath + imageName + ".png", System.Drawing.Imaging.ImageFormat.Png);

            pctCarro.Image = newImage;

            this.imagePath = imageName;
        }

        //private void upload_photo(string fullPath, string sourcePath, string fileName)
        //{
        //    string targetPath =  @"C:\Users\Gabriel\Documents\GitHub\LocadoraCarrosDesktop\LocadoraCarrosDesktop\Img\";

        //    string getExtension = System.IO.Path.GetExtension(fullPath);

        //    string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
        //    string destFile = System.IO.Path.Combine(targetPath, this.GenerateId() + getExtension);

        //    if (!System.IO.Directory.Exists(targetPath))
        //    {
        //        System.IO.Directory.CreateDirectory(targetPath);
        //    }

        //    System.IO.File.Copy(sourceFile, destFile, true);
        //}

        private string GenerateId()
        {
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }
            return string.Format("{0:x}", i - DateTime.Now.Ticks);
        }

        private Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
            return newImage;
        }
    }
}
