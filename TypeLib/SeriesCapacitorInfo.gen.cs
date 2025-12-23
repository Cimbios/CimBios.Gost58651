using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Технические параметры устройств продольной компенсации реактивной мощности.
/// </summary>
[CimClass(ClassUri)]
public partial class SeriesCapacitorInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : SeriesCompensatorInfo(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#SeriesCapacitorInfo";

    /// <summary>
    /// Количество последовательно соединенных конденсаторов.
    /// </summary>
    public int? capacitorsInChainCount
    {
        get => GetAttribute<int?>(nameof(capacitorsInChainCount));
        set => SetAttribute(nameof(capacitorsInChainCount), value);
    }

    /// <summary>
    /// Тип последовательно соединенных конденсаторов.
    /// </summary>
    public string? capacitorsInChainType
    {
        get => GetAttribute<string?>(nameof(capacitorsInChainType));
        set => SetAttribute(nameof(capacitorsInChainType), value);
    }

    /// <summary>
    /// Количество параллельных конденсаторных цепочек.
    /// </summary>
    public int? chainCapacitorsCount
    {
        get => GetAttribute<int?>(nameof(chainCapacitorsCount));
        set => SetAttribute(nameof(chainCapacitorsCount), value);
    }

    /// <summary>
    /// Емкость, Ф.
    /// </summary>
    public float? ratedCapacitance
    {
        get => GetAttribute<float?>(nameof(ratedCapacitance));
        set => SetAttribute(nameof(ratedCapacitance), value);
    }
}