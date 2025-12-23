using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Подробное описание события, произведенного конечным устройством.
/// </summary>
[CimClass(ClassUri)]
public partial class EndDeviceEventType(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#EndDeviceEventType";

    /// <summary>
    /// Высокоуровневая предметная область события.
    /// </summary>
    public string? domain
    {
        get => GetAttribute<string?>(nameof(domain));
        set => SetAttribute(nameof(domain), value);
    }

    /// <summary>
    /// Наиболее специфическая часть события.
    /// </summary>
    public string? eventOrAction
    {
        get => GetAttribute<string?>(nameof(eventOrAction));
        set => SetAttribute(nameof(eventOrAction), value);
    }

    /// <summary>
    /// Более специфическая предметная область события.
    /// </summary>
    public string? subDomain
    {
        get => GetAttribute<string?>(nameof(subDomain));
        set => SetAttribute(nameof(subDomain), value);
    }

    /// <summary>
    /// Тип физического устройства, из которого было создано событие.
    /// </summary>
    public string? type
    {
        get => GetAttribute<string?>(nameof(type));
        set => SetAttribute(nameof(type), value);
    }


    /// <summary>
    /// События конечного устройства этого типа.
    /// </summary>
    public EndDeviceEvent[] EndDeviceEvents => GetAssoc1ToM<EndDeviceEvent>(nameof(EndDeviceEvents));

    public void AddToEndDeviceEvents(EndDeviceEvent assocObject) => AddAssoc1ToM(nameof(EndDeviceEvents), assocObject);

    public void RemoveFromEndDeviceEvents(EndDeviceEvent assocObject) =>
        RemoveAssoc1ToM(nameof(EndDeviceEvents), assocObject);

    public void RemoveAllFromEndDeviceEvents() => RemoveAllAssocs1ToM(nameof(EndDeviceEvents));
}