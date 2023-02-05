using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendasLista
{
    public partial class Form1 : Form
    {
        double t = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void InserirProduto_Click(object sender, EventArgs e)
        {
            t += double.Parse(ValorUnitario.Text) * double.Parse(Quantidade.Text);
            TotalVendas.Text = t.ToString("C");
            ListViewItem l = new ListViewItem();
            ListaProdutosView.Items.Add(l);
        }

        private void LimparProduto_Click(object sender, EventArgs e)
        {
            Produto.Text = Quantidade.Text = ValorUnitario.Text = "";

        }
    }
}
