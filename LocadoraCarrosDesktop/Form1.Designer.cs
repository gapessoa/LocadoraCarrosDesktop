namespace LocadoraCarrosDesktop
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locatáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.condutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.condutoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locadoraDataSet = new LocadoraCarrosDesktop.locadoraDataSet();
            this.condutoresTableAdapter = new LocadoraCarrosDesktop.locadoraDataSetTableAdapters.condutoresTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.condutoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locadoraDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.locatáriosToolStripMenuItem,
            this.condutoresToolStripMenuItem,
            this.veículosToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1267, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem,
            this.cadastrarToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            this.toolStripMenuItem1.Text = "Locações";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // locatáriosToolStripMenuItem
            // 
            this.locatáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem1,
            this.cadastrarToolStripMenuItem1});
            this.locatáriosToolStripMenuItem.Name = "locatáriosToolStripMenuItem";
            this.locatáriosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.locatáriosToolStripMenuItem.Text = "Locatários";
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.listarToolStripMenuItem1.Text = "Listar";
            // 
            // cadastrarToolStripMenuItem1
            // 
            this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.cadastrarToolStripMenuItem1.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarToolStripMenuItem1_Click);
            // 
            // condutoresToolStripMenuItem
            // 
            this.condutoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem2,
            this.cadastrarToolStripMenuItem2});
            this.condutoresToolStripMenuItem.Name = "condutoresToolStripMenuItem";
            this.condutoresToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.condutoresToolStripMenuItem.Text = "Condutores";
            // 
            // listarToolStripMenuItem2
            // 
            this.listarToolStripMenuItem2.Name = "listarToolStripMenuItem2";
            this.listarToolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.listarToolStripMenuItem2.Text = "Listar";
            // 
            // cadastrarToolStripMenuItem2
            // 
            this.cadastrarToolStripMenuItem2.Name = "cadastrarToolStripMenuItem2";
            this.cadastrarToolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.cadastrarToolStripMenuItem2.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem2.Click += new System.EventHandler(this.cadastrarToolStripMenuItem2_Click);
            // 
            // veículosToolStripMenuItem
            // 
            this.veículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem3,
            this.cadastrarToolStripMenuItem3});
            this.veículosToolStripMenuItem.Name = "veículosToolStripMenuItem";
            this.veículosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.veículosToolStripMenuItem.Text = "Veículos";
            // 
            // listarToolStripMenuItem3
            // 
            this.listarToolStripMenuItem3.Name = "listarToolStripMenuItem3";
            this.listarToolStripMenuItem3.Size = new System.Drawing.Size(124, 22);
            this.listarToolStripMenuItem3.Text = "Listar";
            // 
            // cadastrarToolStripMenuItem3
            // 
            this.cadastrarToolStripMenuItem3.Name = "cadastrarToolStripMenuItem3";
            this.cadastrarToolStripMenuItem3.Size = new System.Drawing.Size(124, 22);
            this.cadastrarToolStripMenuItem3.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem3.Click += new System.EventHandler(this.cadastrarToolStripMenuItem3_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem4,
            this.cadastrarToolStripMenuItem4});
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.marcasToolStripMenuItem.Text = "Marcas";
            // 
            // listarToolStripMenuItem4
            // 
            this.listarToolStripMenuItem4.Name = "listarToolStripMenuItem4";
            this.listarToolStripMenuItem4.Size = new System.Drawing.Size(124, 22);
            this.listarToolStripMenuItem4.Text = "Listar";
            // 
            // cadastrarToolStripMenuItem4
            // 
            this.cadastrarToolStripMenuItem4.Name = "cadastrarToolStripMenuItem4";
            this.cadastrarToolStripMenuItem4.Size = new System.Drawing.Size(124, 22);
            this.cadastrarToolStripMenuItem4.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem4.Click += new System.EventHandler(this.cadastrarToolStripMenuItem4_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // condutoresBindingSource
            // 
            this.condutoresBindingSource.DataMember = "condutores";
            this.condutoresBindingSource.DataSource = this.locadoraDataSet;
            // 
            // locadoraDataSet
            // 
            this.locadoraDataSet.DataSetName = "locadoraDataSet";
            this.locadoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // condutoresTableAdapter
            // 
            this.condutoresTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Listagem de Condutores";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1243, 576);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1267, 653);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "LocCar V.0.0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.condutoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locadoraDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locatáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem condutoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private locadoraDataSet locadoraDataSet;
        private System.Windows.Forms.BindingSource condutoresBindingSource;
        private locadoraDataSetTableAdapters.condutoresTableAdapter condutoresTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

