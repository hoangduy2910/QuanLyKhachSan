﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmKhachSan : Form
    {
        public frmKhachSan()
        {
            InitializeComponent();
        }

        private void frmKhachSan_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Enabled = false;
            Login frmLogin = new Login();
            DialogResult result = frmLogin.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Enabled = true;
                label1.Text = "Hello Word";
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
