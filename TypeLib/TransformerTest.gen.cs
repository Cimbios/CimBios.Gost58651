using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Базовый класс для результатов испытания обмоток трансформатора.
/// </summary>
[CimClass(ClassUri)]
public partial class TransformerTest(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#TransformerTest";

    /// <summary>
    /// Базовая полная мощность, МВА.
    /// </summary>
    public float? basePower
    {
        get => GetAttribute<float?>(nameof(basePower));
        set => SetAttribute(nameof(basePower), value);
    }

    /// <summary>
    /// Температура, при которой проводился опыт, &#176;C.
    /// </summary>
    public float? temperature
    {
        get => GetAttribute<float?>(nameof(temperature));
        set => SetAttribute(nameof(temperature), value);
    }
}