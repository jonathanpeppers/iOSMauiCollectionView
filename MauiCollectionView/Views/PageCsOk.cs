using System.Collections.ObjectModel;

namespace MauiCollectionView.Views;

public class PageCsOk : ContentPage
{
	public PageCsOk()
	{
        var collectionView = new CollectionView();
        collectionView.ItemsSource = new ObservableCollection<string> { "1", "2", "3" };

        collectionView.ItemTemplate = new DataTemplate(InstanceMethod);

        Content = collectionView;
    }

    object InstanceMethod()
    {
        var label = new Label
        {
            Text = "Test"
        };
        return label;
    }

    ~PageCsOk()
    {
        Console.WriteLine("~PageCsOk() called");
    }
}