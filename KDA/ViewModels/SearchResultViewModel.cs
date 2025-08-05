using KDA.Models;
using System.Collections.Generic;

namespace KDA.ViewModels
{
    public class SearchResultViewModel
    {
        // 사용자 프로필 정보
        public UserProfile UserProfileInfo { get; set; }

        // 선호 포지션 정보
        public List<PositionStats> PreferredPositions { get; set; }

        public SearchResultViewModel()
        {
            UserProfileInfo = new UserProfile
            {
                IconPath = "/Resources/UserIcons/profileiconplaceholder.png",
                UserName = "사과아아",
                UserTag = "#KR1",
                FlagIconPath = "/Resources/FlagIcons/kr_flag.png",
                RankInfo = "KR | 래더 랭킹 418,634위",
                Tier = "Platinum 1",
                Lp = 36,
                WinLossRecord = "163승 150패",
                WinRate = 56,
                LastUpdated = "최근 업데이트: 1분 전"
            };

            PreferredPositions = new List<PositionStats>
            {
                new PositionStats { IconPath = "/Resources/PositionIcons/top.png", PlayRate = 30 },
                new PositionStats { IconPath = "/Resources/PositionIcons/jungle.png", PlayRate = 60 },
                new PositionStats { IconPath = "/Resources/PositionIcons/mid.png", PlayRate = 25 },
                new PositionStats { IconPath = "/Resources/PositionIcons/ad.png", PlayRate = 85 },
                new PositionStats { IconPath = "/Resources/PositionIcons/support.png", PlayRate = 10 }
            };
        }
    }
}