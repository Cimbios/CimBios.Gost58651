using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Тип объекта энергосистемы.
/// </summary>
[CimClass(ClassUri)]
public partial class PSRType(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PSRType";


    /// <summary>
    /// Энергообъекты с дополнительным классификатором.
    /// </summary>
    public PowerSystemResource[] PowerSystemResources =>
        GetAssoc1ToM<PowerSystemResource>(nameof(PowerSystemResources));

    public void AddToPowerSystemResources(PowerSystemResource assocObject) =>
        AddAssoc1ToM(nameof(PowerSystemResources), assocObject);

    public void RemoveFromPowerSystemResources(PowerSystemResource assocObject) =>
        RemoveAssoc1ToM(nameof(PowerSystemResources), assocObject);

    public void RemoveAllFromPowerSystemResources() => RemoveAllAssocs1ToM(nameof(PowerSystemResources));
}