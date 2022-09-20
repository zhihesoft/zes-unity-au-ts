using UnityEngine;

namespace Au.TS
{
    internal class JSLoaderRuntime : JSLoader
    {
        private string scripts = "";

        public override bool Init(string pathOrScript)
        {
            scripts = pathOrScript;
            return true;
        }

        public override void Dispose()
        {
            scripts = string.Empty;
        }

        protected override bool CheckFileExists(string filepath)
        {
            return true;
        }

        protected override string DoReadFile(string filepath, out string debugpath)
        {
            debugpath = filepath;
            return scripts;
        }
    }
}
