using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Технические параметры батареи статических конденсаторов.
/// </summary>
[CimClass(ClassUri)]
public partial class ShuntCapacitorInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : ShuntCompensatorInfo(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#ShuntCapacitorInfo";

    /// <summary>
    /// Количество последовательно соединенных конденсаторов батареи статических компенсаторов.
    /// </summary>
    public int? capacitorsInChainCount
    {
        get => GetAttribute<int?>(nameof(capacitorsInChainCount));
        set => SetAttribute(nameof(capacitorsInChainCount), value);
    }

    /// <summary>
    /// Тип последовательно соединенных конденсаторов батареи статических компенсаторов.
    /// </summary>
    public string? capacitorsInChainType
    {
        get => GetAttribute<string?>(nameof(capacitorsInChainType));
        set => SetAttribute(nameof(capacitorsInChainType), value);
    }

    /// <summary>
    /// Количество параллельных конденсаторных цепочек батареи статических компенсаторов.
    /// </summary>
    public int? chainCapacitorsCount
    {
        get => GetAttribute<int?>(nameof(chainCapacitorsCount));
        set => SetAttribute(nameof(chainCapacitorsCount), value);
    }
}