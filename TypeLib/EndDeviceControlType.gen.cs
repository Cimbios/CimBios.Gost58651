using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Подробное описание команды управления, выполняемого конечным устройством.
/// </summary>
[CimClass(ClassUri)]
public partial class EndDeviceControlType(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#EndDeviceControlType";

    /// <summary>
    /// Высокоуровневая предметная область элемента управления.
    /// </summary>
    public string? domain
    {
        get => GetAttribute<string?>(nameof(domain));
        set => SetAttribute(nameof(domain), value);
    }

    /// <summary>
    /// Наиболее специфическая часть типа элемента управления.
    /// </summary>
    public string? eventOrAction
    {
        get => GetAttribute<string?>(nameof(eventOrAction));
        set => SetAttribute(nameof(eventOrAction), value);
    }

    /// <summary>
    /// Более специфическая предметная область элемента управления, как подвариант domain.
    /// </summary>
    public string? subDomain
    {
        get => GetAttribute<string?>(nameof(subDomain));
        set => SetAttribute(nameof(subDomain), value);
    }

    /// <summary>
    /// Тип физического устройства, из которого был создан элемент управления.
    /// </summary>
    public string? type
    {
        get => GetAttribute<string?>(nameof(type));
        set => SetAttribute(nameof(type), value);
    }


    /// <summary>
    /// Элементы управления конечными устройствами, имеющие этот тип управления.
    /// </summary>
    public EndDeviceControl[] EndDeviceControls => GetAssoc1ToM<EndDeviceControl>(nameof(EndDeviceControls));

    public void AddToEndDeviceControls(EndDeviceControl assocObject) =>
        AddAssoc1ToM(nameof(EndDeviceControls), assocObject);

    public void RemoveFromEndDeviceControls(EndDeviceControl assocObject) =>
        RemoveAssoc1ToM(nameof(EndDeviceControls), assocObject);

    public void RemoveAllFromEndDeviceControls() => RemoveAllAssocs1ToM(nameof(EndDeviceControls));
}