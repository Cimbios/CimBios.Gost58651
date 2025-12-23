using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Продольное компенсирующее устройство.
/// </summary>
[CimClass(ClassUri)]
public partial class SeriesCompensator(IOIDDescriptor oid, ICimMetaClass metaClass)
    : ConductingEquipment(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#SeriesCompensator";

    /// <summary>
    /// Номинальный коэффициент связи (только для сдвоенных реакторов), о.е.
    /// </summary>
    public float? couplingCoefficient
    {
        get => GetAttribute<float?>(nameof(couplingCoefficient));
        set => SetAttribute(nameof(couplingCoefficient), value);
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
}