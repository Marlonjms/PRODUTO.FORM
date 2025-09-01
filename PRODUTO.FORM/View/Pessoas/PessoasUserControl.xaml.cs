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

            // Dados de teste Pessoas
            var pessoas = new List<Pessoa>
            {
                new Pessoa { Id = 1, Nome = "José", Cpf = "123.456.789-00", Endereco = "Rua A, 123" },
             
            };
            dgPessoas.ItemsSource = pessoas;

            // Dados de teste Pedidos
            var pedidos = new List<Pedido>
            {
                new Pedido { DataVenda = "31/08/2025", ValorTotal = 150.50m, FormaPagamento = "Dinheiro", Status = "Pago" },
                new Pedido { DataVenda = "30/08/2025", ValorTotal = 200.00m, FormaPagamento = "Cartão", Status = "Pendente" },
                new Pedido { DataVenda = "29/08/2025", ValorTotal = 75.30m, FormaPagamento = "Pix", Status = "Enviado" }
            };
            dgPedidos.ItemsSource = pedidos;
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

    public class Pessoa
    {
        public bool IsSelected { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
    }

    public class Pedido
    {
        public bool IsSelected { get; set; }
        public string DataVenda { get; set; }
        public decimal ValorTotal { get; set; }
        public string FormaPagamento { get; set; }
        public string Status { get; set; }
    }
}
