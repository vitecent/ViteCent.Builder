using ViteCent.Core.Orm;

namespace ViteCent.Builder.Data
{
    public class DataBase : BaseDataBase
    {
        /// <summary>
        ///     Tables
        /// </summary>
        public List<Table> Tables { get; set; } = [];
    }
}