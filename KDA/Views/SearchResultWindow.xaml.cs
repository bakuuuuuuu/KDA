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
    }
}