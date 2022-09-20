using Puerts;

namespace Au.TS
{
    internal class JSLoader : ILoader
    {
        public JSLoader(string chunk, string sourceFile)
        {
            this.chunk = chunk;
            this.sourceFile = sourceFile;
        }

        protected readonly string chunk;

        protected readonly string sourceFile;

        protected const string puerPrefix = "puerts";

        protected ILoader puerLoader = new DefaultLoader();

        public bool FileExists(string filepath)
        {
            if (filepath.StartsWith(puerPrefix))
            {
                return puerLoader.FileExists(filepath);
            }
            return true;
        }

        public string ReadFile(string filepath, out string debugpath)
        {
            if (filepath.StartsWith(puerPrefix))
            {
                return puerLoader.ReadFile(filepath, out debugpath);
            }
            debugpath = sourceFile;
            return chunk;
        }

    }
}
