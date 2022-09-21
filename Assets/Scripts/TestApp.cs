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

        app = new TSApp();
        var script = File.ReadAllText("./Typescripts/out/main.bytes");
        app.Run("./Typescripts/dist/index.js");
        //app.Run(script);
        //var script = "./Typescripts/dist/index.js";
        var fun = app.Func<Action>("testFunc");
        fun();
    }

    private void Update()
    {
        app.Tick();
    }
}
