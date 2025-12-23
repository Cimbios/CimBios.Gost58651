using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Система географических координат.
/// </summary>
[CimClass(ClassUri)]
public partial class CoordinateSystem(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#CoordinateSystem";

    /// <summary>
    /// Тип координатной системы в форме унифицированного имени ресурса - URN.
    /// </summary>
    public string? crsUrn
    {
        get => GetAttribute<string?>(nameof(crsUrn));
        set => SetAttribute(nameof(crsUrn), value);
    }


    /// <summary>
    /// Расположения объекта энергосистемы в данной системе координат.
    /// </summary>
    public Location[] Locations => GetAssoc1ToM<Location>(nameof(Locations));

    public void AddToLocations(Location assocObject) => AddAssoc1ToM(nameof(Locations), assocObject);
    public void RemoveFromLocations(Location assocObject) => RemoveAssoc1ToM(nameof(Locations), assocObject);
    public void RemoveAllFromLocations() => RemoveAllAssocs1ToM(nameof(Locations));
}