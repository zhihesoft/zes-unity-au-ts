using Au.TS;
using Puerts;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

[Configure]
public class TestConfig
{
    [Binding]
    public static IEnumerable<Type> Bindings
    {
        get
        {
            return JSWrapper.Bind(
                typeof(GameObject),
                typeof(MonoBehaviour)
                );
        }
    }

    [Filter]
    public static bool Filter(MemberInfo mb)
    {
        return JSWrapper.Filter(mb);
    }
}
