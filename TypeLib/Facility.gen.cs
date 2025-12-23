using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Производственный объект, содержащий другие производственные объекты (строения, коммутирующие, генерирующие устройства, обслуживаемые устройства).
/// </summary>
[CimClass(ClassUri)]
public partial class Facility(IOIDDescriptor oid, ICimMetaClass metaClass)
    : AssetContainer(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Facility";
}