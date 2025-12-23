using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Вторичная обмотка трансформатора напряжения.
/// </summary>
[CimClass(ClassUri)]
public partial class PotentialTransformerWinding(IOIDDescriptor oid, ICimMetaClass metaClass)
    : SensorWinding(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#PotentialTransformerWinding";

    /// <summary>
    /// Коэффициент преобразования, о.е.
    /// </summary>
    public float? nominalRatio
    {
        get => GetAttribute<float?>(nameof(nominalRatio));
        set => SetAttribute(nameof(nominalRatio), value);
    }

    /// <summary>
    /// Номинальное напряжение, кВ.
    /// </summary>
    public float? nominalVoltage
    {
        get => GetAttribute<float?>(nameof(nominalVoltage));
        set => SetAttribute(nameof(nominalVoltage), value);
    }

    /// <summary>
    /// Напряжение короткого замыкания, %.
    /// </summary>
    public float? shortCircuitVoltage
    {
        get => GetAttribute<float?>(nameof(shortCircuitVoltage));
        set => SetAttribute(nameof(shortCircuitVoltage), value);
    }

    /// <summary>
    /// Трансформатор напряжения, к которому относится обмотка.
    /// </summary>
    public PotentialTransformer? Transformer
    {
        get => GetAssoc1To1<PotentialTransformer>(nameof(Transformer));
        set => SetAssoc1To1(nameof(Transformer), value);
    }
}