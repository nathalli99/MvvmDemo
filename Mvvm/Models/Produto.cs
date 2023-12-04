using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;

namespace MvvmDemo.Mvvm.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCompra { get; set; }
        public double Peso { get; set; }
    }
}
