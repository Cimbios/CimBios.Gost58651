using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Полюс постоянного тока преобразователя постоянного тока.
/// </summary>
[CimClass(ClassUri)]
public partial class ACDCConverterDCTerminal(IOIDDescriptor oid, ICimMetaClass metaClass)
    : DCBaseTerminal(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ACDCConverterDCTerminal";
}