﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tryy
{
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            UCcreate frm = new UCcreate();
            panel4.Controls.Clear();
            panel4.Controls.Add(frm);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            UCSearch frm = new UCSearch();
            panel4.Controls.Clear();
            panel4.Controls.Add(frm);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbledit_Click(object sender, EventArgs e)
        {
            UCEdit frm=new UCEdit();
            panel4.Controls.Clear();
            panel4.Controls.Add(frm);
        }
    }
}
