using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Контейнер оборудования.
/// </summary>
[CimClass(ClassUri)]
public partial class EquipmentContainer(IOIDDescriptor oid, ICimMetaClass metaClass)
    : ConnectivityNodeContainer(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#EquipmentContainer";


    /// <summary>
    /// Единицы оборудования, относящиеся к контейнеру оборудования.
    /// </summary>
    public Equipment[] Equipments => GetAssoc1ToM<Equipment>(nameof(Equipments));

    public void AddToEquipments(Equipment assocObject) => AddAssoc1ToM(nameof(Equipments), assocObject);
    public void RemoveFromEquipments(Equipment assocObject) => RemoveAssoc1ToM(nameof(Equipments), assocObject);
    public void RemoveAllFromEquipments() => RemoveAllAssocs1ToM(nameof(Equipments));

    /// <summary>
    /// Единицы оборудования, имеющие дополнительную ассоциацию с контейнером оборудования.
    /// </summary>
    public Equipment[] AdditionalGroupedEquipment => GetAssoc1ToM<Equipment>(nameof(AdditionalGroupedEquipment));

    public void AddToAdditionalGroupedEquipment(Equipment assocObject) =>
        AddAssoc1ToM(nameof(AdditionalGroupedEquipment), assocObject);

    public void RemoveFromAdditionalGroupedEquipment(Equipment assocObject) =>
        RemoveAssoc1ToM(nameof(AdditionalGroupedEquipment), assocObject);

    public void RemoveAllFromAdditionalGroupedEquipment() => RemoveAllAssocs1ToM(nameof(AdditionalGroupedEquipment));
}