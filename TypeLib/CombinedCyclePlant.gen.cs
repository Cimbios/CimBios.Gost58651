using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Группа генерирующих установок с комбинированным циклом (парогазовая установка).
/// </summary>
[CimClass(ClassUri)]
public partial class CombinedCyclePlant(IOIDDescriptor oid, ICimMetaClass metaClass)
    : PowerSystemResource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#CombinedCyclePlant";

    /// <summary>
    /// Установленная мощность группы генерирующих установок с комбинированным циклом, МВт.
    /// </summary>
    public float? combCyclePlantRating
    {
        get => GetAttribute<float?>(nameof(combCyclePlantRating));
        set => SetAttribute(nameof(combCyclePlantRating), value);
    }


    /// <summary>
    /// Тепловые энергоблоки, входящие в группу генерирующих установок с комбинированным циклом.
    /// </summary>
    public ThermalGeneratingUnit[] ThermalGeneratingUnits =>
        GetAssoc1ToM<ThermalGeneratingUnit>(nameof(ThermalGeneratingUnits));

    public void AddToThermalGeneratingUnits(ThermalGeneratingUnit assocObject) =>
        AddAssoc1ToM(nameof(ThermalGeneratingUnits), assocObject);

    public void RemoveFromThermalGeneratingUnits(ThermalGeneratingUnit assocObject) =>
        RemoveAssoc1ToM(nameof(ThermalGeneratingUnits), assocObject);

    public void RemoveAllFromThermalGeneratingUnits() => RemoveAllAssocs1ToM(nameof(ThermalGeneratingUnits));

    /// <summary>
    /// Параметры парового энергоблока в составе парогазовой установки при различном составе газотурбинных установок.
    /// </summary>
    public CapacityConfiguration[] CapacityConfiguration =>
        GetAssoc1ToM<CapacityConfiguration>(nameof(CapacityConfiguration));

    public void AddToCapacityConfiguration(CapacityConfiguration assocObject) =>
        AddAssoc1ToM(nameof(CapacityConfiguration), assocObject);

    public void RemoveFromCapacityConfiguration(CapacityConfiguration assocObject) =>
        RemoveAssoc1ToM(nameof(CapacityConfiguration), assocObject);

    public void RemoveAllFromCapacityConfiguration() => RemoveAllAssocs1ToM(nameof(CapacityConfiguration));
}