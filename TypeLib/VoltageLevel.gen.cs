using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Распределительное устройство.
/// </summary>
[CimClass(ClassUri)]
public partial class VoltageLevel(IOIDDescriptor oid, ICimMetaClass metaClass)
    : EquipmentContainer(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#VoltageLevel";


    /// <summary>
    /// Стандартное номинальное напряжение распределительного устройства.
    /// </summary>
    public BaseVoltage? BaseVoltage
    {
        get => GetAssoc1To1<BaseVoltage>(nameof(BaseVoltage));
        set => SetAssoc1To1(nameof(BaseVoltage), value);
    }

    /// <summary>
    /// Подстанция, в состав которой входит  распределительное устройство.
    /// </summary>
    public Substation? Substation
    {
        get => GetAssoc1To1<Substation>(nameof(Substation));
        set => SetAssoc1To1(nameof(Substation), value);
    }

    /// <summary>
    /// Присоединения распределительного устройства.
    /// </summary>
    public Bay[] Bays => GetAssoc1ToM<Bay>(nameof(Bays));

    public void AddToBays(Bay assocObject) => AddAssoc1ToM(nameof(Bays), assocObject);
    public void RemoveFromBays(Bay assocObject) => RemoveAssoc1ToM(nameof(Bays), assocObject);
    public void RemoveAllFromBays() => RemoveAllAssocs1ToM(nameof(Bays));
}