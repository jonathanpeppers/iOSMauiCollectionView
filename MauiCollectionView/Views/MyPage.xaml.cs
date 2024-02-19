using MauiCollectionView.ViewModels;
using System.Diagnostics;

namespace MauiCollectionView.Views;

public partial class MyPage : ContentPage
{
	public MyPage(MyViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    ~MyPage()
    {
        Debug.WriteLine("~MyPage() called");
    }
}