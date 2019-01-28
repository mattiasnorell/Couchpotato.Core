using CouchpotatoShared.Channel;

namespace CouchpotatoShared.Plugins{
    public interface IPlugin
    {
        void Run(ChannelResult channelResult = null);
    }
}