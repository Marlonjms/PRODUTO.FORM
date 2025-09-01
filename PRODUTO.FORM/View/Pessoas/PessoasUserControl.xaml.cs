using System.Collections.Generic;
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
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.NavigateToCadastroPessoa();
            }
        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainContent.Content = new EditarPessoasUserControl();
            }
        }
    }

}
