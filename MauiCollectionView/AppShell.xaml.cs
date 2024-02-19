using MauiCollectionView.Views;

namespace MauiCollectionView
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MyPage), typeof(MyPage));
        }
    }
}
