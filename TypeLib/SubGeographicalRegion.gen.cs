using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Субъект Российской Федерации.
/// </summary>
[CimClass(ClassUri)]
public partial class SubGeographicalRegion(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#SubGeographicalRegion";


    /// <summary>
    /// Географический регион, объединяющий субъекты Российской Федерации.
    /// </summary>
    public GeographicalRegion? Region
    {
        get => GetAssoc1To1<GeographicalRegion>(nameof(Region));
        set => SetAssoc1To1(nameof(Region), value);
    }

    /// <summary>
    /// Подстанции, находящиеся на территории субъекта Российской Федерации.
    /// </summary>
    public Substation[] Substations => GetAssoc1ToM<Substation>(nameof(Substations));

    public void AddToSubstations(Substation assocObject) => AddAssoc1ToM(nameof(Substations), assocObject);
    public void RemoveFromSubstations(Substation assocObject) => RemoveAssoc1ToM(nameof(Substations), assocObject);
    public void RemoveAllFromSubstations() => RemoveAllAssocs1ToM(nameof(Substations));

    /// <summary>
    /// Линии, проходящие по территории субъекта Российской Федерации.
    /// </summary>
    public Line[] Lines => GetAssoc1ToM<Line>(nameof(Lines));

    public void AddToLines(Line assocObject) => AddAssoc1ToM(nameof(Lines), assocObject);
    public void RemoveFromLines(Line assocObject) => RemoveAssoc1ToM(nameof(Lines), assocObject);
    public void RemoveAllFromLines() => RemoveAllAssocs1ToM(nameof(Lines));

    /// <summary>
    /// Электростанции, находящиеся на территории субъекта Российской Федерации.
    /// </summary>
    public Plant[] Plants => GetAssoc1ToM<Plant>(nameof(Plants));

    public void AddToPlants(Plant assocObject) => AddAssoc1ToM(nameof(Plants), assocObject);
    public void RemoveFromPlants(Plant assocObject) => RemoveAssoc1ToM(nameof(Plants), assocObject);
    public void RemoveAllFromPlants() => RemoveAllAssocs1ToM(nameof(Plants));
}