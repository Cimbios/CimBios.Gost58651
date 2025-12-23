using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Технические параметры кабеля с экраном,состоящим из отдельных проводников.
/// </summary>
[CimClass(ClassUri)]
public partial class ConcentricNeutralCableInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : CableInfo(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ConcentricNeutralCableInfo";

    /// <summary>
    /// Внешний диаметр концентрической нейтрали кабеля, м.
    /// </summary>
    public float? diameterOverNeutral
    {
        get => GetAttribute<float?>(nameof(diameterOverNeutral));
        set => SetAttribute(nameof(diameterOverNeutral), value);
    }

    /// <summary>
    /// Удельное сопротивление концентрической нейтрали кабеля постоянному току при температуре 20 &#176;C, Ом/м.
    /// </summary>
    public float? neutralStrandRDC20
    {
        get => GetAttribute<float?>(nameof(neutralStrandRDC20));
        set => SetAttribute(nameof(neutralStrandRDC20), value);
    }
}