namespace Couchpotato.Core.Playlist
{
    public class PlaylistItem
    {
        public PlaylistItem()
        {
            IsValid = true;
        }

        public string TvgId { get; set; }
        public string TvgName { get; set; }
        public string TvgLogo { get; set; }
        public string GroupTitle { get; set; }
        public string FriendlyName { get; set; }
        public string Url { get; set; }
        public int Order { get; set; }
        public bool IsValid { get; set; }
        public bool HasCustomLogo { get; set; }
    }
}
