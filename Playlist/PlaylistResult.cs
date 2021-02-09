using System.Collections.Generic;

namespace Couchpotato.Core.Playlist
{
    public class PlaylistResult
    {
        public PlaylistResult()
        {
            Items = new List<PlaylistItem>();
            Missing = new List<PlaylistItem>();
        }

        public List<PlaylistItem> Items { get;set;}
        public List<PlaylistItem> Missing { get;set;}
    }
}
