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

        app = new TSApp((env) =>
        {
            env.UsingFunc<int, string>();
        });
        var script = File.ReadAllText("./Typescripts/out/main.bytes");
        app.Run(script, "./Typescripts/out/main.bytes");
        //var script = "./Typescripts/dist/index.js";
        var fun = app.Func<Func<int, string>>("i18n");
        var str = fun(1024);

        Debug.Log(str);
    }

    private void Update()
    {
        app.Tick();
    }
}
