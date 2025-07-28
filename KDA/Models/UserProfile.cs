namespace KDA.Models
{
    public class UserProfile
    {
        public string? IconPath { get; set; } 
        public string? UserName { get; set; }
        public string? UserTag { get; set; }
        public string? FlagIconPath { get; set; } 
        public string? RankInfo { get; set; } 
        public string? Tier { get; set; } 
        public int Lp { get; set; } 
        public string? WinLossRecord { get; set; }
        public int WinRate { get; set; }
        public string? LastUpdated { get; set; } 
    }
}