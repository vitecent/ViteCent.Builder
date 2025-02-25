#region

using SqlSugar;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Builder.Entity;

/// <summary>
///     Class BaseResourceEntity.
/// </summary>
[Serializable]
[SugarTable("base_resource")]
public class BaseResourceEntity : CompanyEntity
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
    ///     level
    /// </summary>
    [SugarColumn(ColumnName = "level")]
    public string Level { get; set; } = string.Empty;

    /// <summary>
    ///     moduleId
    /// </summary>
    [SugarColumn(ColumnName = "moduleId")]
    public string ModuleId { get; set; } = string.Empty;

    /// <summary>
    ///     name
    /// </summary>
    [SugarColumn(ColumnName = "name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    ///     parentId
    /// </summary>
    [SugarColumn(ColumnName = "parentId")]
    public string ParentId { get; set; } = string.Empty;
}