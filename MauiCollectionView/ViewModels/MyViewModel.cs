using System.Collections.ObjectModel;

namespace MauiCollectionView.ViewModels
{
    public class MyViewModel
    {
        public ObservableCollection<string> Items { get; } = ["1", "2", "3"];

        ~MyViewModel()
        {
            Console.WriteLine("~MyViewModel() called");
        }
    }
}
