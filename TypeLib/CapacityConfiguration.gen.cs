using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Параметры парового энергоблока в составе парогазовой установки при различном составе газотурбинных установок.
/// </summary>
[CimClass(ClassUri)]
public partial class CapacityConfiguration(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#CapacityConfiguration";

    /// <summary>
    /// Максимальная располагаемая мощность, МВт.
    /// </summary>
    public float? maximumCapacity
    {
        get => GetAttribute<float?>(nameof(maximumCapacity));
        set => SetAttribute(nameof(maximumCapacity), value);
    }

    /// <summary>
    /// Группа генерирующих установок с комбинированным циклом (парогазовая установка).
    /// </summary>
    public CombinedCyclePlant? CombinedCyclePlant
    {
        get => GetAssoc1To1<CombinedCyclePlant>(nameof(CombinedCyclePlant));
        set => SetAssoc1To1(nameof(CombinedCyclePlant), value);
    }

    /// <summary>
    /// Газотурбинные энергоблоки.
    /// </summary>
    public ThermalGeneratingUnit[] ThermalGeneratingUnits =>
        GetAssoc1ToM<ThermalGeneratingUnit>(nameof(ThermalGeneratingUnits));

    public void AddToThermalGeneratingUnits(ThermalGeneratingUnit assocObject) =>
        AddAssoc1ToM(nameof(ThermalGeneratingUnits), assocObject);

    public void RemoveFromThermalGeneratingUnits(ThermalGeneratingUnit assocObject) =>
        RemoveAssoc1ToM(nameof(ThermalGeneratingUnits), assocObject);

    public void RemoveAllFromThermalGeneratingUnits() => RemoveAllAssocs1ToM(nameof(ThermalGeneratingUnits));
}