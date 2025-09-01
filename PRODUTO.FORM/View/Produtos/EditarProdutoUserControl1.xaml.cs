using System.Windows;
using System.Windows.Controls;

namespace PRODUTO.FORM.View.Produtos
{
    public partial class EditarProdutoUserControl1 : UserControl
    {
        public EditarProdutoUserControl1()
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
            // Lógica para salvar as alterações do produto
            MessageBox.Show("Produto atualizado com sucesso!");

            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainContent.Content = new ProdutosUserControl();
            }
        }
    }
}
