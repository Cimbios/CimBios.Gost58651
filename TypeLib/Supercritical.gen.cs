using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Котел сверхкритического давления.
/// </summary>
[CimClass(ClassUri)]
public partial class Supercritical(IOIDDescriptor oid, ICimMetaClass metaClass)
    : FossilSteamSupply(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Supercritical";
}