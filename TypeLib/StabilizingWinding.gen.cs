using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Компенсационная обмотка силового трансформатора.
/// </summary>
[CimClass(ClassUri)]
public partial class StabilizingWinding(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#StabilizingWinding";

    /// <summary>
    /// Активное сопротивление прямой последовательности, Ом.
    /// </summary>
    public float? r
    {
        get => GetAttribute<float?>(nameof(r));
        set => SetAttribute(nameof(r), value);
    }

    /// <summary>
    /// Номинальный ток, А.
    /// </summary>
    public float? ratedCurrent
    {
        get => GetAttribute<float?>(nameof(ratedCurrent));
        set => SetAttribute(nameof(ratedCurrent), value);
    }

    /// <summary>
    /// Номинальная полная мощность компенсационной обмотки, МВА.
    /// </summary>
    public float? ratedS
    {
        get => GetAttribute<float?>(nameof(ratedS));
        set => SetAttribute(nameof(ratedS), value);
    }

    /// <summary>
    /// Номинальное напряжение компенсационной обмотки, кВ.
    /// </summary>
    public float? ratedU
    {
        get => GetAttribute<float?>(nameof(ratedU));
        set => SetAttribute(nameof(ratedU), value);
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
    /// Трансформатор, к которому относится компенсационная обмотка.
    /// </summary>
    public PowerTransformer? PowerTransformer
    {
        get => GetAssoc1To1<PowerTransformer>(nameof(PowerTransformer));
        set => SetAssoc1To1(nameof(PowerTransformer), value);
    }

    /// <summary>
    /// Технические параметры компенсационной обмотки трансформатора.
    /// </summary>
    public TransformerEndInfo? TransformerEndInfo
    {
        get => GetAssoc1To1<TransformerEndInfo>(nameof(TransformerEndInfo));
        set => SetAssoc1To1(nameof(TransformerEndInfo), value);
    }
}