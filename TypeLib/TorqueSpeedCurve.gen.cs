using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Моментно-скоростная характеристика.
/// </summary>
[CimClass(ClassUri)]
public partial class TorqueSpeedCurve(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Curve(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#TorqueSpeedCurve";


    /// <summary>
    /// Асинхронная машина, к которой относится моментно-скоростная характеристика.
    /// </summary>
    public AsynchronousMachine[] AsynchronousMachine => GetAssoc1ToM<AsynchronousMachine>(nameof(AsynchronousMachine));

    public void AddToAsynchronousMachine(AsynchronousMachine assocObject) =>
        AddAssoc1ToM(nameof(AsynchronousMachine), assocObject);

    public void RemoveFromAsynchronousMachine(AsynchronousMachine assocObject) =>
        RemoveAssoc1ToM(nameof(AsynchronousMachine), assocObject);

    public void RemoveAllFromAsynchronousMachine() => RemoveAllAssocs1ToM(nameof(AsynchronousMachine));
}