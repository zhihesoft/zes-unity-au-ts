using Au.TS;
using NUnit.Framework;
using System;
using System.IO;
using UnityEngine.TestTools;

public class TestSuite : IPrebuildSetup, IPostBuildCleanup
{

    [Test]
    public void ForFile()
    {
        TSApp app = new TSApp("Typescripts/dist/index.js");
        app.Run();
        var func = app.GetFunc<Func<int, string>>("i18n");
        var ret = func(1024);
        Assert.AreEqual(ret, $"id is 1024");
        app.Dispose();
    }

    [Test]
    public void ForChunk()
    {
        var script = File.ReadAllText("Typescripts/out/main.bytes");
        TSApp app = new TSApp(script);
        app.Run();
        var func = app.GetFunc<Func<int, string>>("i18n");
        var ret = func(1024);
        Assert.AreEqual(ret, $"id is 1024");
        app.Dispose();
    }

    public void Cleanup()
    {
    }

    public void Setup()
    {
    }
}
