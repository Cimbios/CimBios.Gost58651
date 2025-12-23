using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Опора ЛЭП.
/// </summary>
[CimClass(ClassUri)]
public partial class Tower(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Structure(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Tower";

    /// <summary>
    /// Конструкция опоры ЛЭП.
    /// </summary>
    public TowerConstructionKind? constructionKind
    {
        get => GetAttribute<TowerConstructionKind?>(nameof(constructionKind));
        set => SetAttribute(nameof(constructionKind), value);
    }

    /// <summary>
    /// Режим заземления грозотросов.
    /// </summary>
    public string? groundingMode
    {
        get => GetAttribute<string?>(nameof(groundingMode));
        set => SetAttribute(nameof(groundingMode), value);
    }
}