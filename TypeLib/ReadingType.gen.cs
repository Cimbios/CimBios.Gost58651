using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Подробное описание типа значения показания.
/// </summary>
[CimClass(ClassUri)]
public partial class ReadingType(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ReadingType";

    /// <summary>
    /// Накопления данных во времени.
    /// </summary>
    public string? accumulation
    {
        get => GetAttribute<string?>(nameof(accumulation));
        set => SetAttribute(nameof(accumulation), value);
    }

    /// <summary>
    /// Агрегированные данные с отдельных конечных точек. В основном используется для определения математической операции, выполняемой над macroPeriod, но также может использоваться для описания атрибута данных, когда macroPeriod не определен.
    /// </summary>
    public string? aggregate
    {
        get => GetAttribute<string?>(nameof(aggregate));
        set => SetAttribute(nameof(aggregate), value);
    }

    /// <summary>
    /// Аргумент, используемый для введения чисел в описание единицы измерения там, где они необходимы. Значение 0 в числителе и знаменателе означает, что неприменимо.
    /// </summary>
    public RationalNumber? argument
    {
        get => GetAttribute<RationalNumber?>(nameof(argument));
        set => SetAttribute(nameof(argument), value);
    }

    /// <summary>
    /// Измеряемый товар.
    /// </summary>
    public string? commodity
    {
        get => GetAttribute<string?>(nameof(commodity));
        set => SetAttribute(nameof(commodity), value);
    }

    /// <summary>
    /// Уровень потребления.
    /// </summary>
    public int? consumptionTier
    {
        get => GetAttribute<int?>(nameof(consumptionTier));
        set => SetAttribute(nameof(consumptionTier), value);
    }

    /// <summary>
    /// Критический пиковый период.
    /// </summary>
    public int? cpp
    {
        get => GetAttribute<int?>(nameof(cpp));
        set => SetAttribute(nameof(cpp), value);
    }

    /// <summary>
    /// Валюта.
    /// </summary>
    public Currency? currency
    {
        get => GetAttribute<Currency?>(nameof(currency));
        set => SetAttribute(nameof(currency), value);
    }

    /// <summary>
    /// Направление перетока.
    /// </summary>
    public string? flowDirection
    {
        get => GetAttribute<string?>(nameof(flowDirection));
        set => SetAttribute(nameof(flowDirection), value);
    }

    /// <summary>
    /// Индикация &#171;гармонической&#187; или &#171;интергармонической&#187; основы для измерения. Значение 0 в числителе и знаменателе означает, что аргумент неприменим.
    /// </summary>
    public ReadingInterharmonic? interharmonic
    {
        get => GetAttribute<ReadingInterharmonic?>(nameof(interharmonic));
        set => SetAttribute(nameof(interharmonic), value);
    }

    /// <summary>
    /// Интересующий период времени, который отражает то, как показание просматривается или фиксируется в течение длительного периода времени.
    /// </summary>
    public DateTimeInterval? macroPeriod
    {
        get => GetAttribute<DateTimeInterval?>(nameof(macroPeriod));
        set => SetAttribute(nameof(macroPeriod), value);
    }

    /// <summary>
    /// Определяет, &#171;что&#187; измеряется, как уточнение commodity. В сочетании с unit обеспечивает детализацию единицы измерения.
    /// </summary>
    public string? measurementKind
    {
        get => GetAttribute<string?>(nameof(measurementKind));
        set => SetAttribute(nameof(measurementKind), value);
    }

    /// <summary>
    /// Интервал измерения.
    /// </summary>
    public string? measuringPeriod
    {
        get => GetAttribute<string?>(nameof(measuringPeriod));
        set => SetAttribute(nameof(measuringPeriod), value);
    }

    /// <summary>
    /// Фаза.
    /// </summary>
    public PhaseCode? phases
    {
        get => GetAttribute<PhaseCode?>(nameof(phases));
        set => SetAttribute(nameof(phases), value);
    }

    /// <summary>
    /// Временная зона тарифа (TOU).
    /// </summary>
    public int? tou
    {
        get => GetAttribute<int?>(nameof(tou));
        set => SetAttribute(nameof(tou), value);
    }

    /// <summary>
    /// Единицы измерения.
    /// </summary>
    public string? unit
    {
        get => GetAttribute<string?>(nameof(unit));
        set => SetAttribute(nameof(unit), value);
    }

    /// <summary>
    /// Канал, собирающий показания.
    /// </summary>
    public Channel? Channel
    {
        get => GetAssoc1To1<Channel>(nameof(Channel));
        set => SetAssoc1To1(nameof(Channel), value);
    }

    /// <summary>
    /// Интервальные блоки, содержащие этот тип значений интервального показания.
    /// </summary>
    public IntervalBlock[] IntervalBlocks => GetAssoc1ToM<IntervalBlock>(nameof(IntervalBlocks));

    public void AddToIntervalBlocks(IntervalBlock assocObject) => AddAssoc1ToM(nameof(IntervalBlocks), assocObject);

    public void RemoveFromIntervalBlocks(IntervalBlock assocObject) =>
        RemoveAssoc1ToM(nameof(IntervalBlocks), assocObject);

    public void RemoveAllFromIntervalBlocks() => RemoveAllAssocs1ToM(nameof(IntervalBlocks));

    /// <summary>
    /// Спецификации, регламентирующие сбор этого типа показаний.
    /// </summary>
    public MetrologyRequirement[] MetrologyRequirements =>
        GetAssoc1ToM<MetrologyRequirement>(nameof(MetrologyRequirements));

    public void AddToMetrologyRequirements(MetrologyRequirement assocObject) =>
        AddAssoc1ToM(nameof(MetrologyRequirements), assocObject);

    public void RemoveFromMetrologyRequirements(MetrologyRequirement assocObject) =>
        RemoveAssoc1ToM(nameof(MetrologyRequirements), assocObject);

    public void RemoveAllFromMetrologyRequirements() => RemoveAllAssocs1ToM(nameof(MetrologyRequirements));

    /// <summary>
    /// Значения, имеющие этот тип значения.
    /// </summary>
    public Reading[] Readings => GetAssoc1ToM<Reading>(nameof(Readings));

    public void AddToReadings(Reading assocObject) => AddAssoc1ToM(nameof(Readings), assocObject);
    public void RemoveFromReadings(Reading assocObject) => RemoveAssoc1ToM(nameof(Readings), assocObject);
    public void RemoveAllFromReadings() => RemoveAllAssocs1ToM(nameof(Readings));
}