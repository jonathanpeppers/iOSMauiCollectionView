using MauiCollectionView.ViewModels;

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
        Console.WriteLine("~MyPage() called");
    }
}