using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Гидроэлектростанция.
/// </summary>
[CimClass(ClassUri)]
public partial class HydroPowerPlant(IOIDDescriptor oid, ICimMetaClass metaClass)
    : PowerSystemResource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#HydroPowerPlant";

    /// <summary>
    /// Установленная мощность гидроэлектростанции при номинальном напоре, МВт.
    /// </summary>
    public float? genRatedP
    {
        get => GetAttribute<float?>(nameof(genRatedP));
        set => SetAttribute(nameof(genRatedP), value);
    }

    /// <summary>
    /// Тип гидроэлектростанции.
    /// </summary>
    public HydroPlantStorageKind? hydroPlantStorageType
    {
        get => GetAttribute<HydroPlantStorageKind?>(nameof(hydroPlantStorageType));
        set => SetAttribute(nameof(hydroPlantStorageType), value);
    }


    /// <summary>
    /// Гидрогенераторы.
    /// </summary>
    public HydroGeneratingUnit[] HydroGeneratingUnits =>
        GetAssoc1ToM<HydroGeneratingUnit>(nameof(HydroGeneratingUnits));

    public void AddToHydroGeneratingUnits(HydroGeneratingUnit assocObject) =>
        AddAssoc1ToM(nameof(HydroGeneratingUnits), assocObject);

    public void RemoveFromHydroGeneratingUnits(HydroGeneratingUnit assocObject) =>
        RemoveAssoc1ToM(nameof(HydroGeneratingUnits), assocObject);

    public void RemoveAllFromHydroGeneratingUnits() => RemoveAllAssocs1ToM(nameof(HydroGeneratingUnits));
}