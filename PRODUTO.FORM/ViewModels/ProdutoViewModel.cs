using PRODUTO.FORM.Contracts;
using PRODUTO.FORM.DesignTime;
using PRODUTO.FORM.Models;
using PRODUTO.FORM.Services;
using PRODUTO.FORM.View.Produtos; // Adicione esta using para DesignerProperties
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PRODUTO.FORM.ViewModels
{
    public class ProdutoViewModel : INotifyPropertyChanged
    {
        private readonly IDataService _dataService;
        private ObservableCollection<Produto> _produtos;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand NovoProdutoCommand { get; }
        public ICommand SalvarProdutoCommand { get; }

        public ObservableCollection<Produto> Produtos
        {
            get => _produtos;
            set
            {
                _produtos = value;
                OnPropertyChanged(nameof(Produtos));
                OnPropertyChanged(nameof(TotalProdutos));
                OnPropertyChanged(nameof(ValorTotalEstoque));
            }
        }

        public int TotalProdutos => Produtos?.Count ?? 0;

        public decimal ValorTotalEstoque
        {
            get
            {
                if (Produtos == null) return 0;
                return Produtos.Sum(p => p.Preco * p.Estoque);
            }
        }

        public ProdutoViewModel(IDataService dataService)
        {
            _dataService = dataService;
            NovoProdutoCommand = new RelayCommand(AbrirCadastroProduto);
            SalvarProdutoCommand = new RelayCommand(SalvarProdutos);

            // Carrega dados apropriados dependendo do contexto
            if (IsInDesignMode())
            {
                CarregarDadosDesignTime();
            }
            else
            {
                CarregarProdutos();
            }
        }

        // Construtor sem parâmetros para design-time
        public ProdutoViewModel() : this(new DesignTimeDataService())
        {
        }

        private bool IsInDesignMode()
        {
            return DesignerProperties.GetIsInDesignMode(new DependencyObject());
        }

        private void CarregarDadosDesignTime()
        {
            // Dados de exemplo para design-time
            Produtos = new ObservableCollection<Produto>
            {
                new Produto
                {
                    Id = 1,
                    Nome = "Produto Exemplo 1",
                    Preco = 29.90m,
                    Estoque = 10,
                    Descricao = "Descrição do produto exemplo 1"
                },
                new Produto
                {
                    Id = 2,
                    Nome = "Produto Exemplo 2",
                    Preco = 59.90m,
                    Estoque = 5,
                    Descricao = "Descrição do produto exemplo 2"
                },
                new Produto
                {
                    Id = 3,
                    Nome = "Produto Exemplo 3",
                    Preco = 99.90m,
                    Estoque = 2,
                    Descricao = "Descrição do produto exemplo 3"
                }
            };
        }

        private void AbrirCadastroProduto()
        {
            var mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (mainWindow != null)
            {
   
                var contentControl = mainWindow.FindName("MainContent") as ContentControl;
                if (contentControl != null)
                {
                    contentControl.Content = new CadastroProdutoUserControl();
                    return;
                }

                MessageBox.Show("Controle de navegação não encontrado");
            }
        }
        private void SalvarProdutos()
        {
            if (Produtos != null)
            {
                var produtos = Produtos.ToList();
                _dataService.SalvarProdutos(produtos);
            }
        }

        private void CarregarProdutos()
        {
            if (_dataService != null)
            {
                Produtos = new ObservableCollection<Produto>(_dataService.CarregarProdutos());
            }
        }

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    
}