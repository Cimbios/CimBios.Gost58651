using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Устройство на базе силовой электроники для включения в сеть солнечных модулей, ветряных энергоустановок.
/// </summary>
[CimClass(ClassUri)]
public partial class PowerElectronicsConnection(IOIDDescriptor oid, ICimMetaClass metaClass)
    : RegulatingCondEq(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PowerElectronicsConnection";

    /// <summary>
    /// Верхний предел по реактивной мощности преобразователя, Мвар.
    /// </summary>
    public float? maxQ
    {
        get => GetAttribute<float?>(nameof(maxQ));
        set => SetAttribute(nameof(maxQ), value);
    }

    /// <summary>
    /// Нижний предел по реактивной мощности преобразователя, Мвар.
    /// </summary>
    public float? minQ
    {
        get => GetAttribute<float?>(nameof(minQ));
        set => SetAttribute(nameof(minQ), value);
    }

    /// <summary>
    /// Номинальный коэффициент мощности.
    /// </summary>
    public float? ratedPowerFactor
    {
        get => GetAttribute<float?>(nameof(ratedPowerFactor));
        set => SetAttribute(nameof(ratedPowerFactor), value);
    }

    /// <summary>
    /// Номинальная полная мощность преобразователя, МВА.
    /// </summary>
    public float? ratedS
    {
        get => GetAttribute<float?>(nameof(ratedS));
        set => SetAttribute(nameof(ratedS), value);
    }

    /// <summary>
    /// Номинальное напряжение, кВ.
    /// </summary>
    public float? ratedU
    {
        get => GetAttribute<float?>(nameof(ratedU));
        set => SetAttribute(nameof(ratedU), value);
    }

    /// <summary>
    /// Тип (марка) преобразователя.
    /// </summary>
    public string? type
    {
        get => GetAttribute<string?>(nameof(type));
        set => SetAttribute(nameof(type), value);
    }

    /// <summary>
    /// P-Q диаграмма для устройств на базе силовой электроники.
    /// </summary>
    public PowerElectronicsReactiveCapabilityCurve? PowerElectronicsReactiveCapabilityCurve
    {
        get => GetAssoc1To1<PowerElectronicsReactiveCapabilityCurve>(nameof(PowerElectronicsReactiveCapabilityCurve));
        set => SetAssoc1To1(nameof(PowerElectronicsReactiveCapabilityCurve), value);
    }

    /// <summary>
    /// Генерирующие единицы, накопители или устройства, подключенные к сети переменного тока с использованием силовой электроники.
    /// </summary>
    public PowerElectronicsUnit[] PowerElectronicsUnit =>
        GetAssoc1ToM<PowerElectronicsUnit>(nameof(PowerElectronicsUnit));

    public void AddToPowerElectronicsUnit(PowerElectronicsUnit assocObject) =>
        AddAssoc1ToM(nameof(PowerElectronicsUnit), assocObject);

    public void RemoveFromPowerElectronicsUnit(PowerElectronicsUnit assocObject) =>
        RemoveAssoc1ToM(nameof(PowerElectronicsUnit), assocObject);

    public void RemoveAllFromPowerElectronicsUnit() => RemoveAllAssocs1ToM(nameof(PowerElectronicsUnit));
}