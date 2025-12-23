using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Общее представление для считанных значений.
/// </summary>
[CimClass(ClassUri)]
public partial class BaseReading(IOIDDescriptor oid, ICimMetaClass metaClass)
    : MeasurementValue(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#BaseReading";

    /// <summary>
    /// Дата и время, когда показания были впервые переданы в измерительную систему [Дата и Время] (используются только при наличии детальных требований к аудиту).
    /// </summary>
    public DateTime? firstReportedDateTime
    {
        get => GetAttribute<DateTime?>(nameof(firstReportedDateTime));
        set => SetAttribute(nameof(firstReportedDateTime), value);
    }

    /// <summary>
    /// Система, выступающая в качестве источника показания (например, клиент, автоматизированная система сбора, другая корпоративная система и т. д.)
    /// </summary>
    public string? source
    {
        get => GetAttribute<string?>(nameof(source));
        set => SetAttribute(nameof(source), value);
    }

    /// <summary>
    /// Начало и конец периода для тех показаний, тип которых определен как сезонный или временной [Дата и время].
    /// </summary>
    public DateTimeInterval? timePeriod
    {
        get => GetAttribute<DateTimeInterval?>(nameof(timePeriod));
        set => SetAttribute(nameof(timePeriod), value);
    }

    /// <summary>
    /// Значение показания.
    /// </summary>
    public string? value
    {
        get => GetAttribute<string?>(nameof(value));
        set => SetAttribute(nameof(value), value);
    }


    /// <summary>
    /// Качества показания.
    /// </summary>
    public ReadingQuality[] ReadingQualities => GetAssoc1ToM<ReadingQuality>(nameof(ReadingQualities));

    public void AddToReadingQualities(ReadingQuality assocObject) =>
        AddAssoc1ToM(nameof(ReadingQualities), assocObject);

    public void RemoveFromReadingQualities(ReadingQuality assocObject) =>
        RemoveAssoc1ToM(nameof(ReadingQualities), assocObject);

    public void RemoveAllFromReadingQualities() => RemoveAllAssocs1ToM(nameof(ReadingQualities));
}