using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Технические параметры управляемых устройств продольной компенсации реактивной мощности.
/// </summary>
[CimClass(ClassUri)]
public partial class SeriesVarCapacitorInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : SeriesCapacitorInfo(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#SeriesVarCapacitorInfo";

    /// <summary>
    /// Допустимая длительность форсировки устройства продольной компенсации, с.
    /// </summary>
    public float? boostMaxTime
    {
        get => GetAttribute<float?>(nameof(boostMaxTime));
        set => SetAttribute(nameof(boostMaxTime), value);
    }

    /// <summary>
    /// Мощность устройства продольной компенсации при форсировке, Мвар.
    /// </summary>
    public float? boostReactivePower
    {
        get => GetAttribute<float?>(nameof(boostReactivePower));
        set => SetAttribute(nameof(boostReactivePower), value);
    }

    /// <summary>
    /// Индуктивное сопротивление устройства продольной компенсации при форсировке, Ом.
    /// </summary>
    public float? boostX
    {
        get => GetAttribute<float?>(nameof(boostX));
        set => SetAttribute(nameof(boostX), value);
    }

    /// <summary>
    /// Уставка срабатывания по току схемы шунтирования, о.е.
    /// </summary>
    public float? bypassCurrentThreshold
    {
        get => GetAttribute<float?>(nameof(bypassCurrentThreshold));
        set => SetAttribute(nameof(bypassCurrentThreshold), value);
    }

    /// <summary>
    /// Максимальная реактивная мощность, Мвар.
    /// </summary>
    public float? maxReactivePower
    {
        get => GetAttribute<float?>(nameof(maxReactivePower));
        set => SetAttribute(nameof(maxReactivePower), value);
    }

    /// <summary>
    /// Минимальная реактивная мощность, Мвар.
    /// </summary>
    public float? minReactivePower
    {
        get => GetAttribute<float?>(nameof(minReactivePower));
        set => SetAttribute(nameof(minReactivePower), value);
    }

    /// <summary>
    /// Время изменения нагрузки между границами регулировочного диапазона, с.
    /// </summary>
    public float? ratedRegulatingTime
    {
        get => GetAttribute<float?>(nameof(ratedRegulatingTime));
        set => SetAttribute(nameof(ratedRegulatingTime), value);
    }
}