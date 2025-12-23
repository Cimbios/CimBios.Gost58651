using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Нелинейное шунтирующее компенсирующее устройство.
/// </summary>
[CimClass(ClassUri)]
public partial class NonlinearShuntCompensator(IOIDDescriptor oid, ICimMetaClass metaClass)
    : ShuntCompensator(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#NonlinearShuntCompensator";
}