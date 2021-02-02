using System.Xml.Serialization;

namespace Couchpotato.Core.Epg
{
    public class EpgResult{

        public EpgResult()
        {
            StreamsWithoutEpg = new List<String>();
        }

        public EpgList Epg {get;set;}
        public List<String> StreamsWithoutEpg {get;set;} 
    }
}
