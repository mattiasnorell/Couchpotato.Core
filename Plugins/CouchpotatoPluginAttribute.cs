using System;

namespace Couchpotato.Core.Plugins
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CouchpotatoPluginAttribute: Attribute{

        private PluginType eventName { get; set;} 
        private int priority { get; set;} 
        public CouchpotatoPluginAttribute(PluginType eventName, int priority = 10){
            this.eventName = eventName;
            this.priority = priority;
        }

        public virtual PluginType EventName {
            get { return this.eventName; }
        }

        public virtual int Priority{
            get { return this.priority; }
        }
    }
}