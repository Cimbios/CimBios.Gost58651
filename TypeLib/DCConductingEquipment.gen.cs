using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Электропроводящее оборудование постоянного тока.
/// </summary>
[CimClass(ClassUri)]
public partial class DCConductingEquipment(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Equipment(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#DCConductingEquipment";


    /// <summary>
    /// Полюса электропроводящего оборудования постоянного тока.
    /// </summary>
    public DCTerminal[] DCTerminals => GetAssoc1ToM<DCTerminal>(nameof(DCTerminals));

    public void AddToDCTerminals(DCTerminal assocObject) => AddAssoc1ToM(nameof(DCTerminals), assocObject);
    public void RemoveFromDCTerminals(DCTerminal assocObject) => RemoveAssoc1ToM(nameof(DCTerminals), assocObject);
    public void RemoveAllFromDCTerminals() => RemoveAllAssocs1ToM(nameof(DCTerminals));
}