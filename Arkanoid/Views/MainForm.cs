﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkanoid.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(UserControl uc)
        {
            InitializeComponent();
            uc.Height = Height;
            uc.Width = Width;
            this.Controls.Add(uc);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
