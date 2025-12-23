using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Технические параметры синхронной машины.
/// </summary>
[CimClass(ClassUri)]
public partial class SynchronousMachineInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : RotatingMachineInfo(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#SynchronousMachineInfo";

    /// <summary>
    /// Допустимая продолжительность работы в асинхронном режиме, с.
    /// </summary>
    public float? asyncModeAllowedTime
    {
        get => GetAttribute<float?>(nameof(asyncModeAllowedTime));
        set => SetAttribute(nameof(asyncModeAllowedTime), value);
    }

    /// <summary>
    /// Суммарный маховый момент элементов, расположенных на одном валу с генератором (в том числе возбудитель, компрессор), не включая маховый момент турбины, т &#183; м<sup>2</sup>.
    /// </summary>
    public float? generatorGD2
    {
        get => GetAttribute<float?>(nameof(generatorGD2));
        set => SetAttribute(nameof(generatorGD2), value);
    }

    /// <summary>
    /// Допускается работа в асинхронном режиме (если присвоено значение &#171;Истина&#187;).
    /// </summary>
    public bool? isAsyncModeAdmissibility
    {
        get => GetAttribute<bool?>(nameof(isAsyncModeAdmissibility));
        set => SetAttribute(nameof(isAsyncModeAdmissibility), value);
    }

    /// <summary>
    /// Ток возбуждения в режиме максимальной нагрузки (при номинальных значениях U, f, cos ф), А.
    /// </summary>
    public float? maxLoadExcCurrent
    {
        get => GetAttribute<float?>(nameof(maxLoadExcCurrent));
        set => SetAttribute(nameof(maxLoadExcCurrent), value);
    }

    /// <summary>
    /// Напряжение возбуждения в режиме максимальной нагрузки (при номинальных значениях U, f, cos ф), В.
    /// </summary>
    public float? maxLoadExcVoltage
    {
        get => GetAttribute<float?>(nameof(maxLoadExcVoltage));
        set => SetAttribute(nameof(maxLoadExcVoltage), value);
    }

    /// <summary>
    /// Ток возбуждения в режиме холостого хода, А.
    /// </summary>
    public float? noLoadExcCurrent
    {
        get => GetAttribute<float?>(nameof(noLoadExcCurrent));
        set => SetAttribute(nameof(noLoadExcCurrent), value);
    }

    /// <summary>
    /// Напряжение возбуждения в режиме холостого хода, кВ.
    /// </summary>
    public float? noLoadExcVoltage
    {
        get => GetAttribute<float?>(nameof(noLoadExcVoltage));
        set => SetAttribute(nameof(noLoadExcVoltage), value);
    }

    /// <summary>
    /// Номинальная частота вращения, об/с.
    /// </summary>
    public float? nominalRotationSpeed
    {
        get => GetAttribute<float?>(nameof(nominalRotationSpeed));
        set => SetAttribute(nameof(nominalRotationSpeed), value);
    }

    /// <summary>
    /// Ток возбуждения в режиме номинальной нагрузки (при номинальных значениях U, f, cos ф), А.
    /// </summary>
    public float? ratedExcCurrent
    {
        get => GetAttribute<float?>(nameof(ratedExcCurrent));
        set => SetAttribute(nameof(ratedExcCurrent), value);
    }

    /// <summary>
    /// Напряжение возбуждения в режиме номинальной нагрузки (при номинальных значениях U, f, cos ф), В.
    /// </summary>
    public float? ratedExcVoltage
    {
        get => GetAttribute<float?>(nameof(ratedExcVoltage));
        set => SetAttribute(nameof(ratedExcVoltage), value);
    }

    /// <summary>
    /// Ток возбуждения при коротком замыкании, А.
    /// </summary>
    public float? shortCircuitExcCurrent
    {
        get => GetAttribute<float?>(nameof(shortCircuitExcCurrent));
        set => SetAttribute(nameof(shortCircuitExcCurrent), value);
    }
}