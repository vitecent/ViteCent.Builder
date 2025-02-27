using ViteCent.Core.Orm;

namespace ViteCent.Builder.Data
{
    /// <summary>
    ///     Field
    /// </summary>
    public class Field : BaseField
    {
        /// <summary>
        ///     CamelCaseName
        /// </summary>
        public string CamelCaseName { get; set; } = string.Empty;

        /// <summary>
        ///     ColumnDescription
        /// </summary>
        public string ColumnDescription { get; set; } = string.Empty;

        /// <summary>
        ///     ColumnIdentity
        /// </summary>
        public string ColumnIdentity { get; set; } = string.Empty;

        /// <summary>
        ///     ColumnType
        /// </summary>
        public string ColumnLength { get; set; } = string.Empty;

        /// <summary>
        ///     ColumnNullable
        /// </summary>
        public string ColumnNullable { get; set; } = string.Empty;

        /// <summary>
        ///     ColumnPrimaryKey
        /// </summary>
        public string ColumnPrimaryKey { get; set; } = string.Empty;

        /// <summary>
        ///     ColumnType
        /// </summary>
        public string ColumnType { get; set; } = string.Empty;

        /// <summary>
        ///     DataType
        /// </summary>
        public string DataType { get; set; } = string.Empty;
    }
}