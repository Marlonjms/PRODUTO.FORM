using PRODUTO.FORM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRODUTO.FORM.ViewModels
{
    public class MainViewModel
    {
        private readonly JsonDataService _dataService;
        public MainViewModel(JsonDataService dataService)
        {
            _dataService = dataService;
        }
    }
}
