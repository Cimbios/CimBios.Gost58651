using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Базовый полюс постоянного тока.
/// </summary>
[CimClass(ClassUri)]
public partial class DCBaseTerminal(IOIDDescriptor oid, ICimMetaClass metaClass)
    : ACDCTerminal(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#DCBaseTerminal";
}