using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Указывает конечному устройству (или группе конечных устройств) выполнить указанное действие.
/// </summary>
[CimClass(ClassUri)]
public partial class EndDeviceControl(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#EndDeviceControl";

    /// <summary>
    /// Причина управляющего воздействия, позволяющего определить, как продолжать обработку.
    /// </summary>
    public string? reason
    {
        get => GetAttribute<string?>(nameof(reason));
        set => SetAttribute(nameof(reason), value);
    }

    /// <summary>
    /// Тип управления элементом управления конечным устройством.
    /// </summary>
    public EndDeviceControlType? EndDeviceControlType
    {
        get => GetAssoc1To1<EndDeviceControlType>(nameof(EndDeviceControlType));
        set => SetAssoc1To1(nameof(EndDeviceControlType), value);
    }

    /// <summary>
    /// Конечные устройства, получающие команды от элемента управления конечным устройством.
    /// </summary>
    public EndDevice[] EndDevices => GetAssoc1ToM<EndDevice>(nameof(EndDevices));

    public void AddToEndDevices(EndDevice assocObject) => AddAssoc1ToM(nameof(EndDevices), assocObject);
    public void RemoveFromEndDevices(EndDevice assocObject) => RemoveAssoc1ToM(nameof(EndDevices), assocObject);
    public void RemoveAllFromEndDevices() => RemoveAllAssocs1ToM(nameof(EndDevices));

    /// <summary>
    /// Точки поставки, получающие команды от элемента управления конечным устройством.
    /// </summary>
    public UsagePoint[] UsagePoints => GetAssoc1ToM<UsagePoint>(nameof(UsagePoints));

    public void AddToUsagePoints(UsagePoint assocObject) => AddAssoc1ToM(nameof(UsagePoints), assocObject);
    public void RemoveFromUsagePoints(UsagePoint assocObject) => RemoveAssoc1ToM(nameof(UsagePoints), assocObject);
    public void RemoveAllFromUsagePoints() => RemoveAllAssocs1ToM(nameof(UsagePoints));
}