namespace LocadoraCarrosDesktop
{
    partial class CadastrarDevolucao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtKmSaida = new System.Windows.Forms.MaskedTextBox();
            this.txtDiariasPrevistas = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDataSaida = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFranquiaDia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.Label();
            this.txtDataReserva = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLocatario = new System.Windows.Forms.TextBox();
            this.txtCondutor = new System.Windows.Forms.TextBox();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDataContrato = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKMDevolucao = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDataDevolucao = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTipo);
            this.groupBox1.Controls.Add(this.txtKmSaida);
            this.groupBox1.Controls.Add(this.txtDiariasPrevistas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDataSaida);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDestino);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFranquiaDia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Tipo);
            this.groupBox1.Controls.Add(this.txtDataReserva);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Locação";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(284, 37);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(121, 20);
            this.txtTipo.TabIndex = 15;
            // 
            // txtKmSaida
            // 
            this.txtKmSaida.Location = new System.Drawing.Point(284, 162);
            this.txtKmSaida.Mask = "000000";
            this.txtKmSaida.Name = "txtKmSaida";
            this.txtKmSaida.ReadOnly = true;
            this.txtKmSaida.Size = new System.Drawing.Size(121, 20);
            this.txtKmSaida.TabIndex = 14;
            // 
            // txtDiariasPrevistas
            // 
            this.txtDiariasPrevistas.Location = new System.Drawing.Point(284, 78);
            this.txtDiariasPrevistas.Mask = "00";
            this.txtDiariasPrevistas.Name = "txtDiariasPrevistas";
            this.txtDiariasPrevistas.ReadOnly = true;
            this.txtDiariasPrevistas.Size = new System.Drawing.Size(22, 20);
            this.txtDiariasPrevistas.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "KM Saída";
            // 
            // txtDataSaida
            // 
            this.txtDataSaida.Location = new System.Drawing.Point(86, 162);
            this.txtDataSaida.Mask = "00/00/0000";
            this.txtDataSaida.Name = "txtDataSaida";
            this.txtDataSaida.ReadOnly = true;
            this.txtDataSaida.Size = new System.Drawing.Size(100, 20);
            this.txtDataSaida.TabIndex = 11;
            this.txtDataSaida.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data Saída";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(86, 116);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.ReadOnly = true;
            this.txtDestino.Size = new System.Drawing.Size(319, 20);
            this.txtDestino.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Diárias Previstas";
            // 
            // txtFranquiaDia
            // 
            this.txtFranquiaDia.Location = new System.Drawing.Point(86, 75);
            this.txtFranquiaDia.Name = "txtFranquiaDia";
            this.txtFranquiaDia.ReadOnly = true;
            this.txtFranquiaDia.Size = new System.Drawing.Size(100, 20);
            this.txtFranquiaDia.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Franquia Dia";
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Location = new System.Drawing.Point(192, 37);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(28, 13);
            this.Tipo.TabIndex = 2;
            this.Tipo.Text = "Tipo";
            // 
            // txtDataReserva
            // 
            this.txtDataReserva.Location = new System.Drawing.Point(86, 34);
            this.txtDataReserva.Mask = "00/00/0000";
            this.txtDataReserva.Name = "txtDataReserva";
            this.txtDataReserva.ReadOnly = true;
            this.txtDataReserva.Size = new System.Drawing.Size(100, 20);
            this.txtDataReserva.TabIndex = 1;
            this.txtDataReserva.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Reserva";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLocatario);
            this.groupBox2.Controls.Add(this.txtCondutor);
            this.groupBox2.Controls.Add(this.txtVeiculo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDataContrato);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(13, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 180);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Contrato";
            // 
            // txtLocatario
            // 
            this.txtLocatario.Location = new System.Drawing.Point(85, 140);
            this.txtLocatario.Name = "txtLocatario";
            this.txtLocatario.ReadOnly = true;
            this.txtLocatario.Size = new System.Drawing.Size(319, 20);
            this.txtLocatario.TabIndex = 24;
            // 
            // txtCondutor
            // 
            this.txtCondutor.Location = new System.Drawing.Point(85, 111);
            this.txtCondutor.Name = "txtCondutor";
            this.txtCondutor.ReadOnly = true;
            this.txtCondutor.Size = new System.Drawing.Size(319, 20);
            this.txtCondutor.TabIndex = 23;
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Location = new System.Drawing.Point(85, 83);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.ReadOnly = true;
            this.txtVeiculo.Size = new System.Drawing.Size(319, 20);
            this.txtVeiculo.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Locatário";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Condutor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Veículo";
            // 
            // txtDataContrato
            // 
            this.txtDataContrato.Location = new System.Drawing.Point(85, 39);
            this.txtDataContrato.Mask = "00/00/0000";
            this.txtDataContrato.Name = "txtDataContrato";
            this.txtDataContrato.ReadOnly = true;
            this.txtDataContrato.Size = new System.Drawing.Size(100, 20);
            this.txtDataContrato.TabIndex = 16;
            this.txtDataContrato.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Data";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtKMDevolucao);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtDataDevolucao);
            this.groupBox3.Location = new System.Drawing.Point(12, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 122);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados da Devoluçao";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(134, 78);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(94, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Valor Total da Locação";
            // 
            // txtKMDevolucao
            // 
            this.txtKMDevolucao.Location = new System.Drawing.Point(235, 28);
            this.txtKMDevolucao.Mask = "000000";
            this.txtKMDevolucao.Name = "txtKMDevolucao";
            this.txtKMDevolucao.Size = new System.Drawing.Size(100, 20);
            this.txtKMDevolucao.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(205, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "KM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Data";
            // 
            // txtDataDevolucao
            // 
            this.txtDataDevolucao.Location = new System.Drawing.Point(86, 29);
            this.txtDataDevolucao.Mask = "00/00/0000";
            this.txtDataDevolucao.Name = "txtDataDevolucao";
            this.txtDataDevolucao.Size = new System.Drawing.Size(100, 20);
            this.txtDataDevolucao.TabIndex = 0;
            this.txtDataDevolucao.ValidatingType = typeof(System.DateTime);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CadastrarDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 644);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadastrarDevolucao";
            this.Text = "Cadastrar Devolução";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.MaskedTextBox txtDataReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFranquiaDia;
        private System.Windows.Forms.MaskedTextBox txtKmSaida;
        private System.Windows.Forms.MaskedTextBox txtDiariasPrevistas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtDataSaida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtDataContrato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtLocatario;
        private System.Windows.Forms.TextBox txtCondutor;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtKMDevolucao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtDataDevolucao;
        private System.Windows.Forms.Button button2;
    }
}