using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Общие технические параметры коммутационных аппаратов.
/// </summary>
[CimClass(ClassUri)]
public partial class SwitchInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : AssetInfo(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#SwitchInfo";

    /// <summary>
    /// Номинальный ток отключения коммутационного аппарата, А.
    /// </summary>
    public float? breakingCapacity
    {
        get => GetAttribute<float?>(nameof(breakingCapacity));
        set => SetAttribute(nameof(breakingCapacity), value);
    }

    /// <summary>
    /// Если присвоено значение &#171;Истина&#187;, выключатель имеет пофазное исполнение.
    /// </summary>
    public bool? isSinglePhase
    {
        get => GetAttribute<bool?>(nameof(isSinglePhase));
        set => SetAttribute(nameof(isSinglePhase), value);
    }

    /// <summary>
    /// Если присвоено значение &#171;Истина&#187;, привод управления фазой независимый.
    /// </summary>
    public bool? isUnganged
    {
        get => GetAttribute<bool?>(nameof(isUnganged));
        set => SetAttribute(nameof(isUnganged), value);
    }

    /// <summary>
    /// Если присвоено значение &#171;Истина&#187;, есть возможность независимого управления фазой.
    /// </summary>
    public bool? isUngangedControl
    {
        get => GetAttribute<bool?>(nameof(isUngangedControl));
        set => SetAttribute(nameof(isUngangedControl), value);
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
    /// Собственное время отключения, с.
    /// </summary>
    public float? ratedInterruptingTime
    {
        get => GetAttribute<float?>(nameof(ratedInterruptingTime));
        set => SetAttribute(nameof(ratedInterruptingTime), value);
    }

    /// <summary>
    /// Собственное время включения, с.
    /// </summary>
    public float? ratedInTransitTime
    {
        get => GetAttribute<float?>(nameof(ratedInTransitTime));
        set => SetAttribute(nameof(ratedInTransitTime), value);
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