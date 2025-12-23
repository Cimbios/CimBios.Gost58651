using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Пара &#171;имя � значение&#187;, специфичная для событий конечного устройства.
/// </summary>
[CimClass(ClassUri)]
public partial class EndDeviceEventDetail(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#EndDeviceEventDetail";

    /// <summary>
    /// Наименование.
    /// </summary>
    public string? name
    {
        get => GetAttribute<string?>(nameof(name));
        set => SetAttribute(nameof(name), value);
    }

    /// <summary>
    /// Значение.
    /// </summary>
    public StringQuantity? value
    {
        get => GetAttribute<StringQuantity?>(nameof(value));
        set => SetAttribute(nameof(value), value);
    }

    /// <summary>
    /// Событие конечного устройства, обладающее подробностями.
    /// </summary>
    public EndDeviceEvent? EndDeviceEvent
    {
        get => GetAssoc1To1<EndDeviceEvent>(nameof(EndDeviceEvent));
        set => SetAssoc1To1(nameof(EndDeviceEvent), value);
    }
}