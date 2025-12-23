using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Ошиновка.
/// </summary>
[CimClass(ClassUri)]
public partial class BusArrangement(IOIDDescriptor oid, ICimMetaClass metaClass)
    : AuxiliaryEquipment(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#BusArrangement";
}