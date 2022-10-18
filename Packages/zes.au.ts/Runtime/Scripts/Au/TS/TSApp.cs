using Puerts;
using System;
using UnityEngine.Assertions;

namespace Au.TS
{
    /// <summary>
    /// A TS App
    /// </summary>
    [JSWrap]
    public class TSApp : IDisposable
    {
        /// <summary>
        /// Create a new TSApp instance
        /// </summary>
        /// <param name="script">script file or source chunk</param>
        public TSApp(string script)
            : this(new StartupInfo { script = script })
        { }

        /// <summary>
        /// Create a new TSApp instance
        /// </summary>
        /// <param name="startupInfo">startup info</param>
        public TSApp(StartupInfo startupInfo)
        {
            Assert.IsNotNull(startupInfo);
            this.startupInfo = startupInfo;
            rootFile = startupInfo.IsScriptFile() ? startupInfo.script : "__root__";
        }

        private readonly StartupInfo startupInfo;
        private JSLoader jsLoader;
        private JsEnv env;
        private string rootFile = "";

        public void Run()
        {
            Assert.IsNull(env);
            if (startupInfo.IsScriptFile())
            {
                jsLoader = new JSLoader(string.Empty);
            }
            else
            {
                jsLoader = new JSLoader(startupInfo.script);
            }
            env = new JsEnv(jsLoader, startupInfo.debugPort);
            Puerts.ThirdParty.CommonJS.InjectSupportForCJS(env);
            //await env.WaitDebuggerAsync();
            CommonInit(env);
            startupInfo.initActions?.Invoke(env);
            env.Eval($"require('{rootFile}');");
        }

        public void Restart()
        {
            Dispose();
            Run();
        }

        public void Dispose()
        {
            env?.Dispose();
            env = null;
        }

        public T GetFunc<T>(string func)
        {
            return env.Eval<T>($"var m = require('{rootFile}'); m.{func};");
        }

        public void Tick()
        {
            env?.Tick();
        }

        private void CommonInit(JsEnv env)
        {
            env.UsingAction<bool>();
            env.UsingAction<float>();
            env.UsingAction<string>();
            env.UsingAction<string, string>();
            env.UsingFunc<string, string>();
            env.UsingFunc<int, string>();
        }
    }
}
