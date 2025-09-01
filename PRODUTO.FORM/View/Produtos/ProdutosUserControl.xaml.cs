using System.Windows;
using System.Windows.Controls;

namespace PRODUTO.FORM.View.Produtos
{
    public partial class ProdutosUserControl : UserControl
    {
        public ProdutosUserControl()
        {
            InitializeComponent();
        }

        private void BtnIncluir_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainContent.Content = new CadastroProdutoUserControl();
            }
        }
    }
}
