using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Составная часть участка ЛЭП.
/// </summary>
[CimClass(ClassUri)]
public partial class ACLineSeriesSection(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Equipment(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#ACLineSeriesSection";

    /// <summary>
    /// Реактивная проводимость на землю нулевой последовательности, См.
    /// </summary>
    public float? b0ch
    {
        get => GetAttribute<float?>(nameof(b0ch));
        set => SetAttribute(nameof(b0ch), value);
    }

    /// <summary>
    /// Реактивная проводимость на землю прямой последовательности, См.
    /// </summary>
    public float? bch
    {
        get => GetAttribute<float?>(nameof(bch));
        set => SetAttribute(nameof(bch), value);
    }

    /// <summary>
    /// Расстояние начала сегмента участка линии переменного тока от начала участка линии переменного тока.
    /// </summary>
    public float? distance
    {
        get => GetAttribute<float?>(nameof(distance));
        set => SetAttribute(nameof(distance), value);
    }

    /// <summary>
    /// Активная проводимость на землю нулевой последовательности, См.
    /// </summary>
    public float? g0ch
    {
        get => GetAttribute<float?>(nameof(g0ch));
        set => SetAttribute(nameof(g0ch), value);
    }

    /// <summary>
    /// Активная проводимость на землю прямой последовательности, См.
    /// </summary>
    public float? gch
    {
        get => GetAttribute<float?>(nameof(gch));
        set => SetAttribute(nameof(gch), value);
    }

    /// <summary>
    /// Длина сегмента участка линии переменного тока, м.
    /// </summary>
    public float? length
    {
        get => GetAttribute<float?>(nameof(length));
        set => SetAttribute(nameof(length), value);
    }

    /// <summary>
    /// Активное сопротивление прямой последовательности, Ом.
    /// </summary>
    public float? r
    {
        get => GetAttribute<float?>(nameof(r));
        set => SetAttribute(nameof(r), value);
    }

    /// <summary>
    /// Активное сопротивление нулевой последовательности, Ом.
    /// </summary>
    public float? r0
    {
        get => GetAttribute<float?>(nameof(r0));
        set => SetAttribute(nameof(r0), value);
    }

    /// <summary>
    /// Порядковый номер сегмента участка линии переменного тока.
    /// </summary>
    public int? sectionNumber
    {
        get => GetAttribute<int?>(nameof(sectionNumber));
        set => SetAttribute(nameof(sectionNumber), value);
    }

    /// <summary>
    /// Тип сегмента участка линии переменного тока.
    /// </summary>
    public string? type
    {
        get => GetAttribute<string?>(nameof(type));
        set => SetAttribute(nameof(type), value);
    }

    /// <summary>
    /// Реактивное сопротивление прямой последовательности, Ом.
    /// </summary>
    public float? x
    {
        get => GetAttribute<float?>(nameof(x));
        set => SetAttribute(nameof(x), value);
    }

    /// <summary>
    /// Реактивное сопротивление нулевой последовательности, Ом.
    /// </summary>
    public float? x0
    {
        get => GetAttribute<float?>(nameof(x0));
        set => SetAttribute(nameof(x0), value);
    }

    /// <summary>
    /// Удельные параметры сегмента участка линии переменного тока.
    /// </summary>
    public PerLengthImpedance? PerLengthImpedance
    {
        get => GetAssoc1To1<PerLengthImpedance>(nameof(PerLengthImpedance));
        set => SetAssoc1To1(nameof(PerLengthImpedance), value);
    }

    /// <summary>
    /// Участок линии переменного тока, к которому относится сегмент.
    /// </summary>
    public ACLineSegment? ACLineSegment
    {
        get => GetAssoc1To1<ACLineSegment>(nameof(ACLineSegment));
        set => SetAssoc1To1(nameof(ACLineSegment), value);
    }

    /// <summary>
    /// Полюс участка линиипеременного тока, относительно которого назначаются порядковые номерасегментов этого участка.
    /// </summary>
    public Terminal? Terminal
    {
        get => GetAssoc1To1<Terminal>(nameof(Terminal));
        set => SetAssoc1To1(nameof(Terminal), value);
    }
}