using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Полюс постоянного тока.
/// </summary>
[CimClass(ClassUri)]
public partial class DCTerminal(IOIDDescriptor oid, ICimMetaClass metaClass)
    : DCBaseTerminal(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#DCTerminal";


    /// <summary>
    /// Электропроводящее оборудование постоянного тока данного полюса.
    /// </summary>
    public DCConductingEquipment? DCConductingEquipment
    {
        get => GetAssoc1To1<DCConductingEquipment>(nameof(DCConductingEquipment));
        set => SetAssoc1To1(nameof(DCConductingEquipment), value);
    }
}