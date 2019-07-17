using CouchpotatoShared.Channel;
using CouchpotatoShared.Epg;

namespace CouchpotatoShared.Plugins{
    public interface IPlugin
    {
        void Run(ChannelResult channelResult = null, EpgList epgList = null);
    }
}