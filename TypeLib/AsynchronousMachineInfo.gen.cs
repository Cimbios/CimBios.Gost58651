using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Технические параметры асинхронной машины.
/// </summary>
[CimClass(ClassUri)]
public partial class AsynchronousMachineInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : RotatingMachineInfo(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#AsynchronousMachineInfo";

    /// <summary>
    /// Максимальный момент, о.е.
    /// </summary>
    public float? maxTorque
    {
        get => GetAttribute<float?>(nameof(maxTorque));
        set => SetAttribute(nameof(maxTorque), value);
    }

    /// <summary>
    /// Пусковой ток, о.е.
    /// </summary>
    public float? startCurrent
    {
        get => GetAttribute<float?>(nameof(startCurrent));
        set => SetAttribute(nameof(startCurrent), value);
    }

    /// <summary>
    /// Пусковой момент, о.е.
    /// </summary>
    public float? startingTorque
    {
        get => GetAttribute<float?>(nameof(startingTorque));
        set => SetAttribute(nameof(startingTorque), value);
    }
}