using ViteCent.Core.Orm;

namespace ViteCent.Builder.Data
{
    /// <summary>
    ///     Table
    /// </summary>
    public class Table : BaseTable
    {
        /// <summary>
        ///     CamelCaseName
        /// </summary>
        public string CamelCaseName { get; set; } = string.Empty;

        /// <summary>
        ///     Fields
        /// </summary>
        public List<Field> Fields { get; set; } = [];
    }
}