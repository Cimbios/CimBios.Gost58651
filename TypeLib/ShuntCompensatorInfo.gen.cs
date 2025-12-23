using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Технические параметры шунтирующих компенсирующих устройств.
/// </summary>
[CimClass(ClassUri)]
public partial class ShuntCompensatorInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : AssetInfo(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ShuntCompensatorInfo";

    /// <summary>
    /// Потери активной мощности ШР при номинальном напряжении, кВт.
    /// </summary>
    public float? loss
    {
        get => GetAttribute<float?>(nameof(loss));
        set => SetAttribute(nameof(loss), value);
    }

    /// <summary>
    /// Максимальные потери полной мощности, МВА.
    /// </summary>
    public float? maxPowerLoss
    {
        get => GetAttribute<float?>(nameof(maxPowerLoss));
        set => SetAttribute(nameof(maxPowerLoss), value);
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