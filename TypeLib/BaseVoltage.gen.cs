using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Стандартное номинальное напряжение.
/// </summary>
[CimClass(ClassUri)]
public partial class BaseVoltage(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#BaseVoltage";

    /// <summary>
    /// Признак того, что значение номинального напряжения является напряжением постоянного тока.
    /// </summary>
    public bool? isDC
    {
        get => GetAttribute<bool?>(nameof(isDC));
        set => SetAttribute(nameof(isDC), value);
    }

    /// <summary>
    /// Значение номинального напряжения, кВ.
    /// </summary>
    public float? nominalVoltage
    {
        get => GetAttribute<float?>(nameof(nominalVoltage));
        set => SetAttribute(nameof(nominalVoltage), value);
    }


    /// <summary>
    /// Электропроводящее оборудование, относящееся к стандартному номинальному напряжению.
    /// </summary>
    public ConductingEquipment[] ConductingEquipment => GetAssoc1ToM<ConductingEquipment>(nameof(ConductingEquipment));

    public void AddToConductingEquipment(ConductingEquipment assocObject) =>
        AddAssoc1ToM(nameof(ConductingEquipment), assocObject);

    public void RemoveFromConductingEquipment(ConductingEquipment assocObject) =>
        RemoveAssoc1ToM(nameof(ConductingEquipment), assocObject);

    public void RemoveAllFromConductingEquipment() => RemoveAllAssocs1ToM(nameof(ConductingEquipment));

    /// <summary>
    /// Распределительные устройства, относящиеся к стандартному номинальному напряжению.
    /// </summary>
    public VoltageLevel[] VoltageLevel => GetAssoc1ToM<VoltageLevel>(nameof(VoltageLevel));

    public void AddToVoltageLevel(VoltageLevel assocObject) => AddAssoc1ToM(nameof(VoltageLevel), assocObject);
    public void RemoveFromVoltageLevel(VoltageLevel assocObject) => RemoveAssoc1ToM(nameof(VoltageLevel), assocObject);
    public void RemoveAllFromVoltageLevel() => RemoveAllAssocs1ToM(nameof(VoltageLevel));

    /// <summary>
    /// Материальные объекты, внедряемые на номинальном напряжении.
    /// </summary>
    public AssetDeployment[] NetworkAssetDeployment => GetAssoc1ToM<AssetDeployment>(nameof(NetworkAssetDeployment));

    public void AddToNetworkAssetDeployment(AssetDeployment assocObject) =>
        AddAssoc1ToM(nameof(NetworkAssetDeployment), assocObject);

    public void RemoveFromNetworkAssetDeployment(AssetDeployment assocObject) =>
        RemoveAssoc1ToM(nameof(NetworkAssetDeployment), assocObject);

    public void RemoveAllFromNetworkAssetDeployment() => RemoveAllAssocs1ToM(nameof(NetworkAssetDeployment));

    /// <summary>
    /// Вводы трансформатора, относящиеся к стандартному номинальному напряжению.
    /// </summary>
    public TransformerEnd[] TransformerEnds => GetAssoc1ToM<TransformerEnd>(nameof(TransformerEnds));

    public void AddToTransformerEnds(TransformerEnd assocObject) => AddAssoc1ToM(nameof(TransformerEnds), assocObject);

    public void RemoveFromTransformerEnds(TransformerEnd assocObject) =>
        RemoveAssoc1ToM(nameof(TransformerEnds), assocObject);

    public void RemoveAllFromTransformerEnds() => RemoveAllAssocs1ToM(nameof(TransformerEnds));
}