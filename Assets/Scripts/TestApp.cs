using Assets.Scripts;
using Au.TS;
using Puerts;
using System;
using UnityEngine;

public class TestApp : MonoBehaviour
{
    TSApp app;
    JsEnv env;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);

        var loader = new TestLoader();
        // env = new JsEnv(new DefaultLoader("Typescripts"));
        env = new JsEnv(new TestLoader());
        Puerts.ThirdParty.CommonJS.InjectSupportForCJS(env);
        env.UsingFunc<int, string>();
        var func = env.Eval<Func<int, string>>("var m = require('./Typescripts/dist/index.js'); m.i18n;");
        // var func = env.ExecuteModule<Func<int, string>>("./Typescripts/dist/index.mjs", "i18n");
        var test = func(100);
        Debug.Log(test);


        //// var script = File.ReadAllText("./Typescripts/out/main.bytes");
        //app = new TSApp("./Typescripts/dist/index.js");
        //app.Run();
        ////app.Run(script);
        ////var script = "./Typescripts/dist/index.js";
        //var fun = app.GetFunc<Action>("testFunc");
        //fun();
    }

    private void Update()
    {
        app?.Tick();
        env?.Tick();
    }
}
