using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Подстанция.
/// </summary>
[CimClass(ClassUri)]
public partial class Substation(IOIDDescriptor oid, ICimMetaClass metaClass)
    : EquipmentContainer(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Substation";


    /// <summary>
    /// Субъект Российской Федерации, на территории которого находится подстанция.
    /// </summary>
    public SubGeographicalRegion? Region
    {
        get => GetAssoc1To1<SubGeographicalRegion>(nameof(Region));
        set => SetAssoc1To1(nameof(Region), value);
    }

    /// <summary>
    /// Электростанция, к которой относится группа распределительных устройств.
    /// </summary>
    public Plant? Plant
    {
        get => GetAssoc1To1<Plant>(nameof(Plant));
        set => SetAssoc1To1(nameof(Plant), value);
    }

    /// <summary>
    /// Распределительные устройства, входящие в состав подстанции
    /// </summary>
    public VoltageLevel[] VoltageLevels => GetAssoc1ToM<VoltageLevel>(nameof(VoltageLevels));

    public void AddToVoltageLevels(VoltageLevel assocObject) => AddAssoc1ToM(nameof(VoltageLevels), assocObject);

    public void RemoveFromVoltageLevels(VoltageLevel assocObject) =>
        RemoveAssoc1ToM(nameof(VoltageLevels), assocObject);

    public void RemoveAllFromVoltageLevels() => RemoveAllAssocs1ToM(nameof(VoltageLevels));
}