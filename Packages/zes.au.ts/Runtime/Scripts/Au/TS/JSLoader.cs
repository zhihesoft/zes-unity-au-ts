using Puerts;
using System.IO;

namespace Au.TS
{
    internal class JSLoader : ILoader
    {
        /// <summary>
        /// Create a JSLoader
        /// </summary>
        /// <param name="chunk">root script chunk, if chunk is empty, will load from real path</param>
        public JSLoader(string chunk)
        {
            this.chunk = chunk;
            chunkMode = !string.IsNullOrEmpty(chunk);
        }

        private readonly bool chunkMode;

        private readonly string chunk;

        private const string puerPrefix = "puer";
        private const string csharpPrefix = "csharp";

        private ILoader puerLoader = new DefaultLoader();

        public bool FileExists(string filepath)
        {
            if (filepath.StartsWith(puerPrefix) || filepath.StartsWith(csharpPrefix))
            {
                return puerLoader.FileExists(filepath);
            }
            if (chunkMode) // always return true in bundle mode
            {
                return true;
            }
            var ret = File.Exists(filepath);
            return ret;
        }

        public string ReadFile(string filepath, out string debugpath)
        {
            if (filepath.StartsWith(puerPrefix) || filepath.StartsWith(csharpPrefix))
            {
                return puerLoader.ReadFile(filepath, out debugpath);
            }
            if (chunkMode) // always return chunk in bundle mode
            {
                debugpath = filepath;
                return chunk;
            }
            debugpath = new FileInfo(filepath).FullName;
            var ret = File.ReadAllText(filepath);
            return ret;

        }
    }
}
