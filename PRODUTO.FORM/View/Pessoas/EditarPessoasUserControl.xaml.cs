using System.Windows;
using System.Windows.Controls;

namespace PRODUTO.FORM.View.Pessoas
{
    public partial class EditarPessoasUserControl : UserControl
    {
        public EditarPessoasUserControl()
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

        private void BtnSalvarEditar_Click(object sender, RoutedEventArgs e)
        {
            // Aqui você pode colocar a lógica para salvar os dados editados
            MessageBox.Show("Pessoa atualizada com sucesso!");

            // Após salvar, volta para a lista
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainContent.Content = new PessoasUserControl();
            }
        }
    }
}
