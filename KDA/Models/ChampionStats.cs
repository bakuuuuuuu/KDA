// 모스트 챔피언 더미 데이터

namespace KDA.Models
{
    public class ChampionStats
    {
        public string ChampIconPath { get; set; } = "/Resources/ChampIcons/Yasuo.png";
        public string ChampName { get; set; } = "야스오";
        public string ChampCS { get; set; } = "CS 231 (7.2)";

        // 평점
        public double KdaValue { get; set; } = 3.5;
        public string KdaScore => $"{KdaValue:F2}:1 평점"; 

        public string KdaDetail { get; set; } = "6.6 / 6.3 / 7.2";

        // 승률
        public int WinRateValue { get; set; } = 51;
        public string WinRate => $"{WinRateValue}%";

        public string GameCount { get; set; } = "11 게임";
    }
}