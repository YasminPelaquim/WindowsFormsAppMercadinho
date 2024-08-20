using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMercadinho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total;

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string produto = txtProduto.Text;
            int quantidade = int.Parse(txtQtde.Text);
            double valoruni = double.Parse(txtValor.Text);

            ListBox lista = lstProdutos;
            lista.Items.Add(produto + "/" + quantidade + "/" + valoruni);

            total += valoruni * quantidade;

            
            lblTotal.Text = total.ToString();

            txtProduto.Clear();
            txtQtde.Clear();
            txtValor.Clear();
            txtProduto.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            total = 0;
            lblTotal.Text = total.ToString();

            txtProduto.Clear();
            txtQtde.Clear();
            txtValor.Clear();

            lstProdutos.Items.Clear();

            txtProduto.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
