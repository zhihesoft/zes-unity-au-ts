using System.IO;
using System.Text;

namespace Au.TS
{
    internal class JSLoaderEditor : JSLoader
    {
        public override bool Init(string pathOrScript)
        {
            return true;
        }


        public override void Dispose()
        {
        }

        protected override bool CheckFileExists(string filepath)
        {
            var path = Path.Combine(filepath);
            bool ret = File.Exists(path);
            return ret;
        }

        protected override string DoReadFile(string filepath, out string debugpath)
        {
            var path = Path.Combine(filepath);
            debugpath = path;
            // logger.Debug($"load js file: {path}");
            return File.ReadAllText(path, Encoding.UTF8);
        }
    }
}
