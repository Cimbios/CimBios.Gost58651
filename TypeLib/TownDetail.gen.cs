using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Расположение города и район.
/// </summary>
[CimClass(ClassUri)]
public partial class TownDetail(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#TownDetail";

    /// <summary>
    /// Название страны.
    /// </summary>
    public string? country
    {
        get => GetAttribute<string?>(nameof(country));
        set => SetAttribute(nameof(country), value);
    }

    /// <summary>
    /// Название города.
    /// </summary>
    public string? name
    {
        get => GetAttribute<string?>(nameof(name));
        set => SetAttribute(nameof(name), value);
    }

    /// <summary>
    /// Район города.
    /// </summary>
    public string? section
    {
        get => GetAttribute<string?>(nameof(section));
        set => SetAttribute(nameof(section), value);
    }

    /// <summary>
    /// Регион страны.
    /// </summary>
    public string? stateOrProvince
    {
        get => GetAttribute<string?>(nameof(stateOrProvince));
        set => SetAttribute(nameof(stateOrProvince), value);
    }
}