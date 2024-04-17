using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiCollectionView.Views;

public partial class PageXamlLeak : ContentPage
{
    public PageXamlLeak()
    {
        InitializeComponent();

        var collectionView = (CollectionView)Content;
        collectionView.ItemsSource = new MyModel[]
        {
            "1", "2", "3"
        };
    }

    ~PageXamlLeak()
    {
        Console.WriteLine("~PageXamlLeak() called");
    }
}

class MyModel
{
    public static implicit operator MyModel(string value) => new() { Name = value };

    public string Name { get; set; } = "";

    public ICommand Command { get; set; } = new Command(() => Console.WriteLine("Tapped!"));
}