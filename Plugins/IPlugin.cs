using Couchpotato.Core.Playlist;
using Couchpotato.Core.Epg;
using System.Collections.Generic;

namespace Couchpotato.Core.Plugins{
    public interface IPlugin
    {
        void Run(PlaylistResult playlist = null, EpgResult epg = null);
    }
}