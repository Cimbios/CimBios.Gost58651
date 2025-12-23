using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Технические параметры устройств продольной компенсации.
/// </summary>
[CimClass(ClassUri)]
public partial class SeriesCompensatorInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : AssetInfo(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#SeriesCompensatorInfo";

    /// <summary>
    /// Потери активной мощности при номинальном напряжении, кВт.
    /// </summary>
    public float? loss
    {
        get => GetAttribute<float?>(nameof(loss));
        set => SetAttribute(nameof(loss), value);
    }

    /// <summary>
    /// Наибольшее рабочее напряжение, кВ.
    /// </summary>
    public float? maxVoltage
    {
        get => GetAttribute<float?>(nameof(maxVoltage));
        set => SetAttribute(nameof(maxVoltage), value);
    }

    /// <summary>
    /// Номинальный ток, А.
    /// </summary>
    public float? ratedCurrent
    {
        get => GetAttribute<float?>(nameof(ratedCurrent));
        set => SetAttribute(nameof(ratedCurrent), value);
    }

    /// <summary>
    /// Номинальная реактивная мощность, Мвар.
    /// </summary>
    public float? ratedReactivePower
    {
        get => GetAttribute<float?>(nameof(ratedReactivePower));
        set => SetAttribute(nameof(ratedReactivePower), value);
    }

    /// <summary>
    /// Номинальное напряжение, кВ.
    /// </summary>
    public float? ratedVoltage
    {
        get => GetAttribute<float?>(nameof(ratedVoltage));
        set => SetAttribute(nameof(ratedVoltage), value);
    }
}