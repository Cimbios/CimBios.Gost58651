using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Электростанция.
/// </summary>
[CimClass(ClassUri)]
public partial class Plant(IOIDDescriptor oid, ICimMetaClass metaClass)
    : EquipmentContainer(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Plant";

    /// <summary>
    /// Установленная мощность электростанции, МВт.
    /// </summary>
    public float? ratedP
    {
        get => GetAttribute<float?>(nameof(ratedP));
        set => SetAttribute(nameof(ratedP), value);
    }

    /// <summary>
    /// Субъект Российской Федерации, на территории которого находится электростанция.
    /// </summary>
    public SubGeographicalRegion? Region
    {
        get => GetAssoc1To1<SubGeographicalRegion>(nameof(Region));
        set => SetAssoc1To1(nameof(Region), value);
    }

    /// <summary>
    /// Группы распределительных устройств электростанции.
    /// </summary>
    public Substation[] Substations => GetAssoc1ToM<Substation>(nameof(Substations));

    public void AddToSubstations(Substation assocObject) => AddAssoc1ToM(nameof(Substations), assocObject);
    public void RemoveFromSubstations(Substation assocObject) => RemoveAssoc1ToM(nameof(Substations), assocObject);
    public void RemoveAllFromSubstations() => RemoveAllAssocs1ToM(nameof(Substations));
}