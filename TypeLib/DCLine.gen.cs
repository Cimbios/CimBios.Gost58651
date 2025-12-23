using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Линия постоянного тока.
/// </summary>
[CimClass(ClassUri)]
public partial class DCLine(IOIDDescriptor oid, ICimMetaClass metaClass)
    : DCEquipmentContainer(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#DCLine";
}