using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// P-Q диаграмма синхронной машины.
/// </summary>
[CimClass(ClassUri)]
public partial class ReactiveCapabilityCurve(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Curve(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ReactiveCapabilityCurve";


    /// <summary>
    /// Синхронные машины, для которых задана P-Q диаграмма по умолчанию.
    /// </summary>
    public SynchronousMachine[] InitiallyUsedBySynchronousMachines =>
        GetAssoc1ToM<SynchronousMachine>(nameof(InitiallyUsedBySynchronousMachines));

    public void AddToInitiallyUsedBySynchronousMachines(SynchronousMachine assocObject) =>
        AddAssoc1ToM(nameof(InitiallyUsedBySynchronousMachines), assocObject);

    public void RemoveFromInitiallyUsedBySynchronousMachines(SynchronousMachine assocObject) =>
        RemoveAssoc1ToM(nameof(InitiallyUsedBySynchronousMachines), assocObject);

    public void RemoveAllFromInitiallyUsedBySynchronousMachines() =>
        RemoveAllAssocs1ToM(nameof(InitiallyUsedBySynchronousMachines));

    /// <summary>
    /// Синхронные машины, для которых задана P-Q диаграмма.
    /// </summary>
    public SynchronousMachine[] SynchronousMachines => GetAssoc1ToM<SynchronousMachine>(nameof(SynchronousMachines));

    public void AddToSynchronousMachines(SynchronousMachine assocObject) =>
        AddAssoc1ToM(nameof(SynchronousMachines), assocObject);

    public void RemoveFromSynchronousMachines(SynchronousMachine assocObject) =>
        RemoveAssoc1ToM(nameof(SynchronousMachines), assocObject);

    public void RemoveAllFromSynchronousMachines() => RemoveAllAssocs1ToM(nameof(SynchronousMachines));
}