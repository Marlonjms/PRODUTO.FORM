using System.Windows;
using System.Windows.Controls;

namespace PRODUTO.FORM.View.Pessoas
{
    public partial class PessoasUserControl : UserControl
    {
        public PessoasUserControl()
        {
            InitializeComponent();
        }

        private void BtnIncluir_Click(object sender, RoutedEventArgs e)
        {
            // Pega a janela principal e chama o método de navegação
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.NavigateToCadastroPessoa();
            }
        }
    }
}
