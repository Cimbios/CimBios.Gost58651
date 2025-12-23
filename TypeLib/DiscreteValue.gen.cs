using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Значение дискретного измерения.
/// </summary>
[CimClass(ClassUri)]
public partial class DiscreteValue(IOIDDescriptor oid, ICimMetaClass metaClass)
    : MeasurementValue(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#DiscreteValue";

    /// <summary>
    /// Значение дискретного измерения.
    /// </summary>
    public int? value
    {
        get => GetAttribute<int?>(nameof(value));
        set => SetAttribute(nameof(value), value);
    }

    /// <summary>
    /// Измеряемый дискретный параметр.
    /// </summary>
    public Discrete? Discrete
    {
        get => GetAssoc1To1<Discrete>(nameof(Discrete));
        set => SetAssoc1To1(nameof(Discrete), value);
    }
}