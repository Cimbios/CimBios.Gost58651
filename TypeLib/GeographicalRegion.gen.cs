using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Федеральный округ Российской Федерации.
/// </summary>
[CimClass(ClassUri)]
public partial class GeographicalRegion(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#GeographicalRegion";


    /// <summary>
    /// Субъекты Российской Федерации.
    /// </summary>
    public SubGeographicalRegion[] Regions => GetAssoc1ToM<SubGeographicalRegion>(nameof(Regions));

    public void AddToRegions(SubGeographicalRegion assocObject) => AddAssoc1ToM(nameof(Regions), assocObject);
    public void RemoveFromRegions(SubGeographicalRegion assocObject) => RemoveAssoc1ToM(nameof(Regions), assocObject);
    public void RemoveAllFromRegions() => RemoveAllAssocs1ToM(nameof(Regions));
}