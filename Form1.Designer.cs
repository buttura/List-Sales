namespace VendasLista
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Produto = new System.Windows.Forms.RichTextBox();
            this.Quantidade = new System.Windows.Forms.RichTextBox();
            this.ValorUnitario = new System.Windows.Forms.RichTextBox();
            this.InserirProduto = new System.Windows.Forms.Button();
            this.TotalVendas = new System.Windows.Forms.Label();
            this.LimparProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ListaProdutosView = new System.Windows.Forms.ListView();
            this.ProdutoListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantidadeListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValorUnitarioListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Produto
            // 
            this.Produto.Location = new System.Drawing.Point(32, 52);
            this.Produto.Name = "Produto";
            this.Produto.Size = new System.Drawing.Size(151, 44);
            this.Produto.TabIndex = 0;
            this.Produto.Text = "";
            // 
            // Quantidade
            // 
            this.Quantidade.Location = new System.Drawing.Point(32, 115);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(151, 47);
            this.Quantidade.TabIndex = 1;
            this.Quantidade.Text = "";
            // 
            // ValorUnitario
            // 
            this.ValorUnitario.Location = new System.Drawing.Point(32, 182);
            this.ValorUnitario.Name = "ValorUnitario";
            this.ValorUnitario.Size = new System.Drawing.Size(151, 43);
            this.ValorUnitario.TabIndex = 2;
            this.ValorUnitario.Text = "";
            // 
            // InserirProduto
            // 
            this.InserirProduto.Location = new System.Drawing.Point(189, 52);
            this.InserirProduto.Name = "InserirProduto";
            this.InserirProduto.Size = new System.Drawing.Size(290, 173);
            this.InserirProduto.TabIndex = 3;
            this.InserirProduto.Text = "Inserir Produto";
            this.InserirProduto.UseVisualStyleBackColor = true;
            this.InserirProduto.Click += new System.EventHandler(this.InserirProduto_Click);
            // 
            // TotalVendas
            // 
            this.TotalVendas.AutoSize = true;
            this.TotalVendas.Font = new System.Drawing.Font("NSimSun", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalVendas.Location = new System.Drawing.Point(21, 589);
            this.TotalVendas.Name = "TotalVendas";
            this.TotalVendas.Size = new System.Drawing.Size(283, 64);
            this.TotalVendas.TabIndex = 5;
            this.TotalVendas.Text = "R$ 00,00";
            // 
            // LimparProduto
            // 
            this.LimparProduto.Location = new System.Drawing.Point(32, 467);
            this.LimparProduto.Name = "LimparProduto";
            this.LimparProduto.Size = new System.Drawing.Size(447, 105);
            this.LimparProduto.TabIndex = 6;
            this.LimparProduto.Text = "Limpar Produto";
            this.LimparProduto.UseVisualStyleBackColor = true;
            this.LimparProduto.Click += new System.EventHandler(this.LimparProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor Unitário";
            // 
            // ListaProdutosView
            // 
            this.ListaProdutosView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProdutoListView,
            this.QuantidadeListView,
            this.ValorUnitarioListView});
            this.ListaProdutosView.HideSelection = false;
            this.ListaProdutosView.Location = new System.Drawing.Point(32, 240);
            this.ListaProdutosView.Name = "ListaProdutosView";
            this.ListaProdutosView.Size = new System.Drawing.Size(447, 207);
            this.ListaProdutosView.TabIndex = 10;
            this.ListaProdutosView.UseCompatibleStateImageBehavior = false;
            this.ListaProdutosView.View = System.Windows.Forms.View.Details;
            // 
            // ProdutoListView
            // 
            this.ProdutoListView.Text = "Produto";
            this.ProdutoListView.Width = 167;
            // 
            // QuantidadeListView
            // 
            this.QuantidadeListView.Text = "Quantidade";
            this.QuantidadeListView.Width = 110;
            // 
            // ValorUnitarioListView
            // 
            this.ValorUnitarioListView.Text = "Valor Unitario";
            this.ValorUnitarioListView.Width = 166;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 693);
            this.Controls.Add(this.ListaProdutosView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LimparProduto);
            this.Controls.Add(this.TotalVendas);
            this.Controls.Add(this.InserirProduto);
            this.Controls.Add(this.ValorUnitario);
            this.Controls.Add(this.Quantidade);
            this.Controls.Add(this.Produto);
            this.Name = "Form1";
            this.Text = "Lista de Vendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Produto;
        private System.Windows.Forms.RichTextBox Quantidade;
        private System.Windows.Forms.RichTextBox ValorUnitario;
        private System.Windows.Forms.Button InserirProduto;
        private System.Windows.Forms.Label TotalVendas;
        private System.Windows.Forms.Button LimparProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView ListaProdutosView;
        private System.Windows.Forms.ColumnHeader ProdutoListView;
        private System.Windows.Forms.ColumnHeader QuantidadeListView;
        private System.Windows.Forms.ColumnHeader ValorUnitarioListView;
    }
}

