using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Устройство учета электрической энергии, которое выполняет измерительную функцию в точке поставки.
/// </summary>
[CimClass(ClassUri)]
public partial class Meter(IOIDDescriptor oid, ICimMetaClass metaClass)
    : EndDevice(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Meter";

    /// <summary>
    /// Обозначение формы прибора учета (см. [1] или другой применимый стандарт). Буквенноцифровое обозначение, представляющее схему, для которой применяется прибор учета, и его конкретное расположение клемм.
    /// </summary>
    public string? formNumber
    {
        get => GetAttribute<string?>(nameof(formNumber));
        set => SetAttribute(nameof(formNumber), value);
    }


    /// <summary>
    /// Коэффициенты, применяемые на приборе учета.
    /// </summary>
    public MeterMultiplier[] MeterMultipliers => GetAssoc1ToM<MeterMultiplier>(nameof(MeterMultipliers));

    public void AddToMeterMultipliers(MeterMultiplier assocObject) =>
        AddAssoc1ToM(nameof(MeterMultipliers), assocObject);

    public void RemoveFromMeterMultipliers(MeterMultiplier assocObject) =>
        RemoveAssoc1ToM(nameof(MeterMultipliers), assocObject);

    public void RemoveAllFromMeterMultipliers() => RemoveAllAssocs1ToM(nameof(MeterMultipliers));

    /// <summary>
    /// Показания прибора учета, предоставляемые прибором учета.
    /// </summary>
    public MeterReading[] MeterReadings => GetAssoc1ToM<MeterReading>(nameof(MeterReadings));

    public void AddToMeterReadings(MeterReading assocObject) => AddAssoc1ToM(nameof(MeterReadings), assocObject);

    public void RemoveFromMeterReadings(MeterReading assocObject) =>
        RemoveAssoc1ToM(nameof(MeterReadings), assocObject);

    public void RemoveAllFromMeterReadings() => RemoveAllAssocs1ToM(nameof(MeterReadings));
}