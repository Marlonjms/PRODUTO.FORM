using System.Collections.Generic;
using System.Windows.Controls;

namespace PRODUTO.FORM.View.Pedidos
{
    public partial class PedidosUserControl : UserControl
    {
        public PedidosUserControl()
        {
            InitializeComponent();

            // Lista de produtos de exemplo
            var produtosExemplo = new List<ProdutoPedido>
            {
                new ProdutoPedido { Codigo = "001", Descricao = "Arroz 5kg", Quantidade = 1, PrecoUnitario = 25.50m },
                new ProdutoPedido { Codigo = "002", Descricao = "Feijão 1kg", Quantidade = 2, PrecoUnitario = 8.75m },
                new ProdutoPedido { Codigo = "003", Descricao = "Óleo 900ml", Quantidade = 1, PrecoUnitario = 7.90m }
            };

            dgProdutos.ItemsSource = produtosExemplo;
        }
    }

    public class ProdutoPedido
    {
        public bool IsSelected { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Subtotal => Quantidade * PrecoUnitario;
    }

}
