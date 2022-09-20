using Puerts;
using UnityEngine;

namespace Au.TS
{
    internal abstract class JSLoader : ILoader
    {

        protected const string puerPrefix = "puerts";

        protected ILoader puerLoader = new DefaultLoader();

        public abstract bool Init(string pathOrScript);
        public abstract void Dispose();
        protected abstract bool CheckFileExists(string filepath);
        protected abstract string DoReadFile(string filepath, out string debugpath);

        public bool FileExists(string filepath)
        {
            if (filepath.StartsWith(puerPrefix))
            {
                return puerLoader.FileExists(filepath);
            }
            return CheckFileExists(filepath);
        }

        public string ReadFile(string filepath, out string debugpath)
        {
            if (filepath.StartsWith(puerPrefix))
            {
                return puerLoader.ReadFile(filepath, out debugpath);
            }
            return DoReadFile(filepath, out debugpath);
        }

    }
}
