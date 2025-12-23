using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Простая функция конечного устройства, отличающаяся &#171;видом&#187;.
/// </summary>
[CimClass(ClassUri)]
public partial class SimpleEndDeviceFunction(IOIDDescriptor oid, ICimMetaClass metaClass)
    : EndDeviceFunction(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#SimpleEndDeviceFunction";

    /// <summary>
    /// Вид функции.
    /// </summary>
    public EndDeviceFunctionKind? kind
    {
        get => GetAttribute<EndDeviceFunctionKind?>(nameof(kind));
        set => SetAttribute(nameof(kind), value);
    }
}