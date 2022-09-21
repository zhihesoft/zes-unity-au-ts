using Puerts;
using System;

namespace Au.TS
{
    public class StartupInfo
    {
        public Action<JsEnv> onInit;
        public int debugPort = 9229;
    }
}
