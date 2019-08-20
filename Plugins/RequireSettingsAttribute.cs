using System;

namespace CouchpotatoShared.Plugins
{
    [AttributeUsage(AttributeTargets.Class)]
    public class RequireSettingsAttribute: Attribute{

        public RequireSettingsAttribute(){
            
        }
    }
}