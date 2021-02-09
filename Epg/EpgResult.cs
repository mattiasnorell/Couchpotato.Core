using System.Xml.Serialization;
using System.Collections.Generic;

namespace Couchpotato.Core.Epg
{
    public class EpgResult{

        public EpgResult()
        {
            StreamsWithoutEpg = new List<string>();
        }

        public EpgList Epg {get;set;}
        public List<string> StreamsWithoutEpg {get;set;} 
    }
}
