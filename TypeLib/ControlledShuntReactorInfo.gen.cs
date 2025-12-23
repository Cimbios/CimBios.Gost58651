using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Технические параметры управляемых шунтирующих реакторов.
/// </summary>
[CimClass(ClassUri)]
public partial class ControlledShuntReactorInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : ShuntReactorInfo(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#ControlledShuntReactorInfo";

    /// <summary>
    /// Скорость изменения нагрузки с форсировкой, Мвар/с.
    /// </summary>
    public float? boostRegulatingSpeed
    {
        get => GetAttribute<float?>(nameof(boostRegulatingSpeed));
        set => SetAttribute(nameof(boostRegulatingSpeed), value);
    }

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
    /// Активное сопротивление прямой последовательности, Ом.
    /// </summary>
    public float? r
    {
        get => GetAttribute<float?>(nameof(r));
        set => SetAttribute(nameof(r), value);
    }

    /// <summary>
    /// Активное сопротивление нулевой последовательности, Ом.
    /// </summary>
    public float? r0
    {
        get => GetAttribute<float?>(nameof(r0));
        set => SetAttribute(nameof(r0), value);
    }

    /// <summary>
    /// Время изменения реактивной мощности между границами регулировочного диапазона, с.
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

    /// <summary>
    /// Напряжение короткого замыкания между сетевой обмоткой и компенсационной обмоткой, %.
    /// </summary>
    public float? shortCircuitVoltage
    {
        get => GetAttribute<float?>(nameof(shortCircuitVoltage));
        set => SetAttribute(nameof(shortCircuitVoltage), value);
    }

    /// <summary>
    /// Индуктивное сопротивление нулевой последовательности, Ом.
    /// </summary>
    public float? x0
    {
        get => GetAttribute<float?>(nameof(x0));
        set => SetAttribute(nameof(x0), value);
    }
}