#region

using SqlSugar;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Builder.Entity;

/// <summary>
/// </summary>
[Serializable]
[SugarTable("base_module")]
public class BaseModuleEntity : CompanyEntity
{
    /// <summary>
    ///     abbreviation
    /// </summary>
    [SugarColumn(ColumnName = "abbreviation")]
    public string Abbreviation { get; set; } = string.Empty;

    /// <summary>
    ///     code
    /// </summary>
    [SugarColumn(ColumnName = "code")]
    public string Code { get; set; } = string.Empty;

    /// <summary>
    ///     description
    /// </summary>
    [SugarColumn(ColumnName = "description")]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    ///     name
    /// </summary>
    [SugarColumn(ColumnName = "name")]
    public string Name { get; set; } = string.Empty;
}