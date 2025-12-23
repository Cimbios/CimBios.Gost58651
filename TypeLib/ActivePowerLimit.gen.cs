using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Эксплуатационное ограничение/предел по активной мощности.
/// </summary>
[CimClass(ClassUri)]
public partial class ActivePowerLimit(IOIDDescriptor oid, ICimMetaClass metaClass)
    : OperationalLimit(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ActivePowerLimit";

    /// <summary>
    /// Нормальное значение эксплуатационного ограничения/предела по активной мощности, МВт.
    /// </summary>
    public float? normalValue
    {
        get => GetAttribute<float?>(nameof(normalValue));
        set => SetAttribute(nameof(normalValue), value);
    }

    /// <summary>
    /// Значение эксплуатационного ограничения/предела по активной мощности, МВт.
    /// </summary>
    public float? value
    {
        get => GetAttribute<float?>(nameof(value));
        set => SetAttribute(nameof(value), value);
    }
}