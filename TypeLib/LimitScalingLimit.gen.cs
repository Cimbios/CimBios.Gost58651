using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Пропорциональная зависимость значения одного эксплуатационного ограничения/предела от значения другого исходного эксплуатационного ограничения/предела.
/// </summary>
[CimClass(ClassUri)]
public partial class LimitScalingLimit(IOIDDescriptor oid, ICimMetaClass metaClass)
    : LimitDependency(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#LimitScalingLimit";

    /// <summary>
    /// Величина пропорциональной зависимости одного эксплуатационного ограничения/предела от исходного, %.
    /// </summary>
    public float? limitScalingPercent
    {
        get => GetAttribute<float?>(nameof(limitScalingPercent));
        set => SetAttribute(nameof(limitScalingPercent), value);
    }

    /// <summary>
    /// Исходный эксплуатационный предел, по отношению к которому определяется пропорциональная зависисимость.
    /// </summary>
    public OperationalLimit? SourceOperationalLimit
    {
        get => GetAssoc1To1<OperationalLimit>(nameof(SourceOperationalLimit));
        set => SetAssoc1To1(nameof(SourceOperationalLimit), value);
    }
}