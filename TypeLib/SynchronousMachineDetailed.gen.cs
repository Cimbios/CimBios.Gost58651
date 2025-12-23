using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Базовый класс для детализированных динамических параметров синхронных машин.
/// </summary>
[CimClass(ClassUri)]
public partial class SynchronousMachineDetailed(IOIDDescriptor oid, ICimMetaClass metaClass)
    : SynchronousMachineDynamics(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#SynchronousMachineDetailed";
}