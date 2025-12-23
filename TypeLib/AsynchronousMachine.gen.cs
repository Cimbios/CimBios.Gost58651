using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Асинхронная машина.
/// </summary>
[CimClass(ClassUri)]
public partial class AsynchronousMachine(IOIDDescriptor oid, ICimMetaClass metaClass)
    : RotatingMachine(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#AsynchronousMachine";

    /// <summary>
    /// Режимы работы, в которых асинхронная машина способна работать.
    /// </summary>
    public AsynchronousMachineKind? asynchronousMachineType
    {
        get => GetAttribute<AsynchronousMachineKind?>(nameof(asynchronousMachineType));
        set => SetAttribute(nameof(asynchronousMachineType), value);
    }

    /// <summary>
    /// Коэффициент полезного действия, %.
    /// </summary>
    public float? efficiency
    {
        get => GetAttribute<float?>(nameof(efficiency));
        set => SetAttribute(nameof(efficiency), value);
    }

    /// <summary>
    /// Номинальная механическая мощность, МВт.
    /// </summary>
    public float? ratedMechanicalPower
    {
        get => GetAttribute<float?>(nameof(ratedMechanicalPower));
        set => SetAttribute(nameof(ratedMechanicalPower), value);
    }

    /// <summary>
    /// Первичный двигатель асинхронного генератора.
    /// </summary>
    public PrimeMover? PrimeMover
    {
        get => GetAssoc1To1<PrimeMover>(nameof(PrimeMover));
        set => SetAssoc1To1(nameof(PrimeMover), value);
    }

    /// <summary>
    /// P-Q диаграмма асинхронной машины.
    /// </summary>
    public AsynchronousMachineReactiveCapabilityCurve? ReactiveCapabilityCurve
    {
        get => GetAssoc1To1<AsynchronousMachineReactiveCapabilityCurve>(nameof(ReactiveCapabilityCurve));
        set => SetAssoc1To1(nameof(ReactiveCapabilityCurve), value);
    }

    /// <summary>
    /// Моментно-скоростная характеристика.
    /// </summary>
    public TorqueSpeedCurve? TorqueSpeedCurve
    {
        get => GetAssoc1To1<TorqueSpeedCurve>(nameof(TorqueSpeedCurve));
        set => SetAssoc1To1(nameof(TorqueSpeedCurve), value);
    }
}