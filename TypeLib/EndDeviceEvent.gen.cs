using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Событие, обнаруженное функцией устройства, связанной с конечным устройством.
/// </summary>
[CimClass(ClassUri)]
public partial class EndDeviceEvent(IOIDDescriptor oid, ICimMetaClass metaClass)
    : ActivityRecord(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#EndDeviceEvent";


    /// <summary>
    /// Точка поставки, для которой сообщается о событии конечного устройства.
    /// </summary>
    public UsagePoint? UsagePoint
    {
        get => GetAssoc1To1<UsagePoint>(nameof(UsagePoint));
        set => SetAssoc1To1(nameof(UsagePoint), value);
    }

    /// <summary>
    /// Тип события конечного устройства.
    /// </summary>
    public EndDeviceEventType? EndDeviceEventType
    {
        get => GetAssoc1To1<EndDeviceEventType>(nameof(EndDeviceEventType));
        set => SetAssoc1To1(nameof(EndDeviceEventType), value);
    }

    /// <summary>
    /// Показание прибора учета, в котором отражено это событие конечного устройства.
    /// </summary>
    public MeterReading? MeterReading
    {
        get => GetAssoc1To1<MeterReading>(nameof(MeterReading));
        set => SetAssoc1To1(nameof(MeterReading), value);
    }

    /// <summary>
    /// Подробности события конечного устройства.
    /// </summary>
    public EndDeviceEventDetail[] EndDeviceEventDetails =>
        GetAssoc1ToM<EndDeviceEventDetail>(nameof(EndDeviceEventDetails));

    public void AddToEndDeviceEventDetails(EndDeviceEventDetail assocObject) =>
        AddAssoc1ToM(nameof(EndDeviceEventDetails), assocObject);

    public void RemoveFromEndDeviceEventDetails(EndDeviceEventDetail assocObject) =>
        RemoveAssoc1ToM(nameof(EndDeviceEventDetails), assocObject);

    public void RemoveAllFromEndDeviceEventDetails() => RemoveAllAssocs1ToM(nameof(EndDeviceEventDetails));
}