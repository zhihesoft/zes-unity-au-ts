using Au.TS;
using System;
using System.IO;
using UnityEngine;

public class TestApp : MonoBehaviour
{
    TSApp app;
    private void Start()
    {
        DontDestroyOnLoad(gameObject);

        app = gameObject.AddComponent<TSApp>();
        var script = File.ReadAllText("./Typescripts/out/main.bytes");
        //var script = "./Typescripts/dist/index.js";
        app.Run(script, (env) =>
        {
            env.UsingFunc<int, string>();
        });
        var fun = app.Eval<Func<int, string>>("./Typescripts/dist/index.js", "i18n");
        var str = fun(1024);

        Debug.Log(str);
    }
}
