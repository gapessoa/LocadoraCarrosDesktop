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
    public partial class About : Form
    {

        Form1 form1;

        public About()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/gapessoa/LocadoraCarrosDesktop");
        }

        private void cmdAction_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
