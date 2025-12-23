using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Тепловой энергоблок.
/// </summary>
[CimClass(ClassUri)]
public partial class ThermalGeneratingUnit(IOIDDescriptor oid, ICimMetaClass metaClass)
    : GeneratingUnit(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ThermalGeneratingUnit";


    /// <summary>
    /// Группа генерирующих установок, предназначенных для выработки электроэнергии и технологического пара.
    /// </summary>
    public CogenerationPlant? CogenerationPlant
    {
        get => GetAssoc1To1<CogenerationPlant>(nameof(CogenerationPlant));
        set => SetAssoc1To1(nameof(CogenerationPlant), value);
    }

    /// <summary>
    /// Группа генерирующих установок с комбинированным циклом.
    /// </summary>
    public CombinedCyclePlant? CombinedCyclePlant
    {
        get => GetAssoc1To1<CombinedCyclePlant>(nameof(CombinedCyclePlant));
        set => SetAssoc1To1(nameof(CombinedCyclePlant), value);
    }

    /// <summary>
    /// Виды топлива, используемые тепловым энергоблоком.
    /// </summary>
    public FossilFuel[] FossilFuels => GetAssoc1ToM<FossilFuel>(nameof(FossilFuels));

    public void AddToFossilFuels(FossilFuel assocObject) => AddAssoc1ToM(nameof(FossilFuels), assocObject);
    public void RemoveFromFossilFuels(FossilFuel assocObject) => RemoveAssoc1ToM(nameof(FossilFuels), assocObject);
    public void RemoveAllFromFossilFuels() => RemoveAllAssocs1ToM(nameof(FossilFuels));

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