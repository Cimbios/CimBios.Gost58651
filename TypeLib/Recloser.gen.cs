using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Секционирующий пункт.
/// </summary>
[CimClass(ClassUri)]
public partial class Recloser(IOIDDescriptor oid, ICimMetaClass metaClass)
    : ProtectedSwitch(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Recloser";
}