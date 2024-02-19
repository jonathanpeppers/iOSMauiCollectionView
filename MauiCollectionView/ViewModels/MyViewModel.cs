using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MauiCollectionView.ViewModels
{
    public class MyViewModel
    {
        public ObservableCollection<string> Items { get; } = ["1", "2", "3"];

        ~MyViewModel()
        {
            Debug.WriteLine("~MyViewModel() called");
        }
    }
}
