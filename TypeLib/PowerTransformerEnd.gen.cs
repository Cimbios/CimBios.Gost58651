using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Электрический вывод силового трансформатора.
/// </summary>
[CimClass(ClassUri)]
public partial class PowerTransformerEnd(IOIDDescriptor oid, ICimMetaClass metaClass)
    : TransformerEnd(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PowerTransformerEnd";

    /// <summary>
    /// Реактивная проводимость прямой последовательности шунта намагничивания, приведенная к номинальному напряжению вывода с наивысшим напряжением, См.
    /// </summary>
    public float? b
    {
        get => GetAttribute<float?>(nameof(b));
        set => SetAttribute(nameof(b), value);
    }

    /// <summary>
    /// Реактивная проводимость нулевой последовательности шунта намагничивания, приведенная к номинальному напряжению вывода с наивысшим напряжением, См.
    /// </summary>
    public float? b0
    {
        get => GetAttribute<float?>(nameof(b0));
        set => SetAttribute(nameof(b0), value);
    }

    /// <summary>
    /// Схема соединения обмоток.
    /// </summary>
    public WindingConnection? connectionKind
    {
        get => GetAttribute<WindingConnection?>(nameof(connectionKind));
        set => SetAttribute(nameof(connectionKind), value);
    }

    /// <summary>
    /// Активная проводимость прямой последовательности шунта намагничивания, приведенная к номинальному напряжению вывода с наивысшим напряжением, См.
    /// </summary>
    public float? g
    {
        get => GetAttribute<float?>(nameof(g));
        set => SetAttribute(nameof(g), value);
    }

    /// <summary>
    /// Активная проводимость нулевой последовательности шунта намагничивания, приведенная к номинальному напряжению вывода с наивысшим напряжением, См.
    /// </summary>
    public float? g0
    {
        get => GetAttribute<float?>(nameof(g0));
        set => SetAttribute(nameof(g0), value);
    }

    /// <summary>
    /// Группа соединения обмоток.
    /// </summary>
    public int? phaseAngleClock
    {
        get => GetAttribute<int?>(nameof(phaseAngleClock));
        set => SetAttribute(nameof(phaseAngleClock), value);
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
    /// Номинальная полная мощность, МВА.
    /// </summary>
    public float? ratedS
    {
        get => GetAttribute<float?>(nameof(ratedS));
        set => SetAttribute(nameof(ratedS), value);
    }

    /// <summary>
    /// Номинальное напряжение вывода трансформатора, кВ.
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
    /// Реактивное сопротивление нулевой последовательности, Ом.
    /// </summary>
    public float? x0
    {
        get => GetAttribute<float?>(nameof(x0));
        set => SetAttribute(nameof(x0), value);
    }

    /// <summary>
    /// Силовой трансформатор, к которому относится вывод.
    /// </summary>
    public PowerTransformer? PowerTransformer
    {
        get => GetAssoc1To1<PowerTransformer>(nameof(PowerTransformer));
        set => SetAssoc1To1(nameof(PowerTransformer), value);
    }

    /// <summary>
    /// Технические параметры вывода трансформатора.
    /// </summary>
    public TransformerEndInfo? TransformerEndInfo
    {
        get => GetAssoc1To1<TransformerEndInfo>(nameof(TransformerEndInfo));
        set => SetAssoc1To1(nameof(TransformerEndInfo), value);
    }
}