using KDA.Models;
using System.Collections.Generic;

namespace KDA.ViewModels
{
    public class SearchResultViewModel
    {
        public UserProfile UserProfileInfo { get; set; }

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
                WinLossRecord = "63승 50패",
                WinRate = 56,
                LastUpdated = "최근 업데이트: 1분 전"
            };
        }
    }
}