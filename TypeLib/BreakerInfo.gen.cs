using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Технические параметры выключателя.
/// </summary>
[CimClass(ClassUri)]
public partial class BreakerInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : OldSwitchInfo(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#BreakerInfo";

    /// <summary>
    /// Полное время отключения выключателя, с.
    /// </summary>
    public float? interruptingTime
    {
        get => GetAttribute<float?>(nameof(interruptingTime));
        set => SetAttribute(nameof(interruptingTime), value);
    }

    /// <summary>
    /// Нормированная бестоковая пауза при автоматическом повторном включении, с.
    /// </summary>
    public float? ratedRecloseTime
    {
        get => GetAttribute<float?>(nameof(ratedRecloseTime));
        set => SetAttribute(nameof(ratedRecloseTime), value);
    }
}