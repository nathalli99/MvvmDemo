using MvvmDemo.Mvvm.Models;
using MvvmDemo.Mvvm.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;

namespace MvvmDemo.Mvvm.ViewModels
{
    public class ProdutoViewModel
    {
       public Produto Produto { get; set; }
       public ProdutoViewModel()
        {
            Produto = new Produto
            {
                Nome = "Caderno",
                Preco = 9.45m,
                Estoque = 33,
                Ativo = true,
                DataCompra = new DateTime(2023, 07, 03),
                Peso = 12.78d
            };
        }

    }
}
