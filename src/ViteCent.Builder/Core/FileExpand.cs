using System.Security.Cryptography;
using System.Text;

namespace ViteCent.Builder.Core
{
    /// <summary>
    /// </summary>
    public class FileExpand
    {
        /// <summary>
        /// </summary>
        /// <param name="path"></param>
        /// <returns>处理结果</returns>
        public static bool Create(string path)
        {
            var _path = path.Replace(@"\", @"/");
            var __path = Path.GetDirectoryName(path) ?? "";
            if (!Directory.Exists(__path))
            {
                Directory.CreateDirectory(__path);
            }
            if (!File.Exists(_path))
            {
                File.Create(_path).Close();
            }
            return true;
        }

        /// <summary>
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="path"></param>
        /// <returns>处理结果</returns>
        public static bool Write(string str, string path)
        {
            Create(path);
            using var sw = new StreamWriter(path);
            sw.Write(str);
            return true;
        }
    }
}