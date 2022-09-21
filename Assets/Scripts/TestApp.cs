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

        var script = File.ReadAllText("./Typescripts/out/main.bytes");
        app = new TSApp("./Typescripts/dist/index.js");
        app.Run();
        //app.Run(script);
        //var script = "./Typescripts/dist/index.js";
        var fun = app.GetFunc<Action>("testFunc");
        fun();
    }

    private void Update()
    {
        app.Tick();
    }
}
