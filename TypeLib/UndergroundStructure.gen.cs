using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Параметры конструкции подземной ЛЭП.
/// </summary>
[CimClass(ClassUri)]
public partial class UndergroundStructure(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Structure(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#UndergroundStructure";

    /// <summary>
    /// Тип конструкции КЛ.
    /// </summary>
    public UndergroundStructureKind? kind
    {
        get => GetAttribute<UndergroundStructureKind?>(nameof(kind));
        set => SetAttribute(nameof(kind), value);
    }

    /// <summary>
    /// Основной материал конструкции КЛ.
    /// </summary>
    public string? material
    {
        get => GetAttribute<string?>(nameof(material));
        set => SetAttribute(nameof(material), value);
    }
}