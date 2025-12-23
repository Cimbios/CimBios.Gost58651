using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Вторичная обмотка трансформатора тока.
/// </summary>
[CimClass(ClassUri)]
public partial class CurrentTransformerWinding(IOIDDescriptor oid, ICimMetaClass metaClass)
    : SensorWinding(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#CurrentTransformerWinding";

    /// <summary>
    /// Предельная кратность, о.е.
    /// </summary>
    public float? kMax
    {
        get => GetAttribute<float?>(nameof(kMax));
        set => SetAttribute(nameof(kMax), value);
    }

    /// <summary>
    /// Коэффициент трансформации (выбранное ответвление).
    /// </summary>
    public float? kt
    {
        get => GetAttribute<float?>(nameof(kt));
        set => SetAttribute(nameof(kt), value);
    }

    /// <summary>
    /// Номинальные коэффициенты трансформации обмотки (для всех ответвлений).
    /// </summary>
    public string? nominalKTs
    {
        get => GetAttribute<string?>(nameof(nominalKTs));
        set => SetAttribute(nameof(nominalKTs), value);
    }

    /// <summary>
    /// Активное сопротивление обмотки, Ом.
    /// </summary>
    public float? r
    {
        get => GetAttribute<float?>(nameof(r));
        set => SetAttribute(nameof(r), value);
    }

    /// <summary>
    /// Активное сопротивление нагрузки, Ом.
    /// </summary>
    public float? ratedLoadR
    {
        get => GetAttribute<float?>(nameof(ratedLoadR));
        set => SetAttribute(nameof(ratedLoadR), value);
    }

    /// <summary>
    /// Реактивное сопротивление нагрузки, Ом.
    /// </summary>
    public float? ratedLoadX
    {
        get => GetAttribute<float?>(nameof(ratedLoadX));
        set => SetAttribute(nameof(ratedLoadX), value);
    }

    /// <summary>
    /// Реактивное сопротивление обмотки, Ом.
    /// </summary>
    public float? x
    {
        get => GetAttribute<float?>(nameof(x));
        set => SetAttribute(nameof(x), value);
    }

    /// <summary>
    /// Трансформатор тока, к которому относится обмотка.
    /// </summary>
    public CurrentTransformer? Transformer
    {
        get => GetAssoc1To1<CurrentTransformer>(nameof(Transformer));
        set => SetAssoc1To1(nameof(Transformer), value);
    }
}