using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// P-Q диаграмма асинхронного генератора.
/// </summary>
[CimClass(ClassUri)]
public partial class AsynchronousMachineReactiveCapabilityCurve(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Curve(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#AsynchronousMachineReactiveCapabilityCurve";


    /// <summary>
    /// Технические параметры асинхронной машины, к которым привязана P-Q диаграмма асинхронной машины.
    /// </summary>
    public AsynchronousMachine[] AsynchronousMachine => GetAssoc1ToM<AsynchronousMachine>(nameof(AsynchronousMachine));

    public void AddToAsynchronousMachine(AsynchronousMachine assocObject) =>
        AddAssoc1ToM(nameof(AsynchronousMachine), assocObject);

    public void RemoveFromAsynchronousMachine(AsynchronousMachine assocObject) =>
        RemoveAssoc1ToM(nameof(AsynchronousMachine), assocObject);

    public void RemoveAllFromAsynchronousMachine() => RemoveAllAssocs1ToM(nameof(AsynchronousMachine));
}