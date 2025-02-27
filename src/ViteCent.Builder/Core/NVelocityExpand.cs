using Commons.Collections;
using NVelocity;
using NVelocity.App;
using NVelocity.Runtime;
using ViteCent.Core;

namespace ViteCent.Builder.Core
{
    /// <summary>
    ///     NVelocityHelper
    /// </summary>
    public class NVelocityExpand
    {
        /// <summary>
        /// </summary>
        private readonly VelocityContext vc = default!;

        /// <summary>
        /// </summary>
        private readonly VelocityEngine ve = default!;

        /// <summary>
        ///     NVelocityHelper
        /// </summary>
        /// <param name="path"></param>
        public NVelocityExpand(string path)
        {
            ve = new VelocityEngine();
            var eps = new ExtendedProperties();
            eps.AddProperty(RuntimeConstants.INPUT_ENCODING, "utf-8");
            eps.AddProperty(RuntimeConstants.OUTPUT_ENCODING, "utf-8");
            eps.AddProperty(RuntimeConstants.RESOURCE_LOADER, "file");
            eps.AddProperty(RuntimeConstants.FILE_RESOURCE_LOADER_PATH, path);
            ve.Init(eps);

            vc = new VelocityContext();
        }

        /// <summary>
        ///     Display
        /// </summary>
        /// <param name="path"></param>
        /// <returns>result</returns>
        public string Display(string path)
        {
            var vm = ve.GetTemplate(path);
            using var sw = new StringWriter();
            vm.Merge(vc, sw);
            return sw.ToString();
        }

        /// <summary>
        ///     Put
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        public void Put(string key, object value)
        {
            vc.Put(key, value);
        }

        /// <summary>
        ///     Save
        /// </summary>
        /// <param name="path"></param>
        /// <param name="savePath"></param>
        /// <returns>result</returns>
        public bool Save(string path, string savePath)
        {
            var vm = ve.GetTemplate(path);
            using var sw = new StringWriter();
            vm.Merge(vc, sw);
            var str = sw.ToString();
            var flag = FileExpand.Write(str, savePath);
            sw.Close();
            return flag;
        }
    }
}