using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Технические параметры статических шунтирующих компенсирующих устройств.
/// </summary>
[CimClass(ClassUri)]
public partial class StaticVarCompensatorInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : ShuntCompensatorInfo(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#StaticVarCompensatorInfo";

    /// <summary>
    /// Максимальный статизм регулирования напряжения по реактивной мощности dU/dQ, кВ/Мвар.
    /// </summary>
    public float? maxSlope
    {
        get => GetAttribute<float?>(nameof(maxSlope));
        set => SetAttribute(nameof(maxSlope), value);
    }

    /// <summary>
    /// Минимальный статизм регулирования напряжения по реактивной мощности dU/dQ, кВ/Мвар.
    /// </summary>
    public float? minSlope
    {
        get => GetAttribute<float?>(nameof(minSlope));
        set => SetAttribute(nameof(minSlope), value);
    }

    /// <summary>
    /// Время изменения нагрузки между границами регулировочного диапазона, с.
    /// </summary>
    public float? ratedRegulatingTime
    {
        get => GetAttribute<float?>(nameof(ratedRegulatingTime));
        set => SetAttribute(nameof(ratedRegulatingTime), value);
    }

    /// <summary>
    /// Скорость изменения реактивной мощности, Мвар/с.
    /// </summary>
    public float? regulatingSpeed
    {
        get => GetAttribute<float?>(nameof(regulatingSpeed));
        set => SetAttribute(nameof(regulatingSpeed), value);
    }
}