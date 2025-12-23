using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Базовый класс для динамических параметров синхронных машин.
/// </summary>
[CimClass(ClassUri)]
public partial class SynchronousMachineDynamics(IOIDDescriptor oid, ICimMetaClass metaClass)
    : RotatingMachineDynamics(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#SynchronousMachineDynamics";


    /// <summary>
    /// Синхронная машина, к которой относятся динамические параметры.
    /// </summary>
    public SynchronousMachine? SynchronousMachine
    {
        get => GetAssoc1To1<SynchronousMachine>(nameof(SynchronousMachine));
        set => SetAssoc1To1(nameof(SynchronousMachine), value);
    }
}