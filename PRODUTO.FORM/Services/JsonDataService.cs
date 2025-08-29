
using Newtonsoft.Json;
using PRODUTO.FORM.Contracts;
using PRODUTO.FORM.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRODUTO.FORM.Services
{
    public class JsonDataService : IDataService
    {
        private readonly string _caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "produtos.json");
        public List<Produto> CarregarProdutos()
        {
            if (!File.Exists(_caminhoArquivo)) return new List<Produto>();

            var json = File.ReadAllText(_caminhoArquivo);
            return JsonConvert.DeserializeObject<List<Produto>>(json);
        }
        public void SalvarProdutos(List<Produto> produtos)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(_caminhoArquivo));
            var json = JsonConvert.SerializeObject(produtos, Formatting.Indented);
            File.WriteAllText(_caminhoArquivo, json);
        }
    }
}
