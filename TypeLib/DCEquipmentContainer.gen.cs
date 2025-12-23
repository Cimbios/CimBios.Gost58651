using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Контейнер оборудования постоянного тока.
/// </summary>
[CimClass(ClassUri)]
public partial class DCEquipmentContainer(IOIDDescriptor oid, ICimMetaClass metaClass)
    : EquipmentContainer(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#DCEquipmentContainer";
}