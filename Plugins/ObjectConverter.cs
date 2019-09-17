using System;
using System.Collections.Generic;

namespace  Couchpotato.Core.Plugins{
    public static class ObjectConverter{
        public static bool HasProperty(this Type obj, string propertyName)
        {
            return obj.GetProperty(propertyName) != null;
        }

        public static T ToObject<T>(this Dictionary<string, object> source) where T: class, new(){
            if(source == null){
                return null;
            }

            var settingsClass = new T();
            var settingsClassType = settingsClass.GetType();

            foreach(var item in source){
                if(!settingsClassType.HasProperty(item.Key)){
                    continue;
                }

                var settingClassProperty = settingsClassType.GetProperty(item.Key);
                var settingClassPropertyType = settingClassProperty.PropertyType;
              
                settingClassProperty.SetValue(settingsClass, Convert.ChangeType(item.Value, settingClassPropertyType), null);
               
            }

            return settingsClass;
        }
    }
}