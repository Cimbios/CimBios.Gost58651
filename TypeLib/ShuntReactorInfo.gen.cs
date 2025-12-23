using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Технические параметры шунтирующих реакторов.
/// </summary>
[CimClass(ClassUri)]
public partial class ShuntReactorInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : ShuntCompensatorInfo(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#ShuntReactorInfo";

    /// <summary>
    /// Энергоемкость резистора в нейтральном выводе, Дж.
    /// </summary>
    public float? groundResistorEnergy
    {
        get => GetAttribute<float?>(nameof(groundResistorEnergy));
        set => SetAttribute(nameof(groundResistorEnergy), value);
    }

    /// <summary>
    /// Сопротивление резистора в нейтральном выводе, Ом.
    /// </summary>
    public float? neutralResistance
    {
        get => GetAttribute<float?>(nameof(neutralResistance));
        set => SetAttribute(nameof(neutralResistance), value);
    }

    /// <summary>
    /// Длительность нахождения резистора в нейтральном выводе в цепи, с.
    /// </summary>
    public float? neutralResistanceTime
    {
        get => GetAttribute<float?>(nameof(neutralResistanceTime));
        set => SetAttribute(nameof(neutralResistanceTime), value);
    }

    /// <summary>
    /// Допустимое напряжение изоляции нулевых выводов, кВ.
    /// </summary>
    public float? ratedNeutralInsulationVoltage
    {
        get => GetAttribute<float?>(nameof(ratedNeutralInsulationVoltage));
        set => SetAttribute(nameof(ratedNeutralInsulationVoltage), value);
    }

    /// <summary>
    /// Номинальное напряжение нулевых выводов, кВ.
    /// </summary>
    public float? ratedNeutralVoltage
    {
        get => GetAttribute<float?>(nameof(ratedNeutralVoltage));
        set => SetAttribute(nameof(ratedNeutralVoltage), value);
    }
}