using System.Windows;
using System.Windows.Controls;

namespace PRODUTO.FORM.View.Produtos
{
    public partial class CadastroProdutoUserControl : UserControl
    {
        public CadastroProdutoUserControl()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainContent.Content = new ProdutosUserControl();
            }
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            // Aqui você salva os dados (opcional)
            MessageBox.Show("Produto salvo com sucesso!");

            // Volta para a lista
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainContent.Content = new ProdutosUserControl();
            }
        }
    }
}
