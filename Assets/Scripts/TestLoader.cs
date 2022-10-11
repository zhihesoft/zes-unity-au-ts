using Puerts;
using System.IO;
using UnityEngine;

namespace Assets.Scripts
{
    internal class TestLoader : ILoader
    {
        /// <summary>
        /// Create a JSLoader
        /// </summary>
        /// <param name="chunk">root script chunk or file, if it is a file, must start with '.'</param>
        public TestLoader()
        {
        }

        private const string puerPrefix = "puer";

        private ILoader puerLoader = new DefaultLoader();

        public readonly string rootFile;

        public bool FileExists(string filepath)
        {
            Debug.Log($"Check file exists {filepath}");
            if (filepath.StartsWith(puerPrefix) || filepath.StartsWith("csharp"))
            {
                return puerLoader.FileExists(filepath);
            }

            bool ret = File.Exists(filepath);
            Debug.Log($"Check file exists {filepath} return {ret}");
            return ret;
        }

        public string ReadFile(string filepath, out string debugpath)
        {
            if (filepath.StartsWith(puerPrefix) || filepath.StartsWith("csharp"))
            {
                return puerLoader.ReadFile(filepath, out debugpath);
            }
            debugpath = new FileInfo(filepath).FullName;
            //if (!filepath.StartsWith("."))
            //{
            //    filepath = "Typescripts/node_modules/" + filepath;
            //}
            Debug.Log($"Read file {filepath}");
            return File.ReadAllText(filepath);
        }
    }
}
