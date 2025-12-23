using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Элементы матрицы сопротивлений и проводимостей.
/// </summary>
[CimClass(ClassUri)]
public partial class PhaseImpedanceData(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PhaseImpedanceData";

    /// <summary>
    /// Удельная реактивная проводимость фазы, См/м.
    /// </summary>
    public float? b
    {
        get => GetAttribute<float?>(nameof(b));
        set => SetAttribute(nameof(b), value);
    }

    /// <summary>
    /// Фаза, к которой относится удельный параметр.
    /// </summary>
    public SinglePhaseKind? fromPhase
    {
        get => GetAttribute<SinglePhaseKind?>(nameof(fromPhase));
        set => SetAttribute(nameof(fromPhase), value);
    }

    /// <summary>
    /// Удельная активная проводимость фазы, См/м.
    /// </summary>
    public float? g
    {
        get => GetAttribute<float?>(nameof(g));
        set => SetAttribute(nameof(g), value);
    }

    /// <summary>
    /// Удельное активное сопротивление фазы, Ом/м.
    /// </summary>
    public float? r
    {
        get => GetAttribute<float?>(nameof(r));
        set => SetAttribute(nameof(r), value);
    }

    /// <summary>
    /// Фаза, в отношении к которой указывается удельный параметр.
    /// </summary>
    public SinglePhaseKind? toPhase
    {
        get => GetAttribute<SinglePhaseKind?>(nameof(toPhase));
        set => SetAttribute(nameof(toPhase), value);
    }

    /// <summary>
    /// Удельное реактивное сопротивление фазы, Ом/м.
    /// </summary>
    public float? x
    {
        get => GetAttribute<float?>(nameof(x));
        set => SetAttribute(nameof(x), value);
    }

    /// <summary>
    /// Удельные электрические параметры фазы участка ЛЭП.
    /// </summary>
    public PerLengthPhaseImpedance? PhaseImpedance
    {
        get => GetAssoc1To1<PerLengthPhaseImpedance>(nameof(PhaseImpedance));
        set => SetAssoc1To1(nameof(PhaseImpedance), value);
    }
}