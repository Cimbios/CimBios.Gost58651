using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Вращающаяся машина.
/// </summary>
[CimClass(ClassUri)]
public partial class RotatingMachine(IOIDDescriptor oid, ICimMetaClass metaClass)
    : RegulatingCondEq(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#RotatingMachine";

    /// <summary>
    /// Номинальный коэффициент мощности.
    /// </summary>
    public float? ratedPowerFactor
    {
        get => GetAttribute<float?>(nameof(ratedPowerFactor));
        set => SetAttribute(nameof(ratedPowerFactor), value);
    }

    /// <summary>
    /// Номинальная полная мощность, МВА.
    /// </summary>
    public float? ratedS
    {
        get => GetAttribute<float?>(nameof(ratedS));
        set => SetAttribute(nameof(ratedS), value);
    }

    /// <summary>
    /// Номинальное напряжение, кВ.
    /// </summary>
    public float? ratedU
    {
        get => GetAttribute<float?>(nameof(ratedU));
        set => SetAttribute(nameof(ratedU), value);
    }

    /// <summary>
    /// Энергоблок, к которому относится генератор.
    /// </summary>
    public GeneratingUnit? GeneratingUnit
    {
        get => GetAssoc1To1<GeneratingUnit>(nameof(GeneratingUnit));
        set => SetAssoc1To1(nameof(GeneratingUnit), value);
    }
}