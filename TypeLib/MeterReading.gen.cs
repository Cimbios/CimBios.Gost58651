using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Набор значений, полученных с прибора учета.
/// </summary>
[CimClass(ClassUri)]
public partial class MeterReading(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#MeterReading";

    /// <summary>
    /// Дата и временной интервал элементов данных, содержащихся в показании прибора учета.
    /// </summary>
    public DateTimeInterval? valuesInterval
    {
        get => GetAttribute<DateTimeInterval?>(nameof(valuesInterval));
        set => SetAttribute(nameof(valuesInterval), value);
    }

    /// <summary>
    /// Прибор учета, с которого получено показание.
    /// </summary>
    public Meter? Meter
    {
        get => GetAssoc1To1<Meter>(nameof(Meter));
        set => SetAssoc1To1(nameof(Meter), value);
    }

    /// <summary>
    /// Точка поставки, из которой были получены показания прибора учета (набор значений).
    /// </summary>
    public UsagePoint? UsagePoint
    {
        get => GetAssoc1To1<UsagePoint>(nameof(UsagePoint));
        set => SetAssoc1To1(nameof(UsagePoint), value);
    }

    /// <summary>
    /// События конечного устройства, связанные с набором показаний прибора учета.
    /// </summary>
    public EndDeviceEvent[] EndDeviceEvents => GetAssoc1ToM<EndDeviceEvent>(nameof(EndDeviceEvents));

    public void AddToEndDeviceEvents(EndDeviceEvent assocObject) => AddAssoc1ToM(nameof(EndDeviceEvents), assocObject);

    public void RemoveFromEndDeviceEvents(EndDeviceEvent assocObject) =>
        RemoveAssoc1ToM(nameof(EndDeviceEvents), assocObject);

    public void RemoveAllFromEndDeviceEvents() => RemoveAllAssocs1ToM(nameof(EndDeviceEvents));

    /// <summary>
    /// Интервальные блоки, содержащиеся в показании прибора учета.
    /// </summary>
    public IntervalBlock[] IntervalBlocks => GetAssoc1ToM<IntervalBlock>(nameof(IntervalBlocks));

    public void AddToIntervalBlocks(IntervalBlock assocObject) => AddAssoc1ToM(nameof(IntervalBlocks), assocObject);

    public void RemoveFromIntervalBlocks(IntervalBlock assocObject) =>
        RemoveAssoc1ToM(nameof(IntervalBlocks), assocObject);

    public void RemoveAllFromIntervalBlocks() => RemoveAllAssocs1ToM(nameof(IntervalBlocks));

    /// <summary>
    /// Показания, содержащиеся в показании прибора учета.
    /// </summary>
    public Reading[] Readings => GetAssoc1ToM<Reading>(nameof(Readings));

    public void AddToReadings(Reading assocObject) => AddAssoc1ToM(nameof(Readings), assocObject);
    public void RemoveFromReadings(Reading assocObject) => RemoveAssoc1ToM(nameof(Readings), assocObject);
    public void RemoveAllFromReadings() => RemoveAllAssocs1ToM(nameof(Readings));
}