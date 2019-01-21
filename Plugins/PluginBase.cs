using System.Collections.Generic;

namespace  CouchpotatoShared.Plugins{

    public class PluginBase<T> where T: class, new(){
        
        public T Settings {get;set;}
        
        public PluginBase(Dictionary<string, object> args) {
            this.Settings = args.ToObject<T>();
        }
    }
}