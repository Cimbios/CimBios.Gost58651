using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Телефонный номер.
/// </summary>
[CimClass(ClassUri)]
public partial class TelephoneNumber(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#TelephoneNumber";

    /// <summary>
    /// Код города.
    /// </summary>
    public string? cityCode
    {
        get => GetAttribute<string?>(nameof(cityCode));
        set => SetAttribute(nameof(cityCode), value);
    }

    /// <summary>
    /// Код страны.
    /// </summary>
    public string? countryCode
    {
        get => GetAttribute<string?>(nameof(countryCode));
        set => SetAttribute(nameof(countryCode), value);
    }

    /// <summary>
    /// Дополнительный номер.
    /// </summary>
    public string? extension
    {
        get => GetAttribute<string?>(nameof(extension));
        set => SetAttribute(nameof(extension), value);
    }

    /// <summary>
    /// Основная часть телефонного номера.
    /// </summary>
    public string? localNumber
    {
        get => GetAttribute<string?>(nameof(localNumber));
        set => SetAttribute(nameof(localNumber), value);
    }
}