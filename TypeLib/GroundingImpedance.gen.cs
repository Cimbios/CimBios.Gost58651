using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Индуктивное устройство заземления нейтрали для компенсации токов однофазных коротких замыканий.
/// </summary>
[CimClass(ClassUri)]
public partial class GroundingImpedance(IOIDDescriptor oid, ICimMetaClass metaClass)
    : EarthFaultCompensator(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#GroundingImpedance";

    /// <summary>
    /// Реактивное сопротивление устройства заземления нейтрали для компенсации токов однофазных коротких замыканий, Ом.
    /// </summary>
    public float? x
    {
        get => GetAttribute<float?>(nameof(x));
        set => SetAttribute(nameof(x), value);
    }
}