using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Почтовый адрес.
/// </summary>
[CimClass(ClassUri)]
public partial class StreetAddress(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#StreetAddress";

    /// <summary>
    /// Почтовый индекс.
    /// </summary>
    public string? postalCode
    {
        get => GetAttribute<string?>(nameof(postalCode));
        set => SetAttribute(nameof(postalCode), value);
    }

    /// <summary>
    /// Адрес в населенном пункте или городе.
    /// </summary>
    public StreetDetail? streetDetail
    {
        get => GetAttribute<StreetDetail?>(nameof(streetDetail));
        set => SetAttribute(nameof(streetDetail), value);
    }

    /// <summary>
    /// Расположение города и район.
    /// </summary>
    public TownDetail? townDetail
    {
        get => GetAttribute<TownDetail?>(nameof(townDetail));
        set => SetAttribute(nameof(townDetail), value);
    }
}