using System.Windows;
using System.Windows.Controls;

namespace PRODUTO.FORM.View.Pessoas
{
    public partial class CadastroPessoaUserControl : UserControl
    {
        public CadastroPessoaUserControl()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainContent.Content = new PessoasUserControl();
            }
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            // Aqui você salva os dados (opcional)
            MessageBox.Show("Pessoa salva com sucesso!");

            // Volta para a lista
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainContent.Content = new PessoasUserControl();
            }
        }
    }
}
