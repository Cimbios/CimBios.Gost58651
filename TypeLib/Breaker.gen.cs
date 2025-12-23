using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Выключатель.
/// </summary>
[CimClass(ClassUri)]
public partial class Breaker(IOIDDescriptor oid, ICimMetaClass metaClass)
    : ProtectedSwitch(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Breaker";

    /// <summary>
    /// Время включения выключателя, с.
    /// </summary>
    public float? inTransitTime
    {
        get => GetAttribute<float?>(nameof(inTransitTime));
        set => SetAttribute(nameof(inTransitTime), value);
    }
}