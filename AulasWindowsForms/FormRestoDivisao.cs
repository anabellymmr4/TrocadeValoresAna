﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulasWindowsForms
{
    public partial class FormRestoDivisao : Form
    {
        public FormRestoDivisao()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRestodaDivisao_Click(object sender, EventArgs e)
        {
            try
            {
                int dividendo = Convert.ToInt32(txtDividendo.Text);
                int divisor = Convert.ToInt32(txtDivisor.Text);
                int resto = dividendo % divisor;
                txtResto.Text = resto.ToString();
            }
            catch(FormatException )
            {
                MessageBox.Show("Entrada de dado inalida" , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException exc)
            {
                MessageBox.Show("Nao é possivel realiazar divisao por zero", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
