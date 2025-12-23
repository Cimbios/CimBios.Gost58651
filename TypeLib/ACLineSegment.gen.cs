using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Участок линии переменного тока.
/// </summary>
[CimClass(ClassUri)]
public partial class ACLineSegment(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Conductor(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ACLineSegment";

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
    /// Удельные параметры участка линии переменного тока.
    /// </summary>
    public PerLengthImpedance? PerLengthImpedance
    {
        get => GetAssoc1To1<PerLengthImpedance>(nameof(PerLengthImpedance));
        set => SetAssoc1To1(nameof(PerLengthImpedance), value);
    }

    /// <summary>
    /// Фаза участка линии переменного тока.
    /// </summary>
    public ACLineSegmentPhase[] ACLineSegmentPhases => GetAssoc1ToM<ACLineSegmentPhase>(nameof(ACLineSegmentPhases));

    public void AddToACLineSegmentPhases(ACLineSegmentPhase assocObject) =>
        AddAssoc1ToM(nameof(ACLineSegmentPhases), assocObject);

    public void RemoveFromACLineSegmentPhases(ACLineSegmentPhase assocObject) =>
        RemoveAssoc1ToM(nameof(ACLineSegmentPhases), assocObject);

    public void RemoveAllFromACLineSegmentPhases() => RemoveAllAssocs1ToM(nameof(ACLineSegmentPhases));

    /// <summary>
    /// Сегменты участка линии переменного тока.
    /// </summary>
    public ACLineSeriesSection[] ACLineSeriesSections =>
        GetAssoc1ToM<ACLineSeriesSection>(nameof(ACLineSeriesSections));

    public void AddToACLineSeriesSections(ACLineSeriesSection assocObject) =>
        AddAssoc1ToM(nameof(ACLineSeriesSections), assocObject);

    public void RemoveFromACLineSeriesSections(ACLineSeriesSection assocObject) =>
        RemoveAssoc1ToM(nameof(ACLineSeriesSections), assocObject);

    public void RemoveAllFromACLineSeriesSections() => RemoveAllAssocs1ToM(nameof(ACLineSeriesSections));
}