using System.Collections.ObjectModel;

namespace MauiCollectionView.Views;

public partial class PageXamlLeak : ContentPage
{
    public PageXamlLeak()
    {
        InitializeComponent();

        var collectionView = (CollectionView)Content;
        collectionView.ItemsSource = new ObservableCollection<string> { "1", "2", "3" };
    }

    ~PageXamlLeak()
    {
        Console.WriteLine("~PageXamlLeak() called");
    }
}