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

        public void Run(string scriptOrPath, Action<JsEnv> initAction = null)
        {
            this.initAction = initAction;
            Restart(scriptOrPath);
        }

        public void Restart(string scriptOrPath)
        {
            env?.Dispose();
            CreateLoader().Init(scriptOrPath);
            env = new JsEnv(loader);
            initAction?.Invoke(env);
        }

        public T Eval<T>(string script)
        {
            // return env.Eval<T>($"var m = require('{scriptEntry}'); m.i18n");
            return env.Eval<T>($"{script}");
        }

        public void Eval(string script)
        {
            env.Eval($"{script}");
        }

        private void Update()
        {
            env?.Tick();
        }

        private JSLoader CreateLoader()
        {
            if (loader != null)
            {
                loader.Dispose();
            }

            loader =
#if UNITY_EDITOR
                new JSLoaderEditor();
#else   
                new JSLoaderRuntime();
#endif
            return loader;
        }
    }
}
