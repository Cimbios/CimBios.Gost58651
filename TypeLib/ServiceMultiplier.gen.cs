using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Коэффициент, применяемый в точке поставки.
/// </summary>
[CimClass(ClassUri)]
public partial class ServiceMultiplier(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ServiceMultiplier";

    /// <summary>
    /// Вид коэффициента.
    /// </summary>
    public ServiceMultiplierKind? kind
    {
        get => GetAttribute<ServiceMultiplierKind?>(nameof(kind));
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
    /// Точка поставки коэффициента.
    /// </summary>
    public UsagePoint? UsagePoint
    {
        get => GetAssoc1To1<UsagePoint>(nameof(UsagePoint));
        set => SetAssoc1To1(nameof(UsagePoint), value);
    }
}