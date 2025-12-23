using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Гидрогенератор.
/// </summary>
[CimClass(ClassUri)]
public partial class HydroGeneratingUnit(IOIDDescriptor oid, ICimMetaClass metaClass)
    : GeneratingUnit(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#HydroGeneratingUnit";

    /// <summary>
    /// Режимы работы, в которых гидроагрегат способен работать.
    /// </summary>
    public HydroEnergyConversionKind? energyConversionCapability
    {
        get => GetAttribute<HydroEnergyConversionKind?>(nameof(energyConversionCapability));
        set => SetAttribute(nameof(energyConversionCapability), value);
    }

    /// <summary>
    /// Расход воды через турбину при выдаче номинальной мощности гидроагрегата и расчетном напоре, м<sup>3</sup>/с.
    /// </summary>
    public float? normalWaterFlow
    {
        get => GetAttribute<float?>(nameof(normalWaterFlow));
        set => SetAttribute(nameof(normalWaterFlow), value);
    }

    /// <summary>
    /// Расчетный напор гидроагрегата, м.
    /// </summary>
    public float? normalWaterLevel
    {
        get => GetAttribute<float?>(nameof(normalWaterLevel));
        set => SetAttribute(nameof(normalWaterLevel), value);
    }

    /// <summary>
    /// Гидроэлектростанция.
    /// </summary>
    public HydroPowerPlant? HydroPowerPlant
    {
        get => GetAssoc1To1<HydroPowerPlant>(nameof(HydroPowerPlant));
        set => SetAssoc1To1(nameof(HydroPowerPlant), value);
    }
}