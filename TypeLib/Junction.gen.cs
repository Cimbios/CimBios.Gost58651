using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Не отнесенный к шинам конструктив для глухого соединения полюсов электросилового оборудования.
/// </summary>
[CimClass(ClassUri)]
public partial class Junction(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Connector(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Junction";
}