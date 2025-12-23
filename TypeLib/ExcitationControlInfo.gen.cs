using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Технические параметры автоматического регулятора возбуждения.
/// </summary>
[CimClass(ClassUri)]
public partial class ExcitationControlInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : AssetInfo(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#ExcitationControlInfo";

    /// <summary>
    /// Версия программного обеспечения алгоритма автоматического регулятора возбуждения.
    /// </summary>
    public string? algorithmVersion
    {
        get => GetAttribute<string?>(nameof(algorithmVersion));
        set => SetAttribute(nameof(algorithmVersion), value);
    }

    /// <summary>
    /// Коэффициент усиления по току статора для высокочастотных систем с компаундированием по току статора.
    /// </summary>
    public float? currentGainFactor
    {
        get => GetAttribute<float?>(nameof(currentGainFactor));
        set => SetAttribute(nameof(currentGainFactor), value);
    }

    /// <summary>
    /// Установленный коэффициент усиления по отклонению частоты напряжения.
    /// </summary>
    public float? frequencyGainFactor
    {
        get => GetAttribute<float?>(nameof(frequencyGainFactor));
        set => SetAttribute(nameof(frequencyGainFactor), value);
    }

    /// <summary>
    /// Установленный коэффициент усиления по производной частоты напряжения.
    /// </summary>
    public float? frequencyGainFactorDerivative
    {
        get => GetAttribute<float?>(nameof(frequencyGainFactorDerivative));
        set => SetAttribute(nameof(frequencyGainFactorDerivative), value);
    }

    /// <summary>
    /// Максимальный коэффициент усиления по отклонению частоты напряжения.
    /// </summary>
    public float? frequencyMaxGainFactor
    {
        get => GetAttribute<float?>(nameof(frequencyMaxGainFactor));
        set => SetAttribute(nameof(frequencyMaxGainFactor), value);
    }

    /// <summary>
    /// Максимальный коэффициент усиления по производной частоты напряжения.
    /// </summary>
    public float? frequencyMaxGainFactorDerivative
    {
        get => GetAttribute<float?>(nameof(frequencyMaxGainFactorDerivative));
        set => SetAttribute(nameof(frequencyMaxGainFactorDerivative), value);
    }

    /// <summary>
    /// Постоянная времени интегратора пропорционально-интегрально-дифференциального канала регулятора возбуждения в режиме автоматического регулирования напряжения, с.
    /// </summary>
    public float? piTimeConstant
    {
        get => GetAttribute<float?>(nameof(piTimeConstant));
        set => SetAttribute(nameof(piTimeConstant), value);
    }

    /// <summary>
    /// Установленный коэффициент усиления по производной тока ротора.
    /// </summary>
    public int? rotorCurrentGainFactorDerivative
    {
        get => GetAttribute<int?>(nameof(rotorCurrentGainFactorDerivative));
        set => SetAttribute(nameof(rotorCurrentGainFactorDerivative), value);
    }

    /// <summary>
    /// Максимальный коэффициент усиления по производной тока ротора.
    /// </summary>
    public float? rotorCurrentMaxGainFactorDerivative
    {
        get => GetAttribute<float?>(nameof(rotorCurrentMaxGainFactorDerivative));
        set => SetAttribute(nameof(rotorCurrentMaxGainFactorDerivative), value);
    }

    /// <summary>
    /// Установленный коэффициент усиления по напряжению.
    /// </summary>
    public float? voltageGainFactor
    {
        get => GetAttribute<float?>(nameof(voltageGainFactor));
        set => SetAttribute(nameof(voltageGainFactor), value);
    }

    /// <summary>
    /// Установленный коэффициент усиления по производной напряжения.
    /// </summary>
    public float? voltageGainFactorDerivative
    {
        get => GetAttribute<float?>(nameof(voltageGainFactorDerivative));
        set => SetAttribute(nameof(voltageGainFactorDerivative), value);
    }

    /// <summary>
    /// Максимальный коэффициент усиления по напряжению.
    /// </summary>
    public float? voltageMaxGainFactor
    {
        get => GetAttribute<float?>(nameof(voltageMaxGainFactor));
        set => SetAttribute(nameof(voltageMaxGainFactor), value);
    }

    /// <summary>
    /// Максимальный коэффициент усиления по производной напряжения.
    /// </summary>
    public float? voltageMaxGainFactorDerivative
    {
        get => GetAttribute<float?>(nameof(voltageMaxGainFactorDerivative));
        set => SetAttribute(nameof(voltageMaxGainFactorDerivative), value);
    }
}