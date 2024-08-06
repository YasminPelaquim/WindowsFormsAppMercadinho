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



        private void btnInserir_Click(object sender, EventArgs e)
        {
            string produto = txtProduto.Text;
            double quantidade = double.Parse(txtQtde.Text);
            double valoruni = double.Parse(txtValor.Text);

            ListBox lista = lstProdutos;
            lista.Items.Add(produto + "/" + quantidade + "/" + valoruni);
        }
    }
}
