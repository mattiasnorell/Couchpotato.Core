using System;

namespace Couchpotato.Core.Plugins
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CouchpotatoPluginAttribute: Attribute{

        private PluginType eventName { get; set;} 
        public CouchpotatoPluginAttribute(PluginType eventName){
            this.eventName = eventName;
        }

        public virtual PluginType EventName {
            get { return this.eventName; }
        }
    }
}