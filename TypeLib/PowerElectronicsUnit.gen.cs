using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Генерирующая единица, накопитель или устройство, подключенные к сети переменного тока с использованием силовой электроники.
/// </summary>
[CimClass(ClassUri)]
public partial class PowerElectronicsUnit(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Equipment(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PowerElectronicsUnit";

    /// <summary>
    /// &#171;Мертвая полоса&#187; первичного регулирования, Гц.
    /// </summary>
    public float? deadband
    {
        get => GetAttribute<float?>(nameof(deadband));
        set => SetAttribute(nameof(deadband), value);
    }

    /// <summary>
    /// Статизм первичного регулирования, %.
    /// </summary>
    public float? governorSCD
    {
        get => GetAttribute<float?>(nameof(governorSCD));
        set => SetAttribute(nameof(governorSCD), value);
    }

    /// <summary>
    /// Максимальная активная мощность преобразователя, МВт.
    /// </summary>
    public float? maxP
    {
        get => GetAttribute<float?>(nameof(maxP));
        set => SetAttribute(nameof(maxP), value);
    }

    /// <summary>
    /// Минимальная активная мощность преобразователя, МВт.
    /// </summary>
    public float? minP
    {
        get => GetAttribute<float?>(nameof(minP));
        set => SetAttribute(nameof(minP), value);
    }

    /// <summary>
    /// Устройство на базе силовой электроники для включения в сеть генерирующей единицы, накопителя или агрегата.
    /// </summary>
    public PowerElectronicsConnection? PowerElectronicsConnection
    {
        get => GetAssoc1To1<PowerElectronicsConnection>(nameof(PowerElectronicsConnection));
        set => SetAssoc1To1(nameof(PowerElectronicsConnection), value);
    }
}