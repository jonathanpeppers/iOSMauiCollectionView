using System.Collections.ObjectModel;

namespace MauiCollectionView.Views;

public partial class PageXamlLeak : ContentPage
{
    public PageXamlLeak()
    {
        InitializeComponent();

        MyCollectionView.ItemsSource = new ObservableCollection<string> { "1", "2", "3" };
    }

    ~PageXamlLeak()
    {
        Logger.Log("~PageXamlLeak() called");
    }
}