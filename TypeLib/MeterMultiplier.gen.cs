using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Коэффициент, применяемый на приборе учета.
/// </summary>
[CimClass(ClassUri)]
public partial class MeterMultiplier(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#MeterMultiplier";

    /// <summary>
    /// Вид коэффициента.
    /// </summary>
    public MeterMultiplierKind? kind
    {
        get => GetAttribute<MeterMultiplierKind?>(nameof(kind));
        set => SetAttribute(nameof(kind), value);
    }

    /// <summary>
    /// Значение коэффициента.
    /// </summary>
    public float? value
    {
        get => GetAttribute<float?>(nameof(value));
        set => SetAttribute(nameof(value), value);
    }

    /// <summary>
    /// Прибор учета, имеющий этот коэффициент.
    /// </summary>
    public Meter? Meter
    {
        get => GetAssoc1To1<Meter>(nameof(Meter));
        set => SetAssoc1To1(nameof(Meter), value);
    }
}