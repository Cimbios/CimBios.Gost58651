using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Органическое топливо.
/// </summary>
[CimClass(ClassUri)]
public partial class FossilFuel(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#FossilFuel";

    /// <summary>
    /// Вид органического топлива.
    /// </summary>
    public FuelType? fossilFuelType
    {
        get => GetAttribute<FuelType?>(nameof(fossilFuelType));
        set => SetAttribute(nameof(fossilFuelType), value);
    }

    /// <summary>
    /// КПД на данном типе топлива, о.е.
    /// </summary>
    public float? fuelEffFactor
    {
        get => GetAttribute<float?>(nameof(fuelEffFactor));
        set => SetAttribute(nameof(fuelEffFactor), value);
    }

    /// <summary>
    /// Количество теплоты на единицу веса или объема для данного вида топлива.
    /// </summary>
    public float? fuelHeatContent
    {
        get => GetAttribute<float?>(nameof(fuelHeatContent));
        set => SetAttribute(nameof(fuelHeatContent), value);
    }

    /// <summary>
    /// Тепловой энергоблок, использующий данный вид топлива.
    /// </summary>
    public ThermalGeneratingUnit? ThermalGeneratingUnit
    {
        get => GetAssoc1To1<ThermalGeneratingUnit>(nameof(ThermalGeneratingUnit));
        set => SetAssoc1To1(nameof(ThermalGeneratingUnit), value);
    }
}