﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetMaxPitagoras.Foundation
{
    public partial class EstoqueForm : Form
    {
        public EstoqueForm()
        {
            InitializeComponent();
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void btnSairPesquisaEstoque_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCodProduto.Clear();
            txtNomeProd.Clear();
            comboBoxCategProd.ResetText();
            txtModeloProd.Clear();
            txtMarcaProduto.Clear();
            txtFornecProd.Clear();
            txtValorPagoProd.Clear();
            txtEstoqueMinProd.Clear();
            txtQtdProdCadastrar.Clear();
            txtEstoqueMaxProd.Clear();
        }
    }
}