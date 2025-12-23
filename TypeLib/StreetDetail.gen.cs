using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Адрес в населенном пункте или городе.
/// </summary>
[CimClass(ClassUri)]
public partial class StreetDetail(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#StreetDetail";

    /// <summary>
    /// Название строения.
    /// </summary>
    public string? buildingName
    {
        get => GetAttribute<string?>(nameof(buildingName));
        set => SetAttribute(nameof(buildingName), value);
    }

    /// <summary>
    /// Цифровое или символьное обозначение этажа.
    /// </summary>
    public string? floorIdentification
    {
        get => GetAttribute<string?>(nameof(floorIdentification));
        set => SetAttribute(nameof(floorIdentification), value);
    }

    /// <summary>
    /// Название улицы.
    /// </summary>
    public string? name
    {
        get => GetAttribute<string?>(nameof(name));
        set => SetAttribute(nameof(name), value);
    }

    /// <summary>
    /// Номер строения или другое обозначение расположения, связанное с улицей.
    /// </summary>
    public string? number
    {
        get => GetAttribute<string?>(nameof(number));
        set => SetAttribute(nameof(number), value);
    }

    /// <summary>
    /// Номер офиса.
    /// </summary>
    public string? suiteNumber
    {
        get => GetAttribute<string?>(nameof(suiteNumber));
        set => SetAttribute(nameof(suiteNumber), value);
    }

    /// <summary>
    /// Тип улицы (бульвар, проспект и т.п.).
    /// </summary>
    public string? type
    {
        get => GetAttribute<string?>(nameof(type));
        set => SetAttribute(nameof(type), value);
    }
}