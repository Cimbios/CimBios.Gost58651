using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Измерительное устройство.
/// </summary>
[CimClass(ClassUri)]
public partial class Sensor(IOIDDescriptor oid, ICimMetaClass metaClass)
    : AuxiliaryEquipment(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Sensor";
}