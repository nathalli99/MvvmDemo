using MvvmDemo.Mvvm.Models;
using MvvmDemo.Mvvm.ViewModels;
using System.Globalization;


namespace MvvmDemo.Mvvm.Views;

public partial class ProdutoView : ContentPage
{
	public ProdutoView()
	{
		InitializeComponent();

        BindingContext = new ProdutoViewModel(); //propriedade que permite que a View acesse os dados definidos no Models 
    }
}
