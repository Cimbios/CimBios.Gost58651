using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Значение аналогового измерения.
/// </summary>
[CimClass(ClassUri)]
public partial class AnalogValue(IOIDDescriptor oid, ICimMetaClass metaClass)
    : MeasurementValue(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#AnalogValue";

    /// <summary>
    /// Значение измерения.
    /// </summary>
    public float? value
    {
        get => GetAttribute<float?>(nameof(value));
        set => SetAttribute(nameof(value), value);
    }

    /// <summary>
    /// Измеряемый аналоговый параметр.
    /// </summary>
    public Analog? Analog
    {
        get => GetAssoc1To1<Analog>(nameof(Analog));
        set => SetAssoc1To1(nameof(Analog), value);
    }
}