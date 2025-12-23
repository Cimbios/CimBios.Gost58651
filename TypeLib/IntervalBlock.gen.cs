using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Временная последовательность показаний одного и того же типа показания.
/// </summary>
[CimClass(ClassUri)]
public partial class IntervalBlock(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#IntervalBlock";


    /// <summary>
    /// Показание прибора учета, содержащее эту последовательность показаний.
    /// </summary>
    public MeterReading? MeterReading
    {
        get => GetAssoc1To1<MeterReading>(nameof(MeterReading));
        set => SetAssoc1To1(nameof(MeterReading), value);
    }

    /// <summary>
    /// Тип значений интервального показания, содержащихся в блоке.
    /// </summary>
    public ReadingType? ReadingType
    {
        get => GetAssoc1To1<ReadingType>(nameof(ReadingType));
        set => SetAssoc1To1(nameof(ReadingType), value);
    }

    /// <summary>
    /// Интервальные показания, содержащиеся в блоке.
    /// </summary>
    public IntervalReading[] IntervalReadings => GetAssoc1ToM<IntervalReading>(nameof(IntervalReadings));

    public void AddToIntervalReadings(IntervalReading assocObject) =>
        AddAssoc1ToM(nameof(IntervalReadings), assocObject);

    public void RemoveFromIntervalReadings(IntervalReading assocObject) =>
        RemoveAssoc1ToM(nameof(IntervalReadings), assocObject);

    public void RemoveAllFromIntervalReadings() => RemoveAllAssocs1ToM(nameof(IntervalReadings));
}