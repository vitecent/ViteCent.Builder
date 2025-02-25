#region

using SqlSugar;
using ViteCent.Core.Orm.SqlSugar;

#endregion

namespace ViteCent.Builder.Entity;

/// <summary>
///     BaseModuleFieldEntity
/// </summary>
[Serializable]
[SugarTable("base_module_field")]
public class BaseModuleFieldEntity : CompanyEntity
{
    /// <summary>
    ///     abbreviation
    /// </summary>
    [SugarColumn(ColumnName = "abbreviation")]
    public string Abbreviation { get; set; } = string.Empty;

    /// <summary>
    ///     addOrder
    /// </summary>
    [SugarColumn(ColumnName = "addOrder")]
    public string AddOrder { get; set; } = string.Empty;

    /// <summary>
    ///     addWidth
    /// </summary>
    [SugarColumn(ColumnName = "addWidth")]
    public string AddWidth { get; set; } = string.Empty;

    /// <summary>
    ///     allowNull
    /// </summary>
    [SugarColumn(ColumnName = "allowNull")]
    public int AllowNull { get; set; }

    /// <summary>
    ///     code
    /// </summary>
    [SugarColumn(ColumnName = "code")]
    public string Code { get; set; } = string.Empty;

    /// <summary>
    ///     dataType
    /// </summary>
    [SugarColumn(ColumnName = "dataType")]
    public string DataType { get; set; } = string.Empty;

    /// <summary>
    ///     description
    /// </summary>
    [SugarColumn(ColumnName = "description")]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    ///     detailsOrder
    /// </summary>
    [SugarColumn(ColumnName = "detailsOrder")]
    public string DetailsOrder { get; set; } = string.Empty;

    /// <summary>
    ///     detailsWidth
    /// </summary>
    [SugarColumn(ColumnName = "detailsWidth")]
    public string DetailsWidth { get; set; } = string.Empty;

    /// <summary>
    ///     exportOrder
    /// </summary>
    [SugarColumn(ColumnName = "exportOrder")]
    public string ExportOrder { get; set; } = string.Empty;

    /// <summary>
    ///     exportWidth
    /// </summary>
    [SugarColumn(ColumnName = "exportWidth")]
    public string ExportWidth { get; set; } = string.Empty;

    /// <summary>
    ///     isIndex
    /// </summary>
    [SugarColumn(ColumnName = "isIndex")]
    public int IsIndex { get; set; }

    /// <summary>
    ///     isUnique
    /// </summary>
    [SugarColumn(ColumnName = "isUnique")]
    public int IsUnique { get; set; }

    /// <summary>
    ///     listOrder
    /// </summary>
    [SugarColumn(ColumnName = "listOrder")]
    public string ListOrder { get; set; } = string.Empty;

    /// <summary>
    ///     listWidth
    /// </summary>
    [SugarColumn(ColumnName = "listWidth")]
    public string ListWidth { get; set; } = string.Empty;

    /// <summary>
    ///     maxLength
    /// </summary>
    [SugarColumn(ColumnName = "maxLength")]
    public string MaxLength { get; set; } = string.Empty;

    /// <summary>
    ///     minLength
    /// </summary>
    [SugarColumn(ColumnName = "minLength")]
    public string MinLength { get; set; } = string.Empty;

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
    ///     printOrder
    /// </summary>
    [SugarColumn(ColumnName = "printOrder")]
    public string PrintOrder { get; set; } = string.Empty;

    /// <summary>
    ///     printWidth
    /// </summary>
    [SugarColumn(ColumnName = "printWidth")]
    public string PrintWidth { get; set; } = string.Empty;

    /// <summary>
    ///     searchOrder
    /// </summary>
    [SugarColumn(ColumnName = "searchOrder")]
    public string SearchOrder { get; set; } = string.Empty;

    /// <summary>
    ///     searchWidth
    /// </summary>
    [SugarColumn(ColumnName = "searchWidth")]
    public string SearchWidth { get; set; } = string.Empty;

    /// <summary>
    ///     showInAdd
    /// </summary>
    [SugarColumn(ColumnName = "showInAdd")]
    public int ShowInAdd { get; set; }

    /// <summary>
    ///     showInDetails
    /// </summary>
    [SugarColumn(ColumnName = "showInDetails")]
    public int ShowInDetails { get; set; }

    /// <summary>
    ///     showInExport
    /// </summary>
    [SugarColumn(ColumnName = "showInExport")]
    public int ShowInExport { get; set; }

    /// <summary>
    ///     showInList
    /// </summary>
    [SugarColumn(ColumnName = "showInList")]
    public int ShowInList { get; set; }

    /// <summary>
    ///     showInPrint
    /// </summary>
    [SugarColumn(ColumnName = "showInPrint")]
    public int ShowInPrint { get; set; }

    /// <summary>
    ///     showInSearch
    /// </summary>
    [SugarColumn(ColumnName = "showInSearch")]
    public int ShowInSearch { get; set; }

    /// <summary>
    ///     showInUpdate
    /// </summary>
    [SugarColumn(ColumnName = "showInUpdate")]
    public int ShowInUpdate { get; set; }

    /// <summary>
    ///     updateOrder
    /// </summary>
    [SugarColumn(ColumnName = "updateOrder")]
    public string UpdateOrder { get; set; } = string.Empty;

    /// <summary>
    ///     updateWidth
    /// </summary>
    [SugarColumn(ColumnName = "updateWidth")]
    public string UpdateWidth { get; set; } = string.Empty;
}