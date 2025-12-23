using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Энергоблок.
/// </summary>
[CimClass(ClassUri)]
public partial class GeneratingUnit(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Equipment(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#GeneratingUnit";

    /// <summary>
    /// Статизм регулятора скорости, %.
    /// </summary>
    public float? governorSCD
    {
        get => GetAttribute<float?>(nameof(governorSCD));
        set => SetAttribute(nameof(governorSCD), value);
    }

    /// <summary>
    /// Верхний предел автоматического регулирования, МВт.
    /// </summary>
    public float? highControlLimit
    {
        get => GetAttribute<float?>(nameof(highControlLimit));
        set => SetAttribute(nameof(highControlLimit), value);
    }

    /// <summary>
    /// Нижний предел автоматического регулирования, МВт.
    /// </summary>
    public float? lowControlLimit
    {
        get => GetAttribute<float?>(nameof(lowControlLimit));
        set => SetAttribute(nameof(lowControlLimit), value);
    }

    /// <summary>
    /// Скорость снижения мощности турбины, МВт/с.
    /// </summary>
    public float? lowerRampRate
    {
        get => GetAttribute<float?>(nameof(lowerRampRate));
        set => SetAttribute(nameof(lowerRampRate), value);
    }

    /// <summary>
    /// Технологический максимум, МВт.
    /// </summary>
    public float? maxOperatingP
    {
        get => GetAttribute<float?>(nameof(maxOperatingP));
        set => SetAttribute(nameof(maxOperatingP), value);
    }

    /// <summary>
    /// Технологический минимум, МВт.
    /// </summary>
    public float? minOperatingP
    {
        get => GetAttribute<float?>(nameof(minOperatingP));
        set => SetAttribute(nameof(minOperatingP), value);
    }

    /// <summary>
    /// Номинальная активная мощность энергоблока, МВт.
    /// </summary>
    public float? nominalP
    {
        get => GetAttribute<float?>(nameof(nominalP));
        set => SetAttribute(nameof(nominalP), value);
    }

    /// <summary>
    /// Скорость увеличения мощности энергоблока, МВт/с.
    /// </summary>
    public float? raiseRampRate
    {
        get => GetAttribute<float?>(nameof(raiseRampRate));
        set => SetAttribute(nameof(raiseRampRate), value);
    }

    /// <summary>
    /// Маховой момент агрегата (турбина и генератор), т &#183; м<sup>2</sup>.
    /// </summary>
    public float? unitGD2
    {
        get => GetAttribute<float?>(nameof(unitGD2));
        set => SetAttribute(nameof(unitGD2), value);
    }

    /// <summary>
    /// Генераторы, входящие в состав  энергоблока.
    /// </summary>
    public RotatingMachine? RotatingMachine
    {
        get => GetAssoc1To1<RotatingMachine>(nameof(RotatingMachine));
        set => SetAssoc1To1(nameof(RotatingMachine), value);
    }
}