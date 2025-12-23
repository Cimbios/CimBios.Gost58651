using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Зависимость допустимой длительности значения напряжения от его диапазона.
/// </summary>
[CimClass(ClassUri)]
public partial class VoltageLimitDurationCurve(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Curve(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#VoltageLimitDurationCurve";


    /// <summary>
    /// Оборудование, для которого заданы допустимая длительность значения напряжения в зависимости от его диапазона.
    /// </summary>
    public Equipment[] Equipments => GetAssoc1ToM<Equipment>(nameof(Equipments));

    public void AddToEquipments(Equipment assocObject) => AddAssoc1ToM(nameof(Equipments), assocObject);
    public void RemoveFromEquipments(Equipment assocObject) => RemoveAssoc1ToM(nameof(Equipments), assocObject);
    public void RemoveAllFromEquipments() => RemoveAllAssocs1ToM(nameof(Equipments));
}