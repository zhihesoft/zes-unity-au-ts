using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Au.TS
{
    /// <summary>
    /// Get types of JSWrap attribute
    /// </summary>
    public static class JSWrapper
    {
        public static IEnumerable<Type> Bind(params Type[] types)
        {
            List<Type> typesList = new List<Type>(types);

            var wrapTypes = from assembly in AppDomain.CurrentDomain.GetAssemblies()
                            where !(assembly.ManifestModule is System.Reflection.Emit.ModuleBuilder)
                            from type in assembly.GetTypes()
                            where type.IsDefined(typeof(JSWrapAttribute), false)
                            select type;
            typesList.AddRange(wrapTypes);
            return typesList;
        }

        public static bool Filter(MemberInfo mb)
        {
            if (mb.IsDefined(typeof(JSIgnoreAttribute), false))
            {
                // Debug.Log($"{mb} is ignore");
                return true;
            }
            return false;
        }
    }
}
