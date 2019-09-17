using System;

namespace Couchpotato.Core.Plugins
{
    [AttributeUsage(AttributeTargets.Class)]
    public class RequireSettingsAttribute: Attribute{

        public RequireSettingsAttribute(){
            
        }
    }
}