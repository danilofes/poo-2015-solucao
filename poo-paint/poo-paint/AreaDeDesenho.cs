﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poo_paint
{
    public partial class AreaDeDesenho : Form
    {
        public AreaDeDesenho()
        {
            InitializeComponent();
        }

        private void Desenha(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, 34, 67, 89, 78);
            g.DrawEllipse(Pens.Black, 67, 89, 131, 131);
        }
    }
}
