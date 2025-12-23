using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Устройство заземления нейтрали для компенсации токов однофазных коротких замыканий.
/// </summary>
[CimClass(ClassUri)]
public partial class EarthFaultCompensator(IOIDDescriptor oid, ICimMetaClass metaClass)
    : ConductingEquipment(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#EarthFaultCompensator";

    /// <summary>
    /// Активное сопротивление устройства компенсации однофазных токов короткого замыкания, Ом.
    /// </summary>
    public float? r
    {
        get => GetAttribute<float?>(nameof(r));
        set => SetAttribute(nameof(r), value);
    }
}