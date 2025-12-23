using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Линейное шунтирующее компенсирующее устройство.
/// </summary>
[CimClass(ClassUri)]
public partial class LinearShuntCompensator(IOIDDescriptor oid, ICimMetaClass metaClass)
    : ShuntCompensator(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#LinearShuntCompensator";

    /// <summary>
    /// Реактивная проводимость нулевой последовательности на секцию, См.
    /// </summary>
    public float? b0PerSection
    {
        get => GetAttribute<float?>(nameof(b0PerSection));
        set => SetAttribute(nameof(b0PerSection), value);
    }

    /// <summary>
    /// Реактивная проводимость прямой последовательности на секцию, См.
    /// </summary>
    public float? bPerSection
    {
        get => GetAttribute<float?>(nameof(bPerSection));
        set => SetAttribute(nameof(bPerSection), value);
    }

    /// <summary>
    /// Активная проводимость нулевой последовательности на секцию, См.
    /// </summary>
    public float? g0PerSection
    {
        get => GetAttribute<float?>(nameof(g0PerSection));
        set => SetAttribute(nameof(g0PerSection), value);
    }

    /// <summary>
    /// Активная проводимость прямой последовательности на секцию, См.
    /// </summary>
    public float? gPerSection
    {
        get => GetAttribute<float?>(nameof(gPerSection));
        set => SetAttribute(nameof(gPerSection), value);
    }
}