using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using ProdutoTeste = PRODUTO.FORM.View.Produtos.Produtos;


namespace PRODUTO.FORM.View.Produtos
{
    public partial class ProdutosUserControl : UserControl
    {
        public ProdutosUserControl()
        {
            InitializeComponent();

            // Dados de teste
            var produtos = new List<Produtos>
            {
                new Produtos { Id = 1, Codigo = "P001", Nome = "Produto A", Valor = 50.0m },
                new Produtos { Id = 2, Codigo = "P002", Nome = "Produto B", Valor = 75.0m },
                new Produtos { Id = 3, Codigo = "P003", Nome = "Produto C", Valor = 120.0m },
            };
            dgProdutos.ItemsSource = produtos;
        }

        private void BtnIncluir_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainContent.Content = new CadastroProdutoUserControl();
            }
        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (dgProdutos.SelectedItem != null)
            {
                var produtoSelecionado = dgProdutos.SelectedItem;
                if (Application.Current.MainWindow is MainWindow mainWindow)
                {
                    var editarProduto = new EditarProdutoUserControl1();
                    mainWindow.MainContent.Content = editarProduto;
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para editar!");
            }
        }
    }

    public class Produtos
    {
        public bool IsSelected { get; set; }
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}
