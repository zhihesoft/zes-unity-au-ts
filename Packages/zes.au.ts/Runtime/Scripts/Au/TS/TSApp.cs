using Puerts;
using System;
using UnityEngine;

namespace Au.TS
{
    public class TSApp : MonoBehaviour
    {
        private JSLoader loader;
        private JsEnv env;
        private Action<JsEnv> initAction;
        private string entryFile = "main.bytes";

        public void Run(string scriptOrPath, Action<JsEnv> initAction = null)
        {
            this.initAction = initAction;
            Restart(scriptOrPath);
        }

        public void Restart(string scriptOrPath)
        {
            bool fileMode = scriptOrPath.StartsWith(".");
            env?.Dispose();
            CreateLoader(fileMode).Init(scriptOrPath);
            env = new JsEnv(loader);
            initAction?.Invoke(env);

            if (fileMode)
            {
                Eval(scriptOrPath);
            }
            else
            {
                Eval(entryFile);
            }

        }

        public T Eval<T>(string script, string func)
        {
            return env.Eval<T>($"var m = require('{script}'); m.{func};");
        }

        public void Eval(string script)
        {
            env.Eval($"require('{script}');");
            // env.ExecuteModule(script);
        }

        private void Update()
        {
            env?.Tick();
        }

        private JSLoader CreateLoader(bool fileMode)
        {
            if (loader != null)
            {
                loader.Dispose();
            }

            loader = fileMode ? new JSLoaderEditor() : new JSLoaderRuntime();
            return loader;
        }
    }
}
