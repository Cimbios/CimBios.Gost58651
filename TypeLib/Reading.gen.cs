using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Некоторое значение, вычисленное прибором учета или другим материальным объектом либо рассчитанное системой.
/// </summary>
[CimClass(ClassUri)]
public partial class Reading(IOIDDescriptor oid, ICimMetaClass metaClass)
    : BaseReading(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Reading";

    /// <summary>
    /// Причина, по которой показание было получено.
    /// </summary>
    public ReadingReasonKind? reason
    {
        get => GetAttribute<ReadingReasonKind?>(nameof(reason));
        set => SetAttribute(nameof(reason), value);
    }

    /// <summary>
    /// Тип значения.
    /// </summary>
    public ReadingType? ReadingType
    {
        get => GetAssoc1To1<ReadingType>(nameof(ReadingType));
        set => SetAssoc1To1(nameof(ReadingType), value);
    }

    /// <summary>
    /// Наборы значений, содержащие это показание.
    /// </summary>
    public MeterReading[] MeterReadings => GetAssoc1ToM<MeterReading>(nameof(MeterReadings));

    public void AddToMeterReadings(MeterReading assocObject) => AddAssoc1ToM(nameof(MeterReadings), assocObject);

    public void RemoveFromMeterReadings(MeterReading assocObject) =>
        RemoveAssoc1ToM(nameof(MeterReadings), assocObject);

    public void RemoveAllFromMeterReadings() => RemoveAllAssocs1ToM(nameof(MeterReadings));
}