using System;
using UnityEngine;

namespace Au.TS
{
    [JSWrap]
    public static class GameObjectExtension
    {
        /// <summary>
        /// if a game object is null
        /// </summary>
        /// <param name="go"></param>
        /// <returns></returns>
        public static bool IsNull(this GameObject go)
        {
            return go == null;
        }

        /// <summary>
        /// Get or add a component to object
        /// </summary>
        /// <param name="go"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Component GetOrAddComponent(this GameObject go, Type type)
        {
            var ret = go.GetComponent(type);
            if (ret == null)
            {
                ret = go.AddComponent(type);
            }
            return ret;
        }
    }
}
