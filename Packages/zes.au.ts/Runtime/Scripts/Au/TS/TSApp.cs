using Puerts;
using System;

namespace Au.TS
{
    public class TSApp
    {
        public TSApp(Action<JsEnv> initAction = null)
        {
            this.initAction = initAction;
        }

        private readonly Action<JsEnv> initAction;
        private JSLoader loader;

        public JsEnv env { get; private set; }

        public void Run(string scriptChunk, string sourceFile)
        {
            loader = new JSLoader(scriptChunk, sourceFile);
            env = new JsEnv(loader);
            initAction?.Invoke(env);
            env.Eval("require('_');");
        }

        public T Func<T>(string func)
        {
            return env.Eval<T>($"require('_').{func};");
        }

        public void Tick()
        {
            env?.Tick();
        }
    }
}
