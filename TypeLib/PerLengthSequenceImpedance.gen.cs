using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Удельные электрические параметры участка ЛЭП.
/// </summary>
[CimClass(ClassUri)]
public partial class PerLengthSequenceImpedance(IOIDDescriptor oid, ICimMetaClass metaClass)
    : PerLengthImpedance(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PerLengthSequenceImpedance";

    /// <summary>
    /// Удельная емкостная проводимость участка ЛЭП нулевой последовательности, См/м.
    /// </summary>
    public float? b0ch
    {
        get => GetAttribute<float?>(nameof(b0ch));
        set => SetAttribute(nameof(b0ch), value);
    }

    /// <summary>
    /// Удельная емкостная проводимость участка ЛЭП прямой последовательности, См/м.
    /// </summary>
    public float? bch
    {
        get => GetAttribute<float?>(nameof(bch));
        set => SetAttribute(nameof(bch), value);
    }

    /// <summary>
    /// Удельная активная проводимость участка ЛЭП нулевой последовательности, См/м.
    /// </summary>
    public float? g0ch
    {
        get => GetAttribute<float?>(nameof(g0ch));
        set => SetAttribute(nameof(g0ch), value);
    }

    /// <summary>
    /// Удельная активная проводимость участка ЛЭП прямой последовательности, См/м.
    /// </summary>
    public float? gch
    {
        get => GetAttribute<float?>(nameof(gch));
        set => SetAttribute(nameof(gch), value);
    }

    /// <summary>
    /// Удельное активное сопротивление участка ЛЭП прямой последовательности, Ом/м.
    /// </summary>
    public float? r
    {
        get => GetAttribute<float?>(nameof(r));
        set => SetAttribute(nameof(r), value);
    }

    /// <summary>
    /// Удельное активное сопротивление участка ЛЭП нулевой последовательности, Ом/м.
    /// </summary>
    public float? r0
    {
        get => GetAttribute<float?>(nameof(r0));
        set => SetAttribute(nameof(r0), value);
    }

    /// <summary>
    /// Удельное реактивное сопротивление участка ЛЭП прямой последовательности, Ом/м.
    /// </summary>
    public float? x
    {
        get => GetAttribute<float?>(nameof(x));
        set => SetAttribute(nameof(x), value);
    }

    /// <summary>
    /// Удельное реактивное сопротивление участка ЛЭП нулевой последовательности, Ом/м.
    /// </summary>
    public float? x0
    {
        get => GetAttribute<float?>(nameof(x0));
        set => SetAttribute(nameof(x0), value);
    }
}