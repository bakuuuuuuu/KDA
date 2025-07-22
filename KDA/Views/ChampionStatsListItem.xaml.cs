using System.Windows.Controls;
using KDA.Models;


namespace KDA
{
    /// <summary>
    /// ChampionStatsListItem.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ChampionStatsListItem : UserControl
    {
        public ChampionStatsListItem()
        {
            InitializeComponent();
            this.DataContext = new ChampionStats();
        }
    }
}
