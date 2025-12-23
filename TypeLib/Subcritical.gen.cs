using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Котел высокого давления.
/// </summary>
[CimClass(ClassUri)]
public partial class Subcritical(IOIDDescriptor oid, ICimMetaClass metaClass)
    : FossilSteamSupply(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Subcritical";
}