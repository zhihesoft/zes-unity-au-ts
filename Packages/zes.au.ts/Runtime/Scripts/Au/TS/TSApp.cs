using Puerts;
using System;

namespace Au.TS
{
    /// <summary>
    /// A TS App
    /// </summary>
    public class TSApp : IDisposable
    {
        public TSApp(Action<JsEnv> initAction = null)
        {
            this.initAction = initAction;
        }

        private readonly Action<JsEnv> initAction;

        private JSLoader loader;

        public JsEnv env { get; private set; }

        public void Run(string scriptChunk)
        {
            loader = new JSLoader(scriptChunk);
            env = new JsEnv(loader, 9229);
            CommonInit(env);
            initAction?.Invoke(env);
            env.Eval($"require('{loader.rootFile}');");
        }

        public void Dispose()
        {
            env?.Dispose();
            env = null;
        }

        public T Func<T>(string func)
        {
            return env.Eval<T>($"require('{loader.rootFile}').{func};");
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
            env.UsingFunc<int, string>();           // for i18n
        }
    }
}
