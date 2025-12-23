using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Котел на ископаемом топливе.
/// </summary>
[CimClass(ClassUri)]
public partial class FossilSteamSupply(IOIDDescriptor oid, ICimMetaClass metaClass)
    : SteamSupply(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#FossilSteamSupply";
}