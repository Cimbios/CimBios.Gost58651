using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Свойства ТТ.
/// </summary>
[CimClass(ClassUri)]
public partial class CurrentTransformerInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : AssetInfo(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#CurrentTransformerInfo";

    /// <summary>
    /// Максимальный первичный ток, А, равный 120 % от номинального.
    /// </summary>
    public float? kneePointCurrent
    {
        get => GetAttribute<float?>(nameof(kneePointCurrent));
        set => SetAttribute(nameof(kneePointCurrent), value);
    }

    /// <summary>
    /// Напряжение на вторичной обмотке ТТ, В, при котором достигается максимальное значение нагрузки.
    /// </summary>
    public float? kneePointVoltage
    {
        get => GetAttribute<float?>(nameof(kneePointVoltage));
        set => SetAttribute(nameof(kneePointVoltage), value);
    }

    /// <summary>
    /// Максимальное значение коэффициента трансформации.
    /// </summary>
    public Ratio? maxRatio
    {
        get => GetAttribute<Ratio?>(nameof(maxRatio));
        set => SetAttribute(nameof(maxRatio), value);
    }

    /// <summary>
    /// Номинальное значение коэффициента трансформации.
    /// </summary>
    public Ratio? nominalRatio
    {
        get => GetAttribute<Ratio?>(nameof(nominalRatio));
        set => SetAttribute(nameof(nominalRatio), value);
    }

    /// <summary>
    /// Полная вторичная нагрузка для первичной обмотки, А.
    /// </summary>
    public float? primaryFlsRating
    {
        get => GetAttribute<float?>(nameof(primaryFlsRating));
        set => SetAttribute(nameof(primaryFlsRating), value);
    }

    /// <summary>
    /// Номинальное значение обмотки высшего напряжения.
    /// </summary>
    public Ratio? primaryRatio
    {
        get => GetAttribute<Ratio?>(nameof(primaryRatio));
        set => SetAttribute(nameof(primaryRatio), value);
    }

    /// <summary>
    /// Номинальный ток на первичной стороне, А.
    /// </summary>
    public float? ratedCurrent
    {
        get => GetAttribute<float?>(nameof(ratedCurrent));
        set => SetAttribute(nameof(ratedCurrent), value);
    }

    /// <summary>
    /// Полная вторичная нагрузка для вторичной обмотки, А.
    /// </summary>
    public float? secondaryFlsRating
    {
        get => GetAttribute<float?>(nameof(secondaryFlsRating));
        set => SetAttribute(nameof(secondaryFlsRating), value);
    }

    /// <summary>
    /// Номинальное значение обмотки среднего напряжения.
    /// </summary>
    public Ratio? secondaryRatio
    {
        get => GetAttribute<Ratio?>(nameof(secondaryRatio));
        set => SetAttribute(nameof(secondaryRatio), value);
    }

    /// <summary>
    /// Полная вторичная нагрузка для третичной обмотки, А
    /// </summary>
    public float? tertiaryFlsRating
    {
        get => GetAttribute<float?>(nameof(tertiaryFlsRating));
        set => SetAttribute(nameof(tertiaryFlsRating), value);
    }

    /// <summary>
    /// Номинальное значение обмотки низшего напряжения. Значение тока третичной обмотки, А, по высокой стороне.
    /// </summary>
    public Ratio? tertiaryRatio
    {
        get => GetAttribute<Ratio?>(nameof(tertiaryRatio));
        set => SetAttribute(nameof(tertiaryRatio), value);
    }

    /// <summary>
    /// Использование: например, измерение, защита и т. д.
    /// </summary>
    public string? usage
    {
        get => GetAttribute<string?>(nameof(usage));
        set => SetAttribute(nameof(usage), value);
    }
}