﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja_UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void administracijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users.IndexForm frm = new Users.IndexForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void noviKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users.AddForm frm = new Users.AddForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void noviProizvodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products.AddForm frm = new Products.AddForm();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
