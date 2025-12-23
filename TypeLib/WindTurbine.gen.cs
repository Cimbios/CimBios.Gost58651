using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Ветряная турбина.
/// </summary>
[CimClass(ClassUri)]
public partial class WindTurbine(IOIDDescriptor oid, ICimMetaClass metaClass)
    : PrimeMover(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#WindTurbine";
}