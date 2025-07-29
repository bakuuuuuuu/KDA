using System.Windows;
using KDA.ViewModels;

namespace KDA.Views
{
    public partial class SearchResultWindow : Window
    {
        public SearchResultWindow()
        {
            InitializeComponent();
            DataContext = new SearchResultViewModel();
        }

        private void MostChampionControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void UserProfileCard_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}