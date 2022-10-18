using Puerts;
using System;
using System.IO;

namespace Au.TS
{
    /// <summary>
    /// TS App startup info
    /// </summary>
    public class StartupInfo
    {
        /// <summary>
        /// Script location
        /// It can be a file uri or script chunk
        /// </summary>
        public string script;
        /// <summary>
        /// Debug port, disable debug if less or equal zero
        /// </summary>
        public int debugPort = 9229;
        /// <summary>
        /// Additional init actions
        /// </summary>
        public Action<JsEnv> initActions;

        /// <summary>
        /// Script represent a file
        /// </summary>
        /// <returns></returns>
        public bool IsScriptFile()
        {
            return File.Exists(script);
        }
    }
}
