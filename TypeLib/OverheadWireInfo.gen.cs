using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Технические параметры проводников воздушной ЛЭП.
/// </summary>
[CimClass(ClassUri)]
public partial class OverheadWireInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : WireInfo(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#OverheadWireInfo";
}