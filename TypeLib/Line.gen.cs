using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// ЛЭП.
/// </summary>
[CimClass(ClassUri)]
public partial class Line(IOIDDescriptor oid, ICimMetaClass metaClass)
    : EquipmentContainer(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Line";


    /// <summary>
    /// Субъекты Российской Федерации, по территории которых проходит ЛЭП.
    /// </summary>
    public SubGeographicalRegion[] Region => GetAssoc1ToM<SubGeographicalRegion>(nameof(Region));

    public void AddToRegion(SubGeographicalRegion assocObject) => AddAssoc1ToM(nameof(Region), assocObject);
    public void RemoveFromRegion(SubGeographicalRegion assocObject) => RemoveAssoc1ToM(nameof(Region), assocObject);
    public void RemoveAllFromRegion() => RemoveAllAssocs1ToM(nameof(Region));
}